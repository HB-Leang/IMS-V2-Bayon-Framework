using IMS_Services.Entities;
using IMS_Services.Services.Implementation;
using InventoryManagementSystem.Controller.ImportExportFormController.SubImportExportForm;
using InventoryManagementSystem.Controller.InventoryFormController;
using InventoryManagementSystem.Controller.InventoryFormController.InventorySubForm;
using System.Data;


namespace InventoryManagementSystem.Controller.ImportExportFormController;

public partial class ExportDetailForm : Form
{
    BindingSource bs = new BindingSource();

    DataTable tblExportDetail = new DataTable("tbExportDetail");
    public ExportDetailForm()
    {
        InitializeComponent();
        ExportDetailServices.RetrieveData(tblExportDetail);

        bs.DataSource = tblExportDetail;
        dgvExportDetail.DataSource = bs;
        ConfigView();

        
        btnAdd.Click += DoClickAddExportDetail;
        btnUpdate.Click += DoClikcUpdate;
        btnDelete.Click += DoClickDelete;
        dgvExportDetail.Click += DoClikDataGridView;
    }

    private void DoClickDelete(object? sender, EventArgs e)
    {
        try
        {
            int id = (int)dgvExportDetail.CurrentRow.Cells[0].Value;

            if (id.Equals(-1))
            {
                MessageBox.Show("Please Choose Export Detail You Want To Delete First ...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to delete the Export Detail member with ID {id}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                bool isDeleted = ExportDetailServices.Delete(id);

                if (isDeleted)
                {
                    MessageBox.Show($"ExportDetail with ID {id} has been successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ExportDetailServices.RetrieveData(tblExportDetail);
                    ProductForm.GetInstance().LoadData();
                    InventoryForm.GetInstance().LoadData();
                    ImportForm.GetInstance().LoadData();
                    ExportForm.GetInstance().LoadData();
                }
                else
                {
                    MessageBox.Show($"No ExportDetail member found with ID {id}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Deletion canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void DoClikcUpdate(object? sender, EventArgs e)
    {
        if (dgvExportDetail.CurrentRow == null)
        {
            MessageBox.Show("Please pick a product!", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        ExportDetail exportDetail = ExportDetailServices.GetById((int)dgvExportDetail.CurrentRow.Cells[0].Value);

        UpdateExportDetail.exportDetail = exportDetail;
        
        UpdateExportDetail updateInventoryForm = new UpdateExportDetail();
        updateInventoryForm.ExportModified += (sender) =>
        {
            ExportDetailServices.RetrieveData(tblExportDetail);
            ProductForm.GetInstance().LoadData();
            InventoryForm.GetInstance().LoadData();
            ImportForm.GetInstance().LoadData();
            ExportForm.GetInstance().LoadData();

        };
        updateInventoryForm.Show();
    }

    private void DoClikDataGridView(object? sender, EventArgs e)
    {
        if (dgvExportDetail.CurrentRow == null) return;
    }

    private void DoClickAddExportDetail(object? sender, EventArgs e)
    {
        SubExportDetail.Table = tblExportDetail.Clone();
        SubExportDetail subExportDetail = new SubExportDetail();
        subExportDetail.ExportModified += (sender) =>
        {
            ExportDetailServices.RetrieveData(tblExportDetail);
            ExportDetailServices.RetrieveData(tblExportDetail);
            ProductForm.GetInstance().LoadData();
            InventoryForm.GetInstance().LoadData();
            ImportForm.GetInstance().LoadData();
            ExportForm.GetInstance().LoadData();
        };
        subExportDetail.Show();
    }
    private void ConfigView()
    {
        dgvExportDetail.Columns["ExportDetailID"].Width = 200;
    }

}
