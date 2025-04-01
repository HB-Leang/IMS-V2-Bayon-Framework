using IMS_Services.Entities;
using IMS_Services.EnumUtils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IMS_Services.Services;

public static class IDataRecordExtension
{
    public static Staff ToStaff(this IDataRecord record)
    {
        int index = record.GetOrdinal("StaffID");
        short id = record.GetInt16(index);

        index = record.GetOrdinal("StaffName");
        string staffName = record.GetString(index);

        index = record.GetOrdinal("Gender");
        EnumGender gender = (EnumGender)record.GetByte(index);

        index = record.GetOrdinal("BirthDate");
        DateTime birthDate = record.GetDateTime(index);

        index = record.GetOrdinal("StaffPosition");
        string staffPos = record.GetString(index);

        index = record.GetOrdinal("Address");
        string adddress = record.GetString(index);

        index = record.GetOrdinal("WorkNumber");
        string workNum = record.GetString(index);

        index = record.GetOrdinal("PersonalNumber");
        string personalNum = record.GetString(index);

        index = record.GetOrdinal("HiredDate");
        DateTime hiredDate = record.GetDateTime(index);

        index = record.GetOrdinal("Salary");
        decimal salary = record.GetDecimal(index);

        index = record.GetOrdinal("StoppedWork");
        bool stoppedWork = record.GetBoolean(index);

        return new Staff()
        {
            StaffId = id,
            StaffName = staffName,
            Gender = gender,
            BirthDate = birthDate,
            StaffPosition = staffPos,
            Address = adddress,
            WorkNumber = workNum,
            PersonalNumber = personalNum,
            HiredDate = hiredDate,
            Salary = salary,
            StoppedWork = stoppedWork,
        };
    }
    public static Inventory ToInventory(this IDataRecord record)
    {
        int index = record.GetOrdinal("InvID");
        int id = record.GetInt32(index);

        index = record.GetOrdinal("UnitCost");
        decimal unitCost = record.GetDecimal(index);

        index = record.GetOrdinal("ExpirationDate");
        DateTime expDate = record.GetDateTime(index);

        index = record.GetOrdinal("CurrentStock");
        short curStock = record.GetInt16(index);

        index = record.GetOrdinal("SubTotal");
        decimal subTotal = record.GetDecimal(index); 

        index = record.GetOrdinal("InitialQty");
        short initQty = record.GetInt16(index);

        index = record.GetOrdinal("ProductID");
        int proID = record.GetInt32(index);

        index = record.GetOrdinal("ImportID");
        int impID = record.GetInt32(index);

        index = record.GetOrdinal("Note");
        string note = record.GetString(index);

        index = record.GetOrdinal("LastUpdate");
        DateTime lUpdate = record.GetDateTime(index);

        return new Inventory()
        {
            ID = id,
            UnitCost = unitCost,
            ExpirationDate = expDate,
            CurrentStock = curStock,
            InitialQty = initQty,
            SubTotal = subTotal,
            ProductID = proID,
            ImportID = impID,
            Note = note,
            LastUpdate = lUpdate,
        };
    }
    public static Product ToProduct(this IDataRecord record)
    {
        int index = record.GetOrdinal("ProductID");
        int id = record.GetInt32(index);

        index = record.GetOrdinal("ProductName");
        string name = record.GetString(index);

        index = record.GetOrdinal("Barcode");
        string barcode = record.GetString(index);

        index = record.GetOrdinal("SalePrice");
        decimal price = record.GetDecimal(index);

        index = record.GetOrdinal("UOM");
        EnumUOM uom = (EnumUOM)record.GetByte(index);

        index = record.GetOrdinal("TotalStock");
        short totalStock = record.GetInt16(index);

        index = record.GetOrdinal("CategoryID");
        byte cateID = record.GetByte(index);

        return new Product()
        {
            ID = id,
            Name = name,
            Barcode = barcode,
            SalePrice = price,
            UOM = uom,
            TotalStock = totalStock,
            CategoryID = cateID,
        };
    }

    public static Supplier ToSupplier(this IDataRecord record)
    {
        int index = record.GetOrdinal("SupplierID");
        byte id = record.GetByte(index);

        index = record.GetOrdinal("SupplierName");
        string name = record.GetString(index);

        index = record.GetOrdinal("Email");
        string email = record.GetString(index);

        index = record.GetOrdinal("Address");
        string address = record.GetString(index);

        index = record.GetOrdinal("Phone");
        string phone = record.GetString(index);

        index = record.GetOrdinal("PaymentMethod");
        EnumPaymentMethod paymentMethod = (EnumPaymentMethod)record.GetByte(index);

        index = record.GetOrdinal("PaymentTerm");
        byte paymentTerm = record.GetByte(index);

        return new Supplier()
        {
            ID = id,
            Name = name,
            Email = email,
            Phone = phone,
            Address = address,
            PaymentMethod = paymentMethod,
            PaymentTerm = paymentTerm,
        };
    }

    public static Category ToCategory(this IDataRecord record) {

        int index = record.GetOrdinal("CategoryID");
        byte id = record.GetByte(index);

        index = record.GetOrdinal("CategoryName");
        string name = record.GetString(index);

        index = record.GetOrdinal("CategoryDesc");
        string desc = record.GetString(index);

        return new Category()
        {
            ID=id,
            Name = name,
            Description = desc,
        };
    }

    public static Import ToImport(this IDataRecord record)
    {

        int index = record.GetOrdinal("ImportID");
        int id = record.GetInt32(index);

        index = record.GetOrdinal("ImportDate");
        DateTime date = record.GetDateTime(index);

        index = record.GetOrdinal("TotalCost");
        decimal tc = record.GetDecimal(index);

        index = record.GetOrdinal("TotalItem");
        short ti = record.GetInt16(index);

        index = record.GetOrdinal("HandledBy");
        short h = record.GetInt16(index);

        index = record.GetOrdinal("SupplierID");
        byte s = record.GetByte(index);


        return new Import()
        {
            ID = id,
            ImportDate = date,
            TotalCost = tc,
            TotalItem = ti,
            HandledBy = h,
            SupplierID = s
        };
    }

    public static Export ToExport(this IDataRecord record)
    {

        int index = record.GetOrdinal("ExportID");
        int id = record.GetInt32(index);

        index = record.GetOrdinal("ExportDate");
        DateTime date = record.GetDateTime(index);

        

        index = record.GetOrdinal("TotalItems");
        short ti = record.GetInt16(index);

        index = record.GetOrdinal("TotalCost");
        decimal tc = record.GetDecimal(index);

        index = record.GetOrdinal("HandledBy");
        short h = record.GetInt16(index);



        return new Export()
        {
            ID = id,
            ExportDate = date,
            TotalCost = tc,
            TotalItem = ti,
            HandledBy = h,
        };
    }
    public static ExportDetail ToExportDetail(this IDataRecord record)
    {

        int index = record.GetOrdinal("ExportDetailID");
        int id = record.GetInt32(index);

        index = record.GetOrdinal("QtyExported");
        short qtye = record.GetInt16(index);

        index = record.GetOrdinal("UnitPrice");
        decimal up = record.GetDecimal(index);

        index = record.GetOrdinal("SubTotal");
        decimal st = record.GetDecimal(index);

        index = record.GetOrdinal("ExportID");
        int expid = record.GetInt32(index);

        index = record.GetOrdinal("ProductID");
        int pid = record.GetInt32(index);

        index = record.GetOrdinal("InvID");
        int invid = record.GetInt32(index);


        return new ExportDetail()
        {
            ID = id,
            QtyExported = qtye,
            UnitPrice = up,
            SubTotal = st,
            ExportID = expid,
            ProductID = pid,
            InvID = invid,
        };
    }
    public static User ToUser(this IDataRecord record)
    {

        int index = record.GetOrdinal("UserID");
        short id = record.GetInt16(index);

        index = record.GetOrdinal("UserName");
        String un = record.GetString(index);

        index = record.GetOrdinal("Password");
        String pass = record.GetString(index);

        index = record.GetOrdinal("IsLocked");
        bool isLocked = record.GetBoolean(index);

        index = record.GetOrdinal("Attempt");
        short attempt = record.GetByte(index);

        index = record.GetOrdinal("LockTime");
        DateTime lockTime = record.IsDBNull(index) ? new DateTime().AddTicks(1) : record.GetDateTime(index);
         
        index = record.GetOrdinal("StaffID");
        short sid = record.GetInt16(index);
        
        return new User()
        {
            ID = id,
            Username = un,
            Password = pass,
            IsLocked = isLocked,
            Attempt = attempt,
            LockTime = lockTime,
            StaffID = sid,
        };
    }
}

