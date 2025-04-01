using IMS_Services.Entities;
using InventoryManagementSystem.Controller;
using InventoryManagementSystem.Convertion;

namespace InventoryManagementSystem.Utils;

public static class CreatorEntities
{
    public static Staff CreateStaff(Control[] controls)
    {
        return new Staff()
        {
            StaffName = Convertor.ConvertToString(controls[1]),
            Gender = Convertor.ConvertToEnumGender(controls[2]),
            BirthDate = Convertor.ConvertToDateTime(controls[3]),
            StaffPosition = Convertor.ConvertToStringFromCbo(controls[4]),
            Address = Convertor.ConvertToString(controls[5]),
            WorkNumber = Convertor.ConvertToString(controls[6]),
            PersonalNumber = Convertor.ConvertToString(controls[7]),
            HiredDate = Convertor.ConvertToDateTime(controls[8]),
            Salary = Convertor.ConvertToDecimal(controls[9]),
            StoppedWork = Convertor.ConvertToBooleanFromCheckBox(controls[10]),
        };
    }
    public static Supplier CreateSupplier(Control[] controls)
    {

        return new Supplier()
        {
           Name = Convertor.ConvertToString(controls[1]),
           Email = Convertor.ConvertToString(controls[2]),
           Address = Convertor.ConvertToString(controls[3]),
           Phone = Convertor.ConvertToString(controls[4]),
           PaymentMethod = Convertor.ConvertToEnumPaymentMethod(controls[5]),
           PaymentTerm = Convertor.ConvertToByte(controls[6])
        };
    }

    public static Product CreateProduct(Control[] controls)
    {
        return new Product()
        {
            Name = Convertor.ConvertToString(controls[1]),
            Barcode = Convertor.ConvertToString(controls[2]),
            SalePrice = Convertor.ConvertToDecimal(controls[3]),
            UOM = Convertor.ConvertToEnumUOM(controls[4]),
            TotalStock = Convertor.ConvertToShort(controls[5]),
            CategoryID = Convertor.ConvertToCategoryID(controls[6]),
        };
    }
    public static Inventory CreateInventory(Control[] controls)
    {
        return new Inventory()
        {
            Note = Convertor.ConvertToString(controls[0]),
            UnitCost = Convertor.ConvertToDecimal(controls[1]),
            InitialQty = Convertor.ConvertToShort(controls[2]),
            CurrentStock = Convertor.ConvertToShort(controls[3]),
            SubTotal = Convertor.ConvertToDecimal(controls[4]),
            ExpirationDate = Convertor.ConvertToDateTime(controls[5]),
            ProductID = Convertor.ConvertToProductID(controls[6]),
            LastUpdate = DateTime.Now,
        };

    }


    public static Category CreateCategory(Control[] controls)
    {
        return new Category()
        {
            Name = Convertor.ConvertToString(controls[1]),
            Description = Convertor.ConvertToString(controls[2]),
        };

    }


    public static Import CreateImport(Control[] controls)
    {
        return new Import()
        {
            ImportDate = Convertor.ConvertToDateTime(controls[1]),
            TotalCost = Convertor.ConvertToDecimal(controls[2]),
            TotalItem = Convertor.ConvertToShort(controls[3]),
            HandledBy = Convertor.ConvertToHandleByID(controls[4]),
            SupplierID = Convertor.ConvertToSupplierID(controls[5]),
        };
    }

    public static Export CreateExport(Control[] controls)
    {
        return new Export()
        {
            ExportDate = Convertor.ConvertToDateTime(controls[1]),
            TotalItem = Convertor.ConvertToShort(controls[2]),
            TotalCost = Convertor.ConvertToDecimal(controls[3]),
            HandledBy = Convertor.ConvertToHandleByID(controls[4]),
        };
    }
    public static ExportDetail CreateExportDetail(Control[] controls)
    {
        return new ExportDetail()
        {
            UnitPrice = Convertor.ConvertToDecimal(controls[0]),
            QtyExported = Convertor.ConvertToShort(controls[1]),
            SubTotal = Convertor.ConvertToDecimal(controls[2]),
            ProductID = Convertor.ConvertToProductID(controls[3]),
            InvID = Convertor.ConvertToInvID(controls[4]),
        };
    }

    public static User CreateUser(Control[] controls)
    {
        return new User()
        {
            Username = Convertor.ConvertToString(controls[1]),
            Password = Convertor.ConvertToString(controls[2]),
            IsLocked = Convertor.ConvertToBooleanFromCheckBox(controls[3]),
            Attempt = Convertor.ConvertToInt16(controls[4]),
            StaffID = Convertor.ConvertToHandleByID(controls[5]),
        };
    }


}
