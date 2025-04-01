CREATE DATABASE [IMS_OOAD_DB];
GO
USE [IMS_OOAD_DB];
GO

-- Inventory Management --

	-- Create Table Staff
	CREATE TABLE tbStaff(
		StaffID SMALLINT IDENTITY(1,1) PRIMARY KEY, 
		StaffName VARCHAR(50) NOT NULL, 
		Gender TINYINT NOT NULL, 
		BirthDate DATE NOT NULL, 
		StaffPosition VARCHAR(75) NOT NULL, 
		Address VARCHAR(255) NOT NULL,
		WorkNumber VARCHAR(20) NOT NULL, 
		PersonalNumber VARCHAR(20) NOT NULL,
		HiredDate DATE NOT NULL, 
		Salary MONEY NOT NULL, 
		StoppedWork BIT NOT NULL
	);
	GO
	-- Create Table Supplier
	CREATE TABLE tbSupplier(
		SupplierID TINYINT IDENTITY(1,1) PRIMARY KEY,
		SupplierName VARCHAR(50),
		Email VARCHAR(255),
		Phone VARCHAR(20),
		Address VARCHAR(255),
		PaymentMethod TINYINT,
		PaymentTerm TINYINT,
	);
	GO

	-- Create Table Category
	CREATE TABLE tbCategory(
		CategoryID TINYINT IDENTITY(1,1) PRIMARY KEY,
		CategoryName VARCHAR(50),
		CategoryDesc VARCHAR(255),
	);
	GO

	-- Create Table Product
	CREATE TABLE tbProduct(
		ProductID INT IDENTITY(1,1) PRIMARY KEY,
		ProductName VARCHAR(50),
		Barcode VARCHAR(300),
		SalePrice DECIMAL(10,2),
		UOM TINYINT, -- Unit of Measure
		TotalStock SMALLINT,
		CategoryID TINYINT,
		CONSTRAINT FK_tbProduct_CategoryID FOREIGN KEY (CategoryID) REFERENCES tbCategory(CategoryID) ON DELETE CASCADE ON UPDATE CASCADE,
	);
	GO
	-- Create Table Import
	CREATE TABLE tbImport(
		ImportID INT IDENTITY(1,1) PRIMARY KEY,
		ImportDate DATE,
		TotalCost DECIMAL(10,2),
		TotalItem SMALLINT,
		HandledBy SMALLINT,
		SupplierID TINYINT,
		CONSTRAINT FK_tbImport_HandledBy FOREIGN KEY (HandledBy) REFERENCES tbStaff(StaffID) ON DELETE CASCADE ON UPDATE CASCADE,
		CONSTRAINT FK_tbImport_SupplierID FOREIGN KEY (SupplierID) REFERENCES tbSupplier(SupplierID) ON DELETE CASCADE ON UPDATE CASCADE,
	);
	GO
	-- Create Table Inventory 
	CREATE TABLE tbInventory(
		InvID INT IDENTITY(1,1) PRIMARY KEY,
		UnitCost DECIMAL(10,2),
		ExpirationDate DATE,
		CurrentStock SMALLINT,
		InitialQty SMALLINT,
		SubTotal DECIMAL(10,2),
		LastUpdate DATE,
		ProductID INT,
		ImportID INT,
		Note VARCHAR(255),
		CONSTRAINT FK_tbInventory_ProductID FOREIGN KEY (ProductID) REFERENCES tbProduct(ProductID) ON DELETE CASCADE ON UPDATE CASCADE,
		CONSTRAINT FK_tbInventory_ImportID FOREIGN KEY (ImportID) REFERENCES tbImport(ImportID) ON DELETE CASCADE ON UPDATE CASCADE,
	);
	GO
	-- Create Table Export
	CREATE TABLE tbExport(
		ExportID INT IDENTITY(1,1) PRIMARY KEY,
		ExportDate DATE,
		TotalItems SMALLINT,
		TotalCost DECIMAL(10,2),
		HandledBy SMALLINT,
		CONSTRAINT FK_tbExport_HandledBy FOREIGN KEY (HandledBy) REFERENCES tbStaff(StaffID) ON DELETE CASCADE ON UPDATE CASCADE,
	);
	GO
	-- Create Table ExportDetail
	CREATE TABLE tbExportDetail(
		ExportDetailID INT IDENTITY(1,1) PRIMARY KEY,
		QtyExported SMALLINT,
		UnitPrice DECIMAL(10,2),
		SubTotal DECIMAL(10,2),
		ExportID INT,
		ProductID INT,
		InvID INT,
		CONSTRAINT FK_tbExportDetail_ExportID FOREIGN KEY (ExportID) REFERENCES tbExport(ExportID) ON DELETE CASCADE ON UPDATE CASCADE,
		CONSTRAINT FK_tbExportDetail_ProductID FOREIGN KEY (ProductID) REFERENCES tbProduct(ProductID) ON DELETE CASCADE ON UPDATE CASCADE,
		CONSTRAINT FK_tbExportDetail_InvID FOREIGN KEY (InvID) REFERENCES tbInventory(InvID) ON DELETE NO ACTION ON UPDATE NO ACTION,
	);
	GO
	-- Create Table User
	CREATE TABLE tbUser(
		UserID SMALLINT IDENTITY(1,1) PRIMARY KEY,
		Username VARCHAR(50) NOT NULL,
		Password VARCHAR(50) NOT NULL,
		StaffID SMALLINT,
		CONSTRAINT FK_tbUser_StaffID FOREIGN KEY (StaffID) REFERENCES tbStaff(StaffID) ON DELETE CASCADE ON UPDATE CASCADE,
	);
	GO


/* Start of DB Triggers */

CREATE TRIGGER InsertInventory
ON tbInventory
AFTER INSERT
AS
BEGIN
    -- Update TotalStock in tbProduct
    UPDATE p
    SET p.TotalStock = p.TotalStock + i.TotalQty
    FROM tbProduct p
    INNER JOIN (
        SELECT ProductID, SUM(InitialQty) AS TotalQty
        FROM INSERTED
        GROUP BY ProductID
    ) i ON p.ProductID = i.ProductID;

    -- Update TotalItem and TotalCost in tbImport
    UPDATE imp
    SET 
        imp.TotalItem = imp.TotalItem + i.TotalQty,
        imp.TotalCost = imp.TotalCost + i.TotalCost
    FROM tbImport imp
    INNER JOIN (
        SELECT ImportID, SUM(InitialQty) AS TotalQty, SUM(SubTotal) AS TotalCost
        FROM INSERTED
        GROUP BY ImportID
    ) i ON imp.ImportID = i.ImportID;
END;
GO


CREATE TRIGGER UpdateInventory
ON tbInventory
AFTER UPDATE
AS
BEGIN
    -- Update TotalStock in tbProduct
    UPDATE p
    SET p.TotalStock = p.TotalStock + d.StockDifference
    FROM tbProduct p
    INNER JOIN (
        SELECT 
            d.ProductID,
            SUM(i.CurrentStock - d.CurrentStock) AS StockDifference
        FROM DELETED d
        INNER JOIN INSERTED i ON d.InvID = i.InvID
        GROUP BY d.ProductID
    ) d ON p.ProductID = d.ProductID;

    -- Update TotalItem and TotalCost in tbImport
    UPDATE imp
    SET 
        imp.TotalItem = imp.TotalItem + t.ItemDifference,
        imp.TotalCost = imp.TotalCost + t.CostDifference
    FROM tbImport imp
    INNER JOIN (
        SELECT 
            d.ImportID,
            SUM(i.InitialQty - d.InitialQty) AS ItemDifference,
            SUM(i.SubTotal - d.SubTotal) AS CostDifference
        FROM DELETED d
        INNER JOIN INSERTED i ON d.InvID = i.InvID
        GROUP BY d.ImportID
    ) t ON imp.ImportID = t.ImportID;
END;
GO

CREATE TRIGGER DeleteInventory
ON tbInventory
AFTER DELETE
AS
BEGIN
    -- Update TotalStock in tbProduct
    UPDATE p
    SET p.TotalStock = p.TotalStock - d.TotalQty
    FROM tbProduct p
    INNER JOIN (
        SELECT ProductID, SUM(InitialQty) AS TotalQty
        FROM DELETED
        GROUP BY ProductID
    ) d ON p.ProductID = d.ProductID;

    -- Update TotalItem in tbImport
    UPDATE imp
    SET imp.TotalItem = imp.TotalItem - d.TotalQty
    FROM tbImport imp
    INNER JOIN (
        SELECT ImportID, SUM(InitialQty) AS TotalQty
        FROM DELETED
        GROUP BY ImportID
    ) d ON imp.ImportID = d.ImportID;
END;
GO

CREATE TRIGGER InsertExportDetail
ON tbExportDetail
AFTER INSERT
AS
BEGIN
    -- Update CurrentStock in tbInventory
    UPDATE INV
    SET INV.CurrentStock = INV.CurrentStock - i.TotalQty
    FROM tbInventory INV
    INNER JOIN (
        SELECT InvID, SUM(QtyExported) AS TotalQty
        FROM INSERTED
        GROUP BY InvID
    ) i ON INV.InvID = i.InvID;

    -- Update TotalItems and TotalCost in tbExport
    UPDATE exp
    SET 
        exp.TotalItems = exp.TotalItems + i.TotalQty,
        exp.TotalCost = exp.TotalCost + i.TotalCost
    FROM tbExport exp
    INNER JOIN (
        SELECT ExportID, SUM(QtyExported) AS TotalQty, SUM(SubTotal) AS TotalCost
        FROM INSERTED
        GROUP BY ExportID
    ) i ON exp.ExportID = i.ExportID;
END;
GO


CREATE TRIGGER UpdateExportDetail
ON tbExportDetail
AFTER UPDATE
AS
BEGIN
    -- Update CurrentStock in tbInventory
    UPDATE INV
    SET INV.CurrentStock = INV.CurrentStock + diff.OldQty - diff.NewQty
    FROM tbInventory INV
    INNER JOIN (
        SELECT 
            d.InvID, 
            d.QtyExported AS OldQty, 
            i.QtyExported AS NewQty
        FROM DELETED d
        INNER JOIN INSERTED i ON d.ExportDetailID = i.ExportDetailID
    ) diff ON INV.InvID = diff.InvID;

    -- Update TotalItems and TotalCost in tbExport
    UPDATE exp
    SET 
        exp.TotalItems = exp.TotalItems + diff.ItemDifference,
        exp.TotalCost = exp.TotalCost + diff.CostDifference
    FROM tbExport exp
    INNER JOIN (
        SELECT 
            d.ExportID,
            SUM(i.QtyExported - d.QtyExported) AS ItemDifference,
            SUM(i.SubTotal - d.SubTotal) AS CostDifference
        FROM DELETED d
        INNER JOIN INSERTED i ON d.ExportDetailID = i.ExportDetailID
        GROUP BY d.ExportID
    ) diff ON exp.ExportID = diff.ExportID;
END;
GO



CREATE TRIGGER DeleteExportDetail
ON tbExportDetail
AFTER DELETE
AS
BEGIN
    -- Restore CurrentStock in tbInventory
    UPDATE INV
    SET INV.CurrentStock = INV.CurrentStock + d.QtyExported
    FROM tbInventory INV
    INNER JOIN (
        SELECT InvID, SUM(QtyExported) AS QtyExported
        FROM DELETED
        GROUP BY InvID
    ) d ON INV.InvID = d.InvID;

    -- Adjust TotalItems and TotalCost in tbExport
    UPDATE exp
    SET 
        exp.TotalItems = exp.TotalItems - d.TotalQty,
        exp.TotalCost = exp.TotalCost - d.TotalCost
    FROM tbExport exp
    INNER JOIN (
        SELECT 
            ExportID,
            SUM(QtyExported) AS TotalQty,
            SUM(SubTotal) AS TotalCost
        FROM DELETED
        GROUP BY ExportID
    ) d ON exp.ExportID = d.ExportID;
END;
GO

CREATE TRIGGER ManageExpiredStock
ON tbInventory
AFTER UPDATE
AS
BEGIN
    -- Deduct stock when transitioning from Active (0) to Expired (1)
    UPDATE p
    SET p.TotalStock = p.TotalStock - i.CurrentStock
    FROM tbProduct p
    INNER JOIN INSERTED i ON p.ProductID = i.ProductID
    INNER JOIN DELETED d ON i.InvID = d.InvID
    WHERE i.Status = 1 -- New status is Expired
    AND d.Status = 0 -- Old status was Active
    AND i.CurrentStock > 0;

    -- Add stock back when transitioning from Expired (1) to Active (0)
    UPDATE p
    SET p.TotalStock = p.TotalStock + i.CurrentStock
    FROM tbProduct p
    INNER JOIN INSERTED i ON p.ProductID = i.ProductID
    INNER JOIN DELETED d ON i.InvID = d.InvID
    WHERE i.Status = 0 -- New status is Active
    AND d.Status = 1 -- Old status was Expired
    AND i.CurrentStock > 0;
END;
GO

/* End of DB Triggers */
INSERT INTO tbStaff VALUES('piko', 1, '2000-01-01', 'Manager', 'PP', '(855) 12-345-67', '(855) 12-345-67', '2024-11-26', 3000.0000, 0)
INSERT INTO tbUser VALUES('piko', 'piko', 1);