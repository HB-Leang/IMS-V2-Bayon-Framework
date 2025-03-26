
using IMS_Services.Entities;
using IMS_Services.Services.Implementation;
using InventoryManagementSystem.Controller.ImportExportFormController;
using InventoryManagementSystem.Controller.InventoryFormController.InventorySubForm;
using Microsoft.Data.SqlClient;
using System.Data;

namespace InventoryManagementSystem.Controller.InventoryFormController;

public partial class InventoryForm : Form
{
    private static InventoryForm? instance = null;

    
    BindingSource bs = new BindingSource();

    DataTable tblInv = new DataTable("tbInventory");

    public InventoryForm()
    {
        InitializeComponent();

        InventoryServices.RetrieveData(tblInv);

        bs.DataSource = tblInv;

        dgvInventory.DataSource = bs;

        ConfigView();

        btnAdd.Click += DoClickAddInventory;
        btnDelete.Click += DoClickDeleteInventory;
        btnUpdate.Click += DoClickUpdateInventory;

        dgvInventory.Click += DoClickDataGridView;

        instance = this;
    }

    private void DoClickDeleteInventory(object? sender, EventArgs e)
    {
        try
        {
            int id = (int)dgvInventory.CurrentRow.Cells[0].Value;

            if (id.Equals(-1))
            {
                MessageBox.Show("Please Choose Inventory You Want To Delete First ...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            short currQty = (short)dgvInventory.CurrentRow.Cells["CurrentStock"].Value;
            short initQty = (short)dgvInventory.CurrentRow.Cells["InitialQty"].Value;

            if (currQty != initQty)
            {
                MessageBox.Show("Cannot do delete on this inventory!\nThe CurrentStock already deducted", "Deleting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to delete the Inventory member with ID {id}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                bool isDeleted = InventoryServices.Delete(id);

                if (isDeleted)
                {
                    MessageBox.Show($"Inventory with ID {id} has been successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    InventoryServices.RetrieveData(tblInv);
                    ProductForm.GetInstance().LoadData();
                    ImportForm.GetInstance().LoadData(); ;
                }
                else
                {
                    MessageBox.Show($"No Inventory member found with ID {id}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Deletion canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bs.ResetBindings(true);

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void DoClickDataGridView(object? sender, EventArgs e)
    {
        if (dgvInventory.CurrentRow == null) return;
    }

    private void DoClickUpdateInventory(object? sender, EventArgs e)
    {

        if (dgvInventory.CurrentRow == null)
        {
            MessageBox.Show("Please pick a product!", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        Inventory inventory = InventoryServices.GetById((int)dgvInventory.CurrentRow.Cells[0].Value);

        if (inventory.CurrentStock != inventory.InitialQty)
        {
            MessageBox.Show("Cannot do update on this inventory!\nThe CurrentStock already deducted", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        UpdateInventoryForm.inventory = inventory;

        UpdateInventoryForm updateInventoryForm = new UpdateInventoryForm();
        updateInventoryForm.InventoryModified += (sender)=>
        {
            InventoryServices.RetrieveData(tblInv);
            ProductForm.GetInstance().LoadData();
            ImportForm.GetInstance().LoadData(); ;
        };
        updateInventoryForm.Show();

    }


    public static InventoryForm GetInstance()
    {
        if (instance == null || instance.IsDisposed)
        {
            instance = new InventoryForm();
        }
        return instance;
    }

    public void LoadData()
    {
        InventoryServices.RetrieveData(tblInv);
    }
    private void ConfigView()
    {
        dgvInventory.Columns["ExpirationDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
        dgvInventory.Columns["LastUpdate"].DefaultCellStyle.Format = "dd/MM/yyyy";
        dgvInventory.Columns["InvID"].Width = 200;
    }

    private void DoClickAddInventory(object? sender, EventArgs e)
    {
        SubInventory.Table = tblInv.Clone();
        SubInventory subInventory = new SubInventory();
        subInventory.InventoryModified += (sender) =>
        {
            InventoryServices.RetrieveData(tblInv);
            ProductForm.GetInstance().LoadData();
            ImportForm.GetInstance().LoadData();
        };
        subInventory.Show();
    }
}
