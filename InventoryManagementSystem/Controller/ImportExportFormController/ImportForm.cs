using IMS_Services.Entities;
using IMS_Services.Services.Implementation;
using InventoryManagementSystem.Utils;
using InventoryManagementSystem.Validation;
using Microsoft.IdentityModel.Tokens;

namespace InventoryManagementSystem.Controller.ImportExportFormController;


public partial class ImportForm : Form
{
    private static ImportForm? instance = null;

    public static event CountEventHandler? countEventHandler;
    private Control[] controls;

    public ImportForm()
    {
        InitializeComponent();

        LoadData();
        LoadComboBoxes.LoadHandleByCBO(cboHandleBy);
        LoadComboBoxes.LoadSupplierCBO(cboSupplier);

        controls = new Control[]
        {
            txtId,
            dtImportDate,
            txtTotalCost,
            nudTotalItem,
            cboHandleBy,
            cboSupplier,
            dgvImport
        };


        btnInsert.Click += DoClickInsertImport;
        btnUpdate.Click += DoClickUpdateImport;
        btnDelete.Click += DoClickDeleteImport;
        btnClear.Click += DoClickClear;

        dgvImport.Click += DoClickDataGridView;
        instance = this;
    }



    #region Event

    private void DoClickInsertImport(object? sender, EventArgs e)
    {
        try
        {
            if (IsImportValid())
            {

                Import import = CreatorEntities.CreateImport(controls);

                ImportServices.Add(import);

                Util.ClearControls(controls);

                LoadData();

                MessageBox.Show($"Import Added!", "Creating", MessageBoxButtons.OK, MessageBoxIcon.Information);
                countEventHandler!.Invoke(this);
            }
            else
            {
                MessageBox.Show("Some Inputs are missing or not correct format!", "Creating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void DoClickUpdateImport(object? sender, EventArgs e)
    {
        try
        {

            if (IsImportValid())
            {
                
                Import import = CreatorEntities.CreateImport(controls);


                import.ID = int.Parse(txtId.Text);

                bool effected = ImportServices.Update(import);

                if (effected)
                {
                    MessageBox.Show($"Import ID : {txtId.Text} Info Updated!", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Util.ClearControls(controls);
                    LoadData();
                }
                else
                {
                    MessageBox.Show($"Error Updating Data", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                btnInsert.Enabled = true;
            }
            else
            {
                MessageBox.Show("Some Inputs are missing or not correct format!", "Creating", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }

    private void DoClickDeleteImport(object? sender, EventArgs e)
    {
        try
        {
            int id = (int)dgvImport.CurrentRow.Cells[0].Value;

            if (id.Equals(-1))
            {
                MessageBox.Show("Please Choose Import You Want To Delete First ...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to delete the Import member with ID {id}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                bool isDeleted = ImportServices.Delete(id);

                if (isDeleted)
                {
                    MessageBox.Show($"Import with ID {id} has been successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    countEventHandler!.Invoke(this);
                }
                else
                {
                    MessageBox.Show($"No Import member found with ID {id}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Deletion canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            Util.ClearControls(controls);
            LoadData();
            btnInsert.Enabled = true;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }


    private void DoClickClear(object? sender, EventArgs e)
    {
        Util.ClearControls(controls);
        btnInsert.Enabled = true;
    }

    private void DoClickDataGridView(object? sender, EventArgs e)
    {
        btnInsert.Enabled = false;
        LoadEntities.LoadImportFromDataGrid(controls, dgvImport);
    }

    #endregion


    #region method
    public static ImportForm GetInstance()
    {
        if (instance == null || instance.IsDisposed)
        {
            instance = new ImportForm();
        }
        return instance;
    }
    public void LoadData()
    {
        dgvImport.Rows.Clear();
        var result = ImportServices.GetAll();
        foreach (Import import in result)
        {
            AddToView(import);
        }
    }
    private void AddToView(Import import)
    {
        dgvImport.Rows.Add(import.ID, import.ImportDate, import.TotalCost, import.TotalItem, import.HandledBy, import.SupplierID);
    }

    #endregion



    #region

    private bool IsImportValid()
    {
        bool isVilid = true;
        isVilid = Validator.IsValidData(controls.Skip(1).ToArray());
        return isVilid;
    }

    #endregion
}