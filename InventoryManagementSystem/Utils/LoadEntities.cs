using IMS_Services.Entities;
using IMS_Services.Services.Implementation;

namespace InventoryManagementSystem.Utils;

public static class LoadEntities
{
    public static void LoadStaffFromListStaff(Control[] controls, ListBox listBox)
    {
        if (listBox.SelectedItem == null) return;
        string? staffData = listBox.SelectedItem.ToString();
        if (staffData == null) return;
        short.TryParse(staffData.Split('.')[0], out short staffId);
        try
        {
            Staff staff = (Staff)StaffServices.GetById(staffId);

            controls[0].Text = staff.StaffId.ToString();
            controls[1].Text = staff.StaffName;
            Casting.CastCombobox(controls[2]).SelectedItem = staff.Gender;
            Casting.CastDateTimePicker(controls[3]).Value = staff.BirthDate;
            Casting.CastCombobox(controls[4]).SelectedItem = staff.StaffPosition;

            controls[5].Text = staff.Address;

            controls[6].Text = staff.WorkNumber;
            controls[7].Text = staff.PersonalNumber;
            Casting.CastDateTimePicker(controls[8]).Value = staff.HiredDate;
            controls[9].Text = staff.Salary.ToString();
            Casting.CastCheckbox(controls[10]).Checked = staff.StoppedWork;
            
        }
        catch(Exception ex) {
            MessageBox.Show(ex.Message);
        }
    } 
    
    public static void LoadProductFromObject(Control[] controls, Product product)
    {
        controls[0].Text = product.ID.ToString();
        controls[1].Text = product.Name;
        controls[2].Text = product.Barcode;
        controls[3].Text = product.SalePrice.ToString();
        Casting.CastCombobox(controls[4]).SelectedItem = product.UOM;
        Casting.CastNumericUpDown(controls[5]).Value = product.TotalStock;
        Casting.CastCombobox(controls[6]).SelectedValue = product.CategoryID;
    }

    public static void LoadInvnetoryFromObject(Control[] controls, Inventory inventory)
    {
        controls[0].Text = inventory.ID.ToString();
        Casting.CastCombobox(controls[1]).SelectedItem = inventory.ImportID;
        controls[2].Text = inventory.Note;
        controls[3].Text = inventory.UnitCost.ToString();
        Casting.CastNumericUpDown(controls[4]).Value = inventory.InitialQty;
        Casting.CastNumericUpDown(controls[5]).Value = inventory.CurrentStock;
        controls[6].Text = inventory.SubTotal.ToString();
        Casting.CastDateTimePicker(controls[7]).Value = inventory.ExpirationDate;
        Casting.CastCombobox(controls[8]).SelectedValue = inventory.ProductID;
    }

    public static void LoadExportDetailFromObject(Control[] controls, ExportDetail exportDetail)
    {
        controls[0].Text = exportDetail.ID.ToString();
        Casting.CastCombobox(controls[1]).SelectedItem = exportDetail.ExportID;
        controls[2].Text = exportDetail.UnitPrice.ToString();
        Casting.CastNumericUpDown(controls[3]).Value = exportDetail.QtyExported;
        controls[4].Text = exportDetail.SubTotal.ToString();
        Casting.CastCombobox(controls[5]).SelectedValue = exportDetail.ProductID;
        LoadComboBoxes.LoadInventoryID(Casting.CastCombobox(controls[6]), (int)Casting.CastCombobox(controls[5]).SelectedValue!);
        int index = Casting.CastCombobox(controls[6]).FindString(exportDetail.InvID.ToString());
        Casting.CastCombobox(controls[6]).SelectedIndex = index; 
    }
    public static void LoadSupplierFromDataGrid(Control[] controls, DataGridView dgv)
    {
        if (dgv.CurrentRow == null) return;
        byte selectedId = (byte)dgv.CurrentRow.Cells[0].Value;

        try
        {
            Supplier supplier = SupplierServices.GetById(selectedId);

            if (supplier == null) return;

            controls[0].Text = supplier.ID.ToString();
            controls[1].Text = supplier.Name;
            controls[2].Text = supplier.Email;
            controls[3].Text = supplier.Address;
            controls[4].Text = supplier.Phone;
            Casting.CastCombobox(controls[5]).SelectedItem = supplier.PaymentMethod;
            controls[6].Text = supplier.PaymentTerm.ToString();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

    }

    public static void LoadCategoryFromDataGrid(Control[] controls, DataGridView dgv)
    {
        if (dgv.CurrentRow == null) return;
        byte selectedId = (byte)dgv.CurrentRow.Cells[0].Value;

        try
        {
            Category category = CategoryServices.GetById(selectedId);

            if (category == null) return;

            controls[0].Text = category.ID.ToString();
            controls[1].Text = category.Name;
            controls[2].Text = category.Description;

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

    }


    public static void LoadImportFromDataGrid(Control[] controls, DataGridView dgv)
    {
        if (dgv.CurrentRow == null) return;
        int selectedId = (int)dgv.CurrentRow.Cells[0].Value;

        try
        {
            Import import = ImportServices.GetById(selectedId);

            if (import == null) return;

            controls[0].Text = import.ID.ToString();
            Casting.CastDateTimePicker(controls[1]).Value = import.ImportDate;
            controls[2].Text = import.TotalCost.ToString();
            Casting.CastNumericUpDown(controls[3]).Value = import.TotalItem;
            Casting.CastCombobox(controls[4]).SelectedValue = import.HandledBy;
            Casting.CastCombobox(controls[5]).SelectedValue = import.SupplierID;

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

    }

    public static void LoadExportFromDataGrid(Control[] controls, DataGridView dgv)
    {
        if (dgv.CurrentRow == null) return;
        int selectedId = (int)dgv.CurrentRow.Cells[0].Value;

        try
        {
            Export export = ExportServices.GetById(selectedId);

            if (export == null) return;

            controls[0].Text = export.ID.ToString();
            Casting.CastDateTimePicker(controls[1]).Value = export.ExportDate;
            Casting.CastNumericUpDown(controls[2]).Value = export.TotalItem;
            controls[3].Text = export.TotalCost.ToString();
            Casting.CastCombobox(controls[4]).SelectedValue = export.HandledBy;
            
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

    }

    public static void LoadUserFromListStaff(Control[] controls, ListBox listBox)
    {
        if (listBox.SelectedItem == null) return;
        string? data = listBox.SelectedItem.ToString();
        if (data == null) return;
        short.TryParse(data.Split('.')[0], out short userId);
        try
        {
            User user = (User)UserServices.GetById(userId);

            controls[0].Text = user.ID.ToString();
            controls[1].Text = user.Username;
            controls[2].Text = user.Password;

            Casting.CastCheckbox(controls[3]).Checked = (bool) user.IsLocked!;
            Casting.CastNumericUpDown(controls[4]).Value = (decimal) user.Attempt!;
            Casting.CastCombobox(controls[5]).SelectedValue = user.StaffID;
        
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

}
