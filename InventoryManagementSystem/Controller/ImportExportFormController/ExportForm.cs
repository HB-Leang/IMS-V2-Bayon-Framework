using IMS_Services.Entities;
using IMS_Services.Services.Implementation;
using InventoryManagementSystem.Utils;
using InventoryManagementSystem.Validation;
using System;


namespace InventoryManagementSystem.Controller.ImportExportFormController
{
    public partial class ExportForm : Form
    {
        private static ExportForm? instance = null;
        private Control[] controls;
        public static event CountEventHandler? countEventHandler;

        public ExportForm()
        {
            InitializeComponent();

            LoadData();
            LoadComboBoxes.LoadHandleByCBO(cboHandleBy);

            controls = new Control[]
            {
                txtId,
                dtExportDate,
                nudTotalItem,
                txtTotalCost,
                cboHandleBy,
                dgvExport
            };


            btnInsert.Click += DoClickInsertExport;
            btnUpdate.Click += DoClickUpdateExport;
            btnDelete.Click += DoClickDeleteExport;
            btnClear.Click += DoClickClear;

            dgvExport.Click += DoClickDataGridView;
            instance = this;
        }

       

        private void DoClickInsertExport(object? sender, EventArgs e)
        {
            try
            {
                if (IsExportValid())
                {
                    Export export = CreatorEntities.CreateExport(controls);

                    ExportServices.Add(export);

                    Util.ClearControls(controls);

                    LoadData();

                    MessageBox.Show($"Export Added!", "Creating", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void DoClickUpdateExport(object? sender, EventArgs e)
        {
            try
            {

                if (IsExportValid())
                {
                    Export export = CreatorEntities.CreateExport(controls);

                    export.ID = int.Parse(txtId.Text);

                    bool effected = ExportServices.Update(export);

                    if (effected)
                    {
                        MessageBox.Show($"Export ID : {txtId.Text} Info Updated!", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void DoClickDeleteExport(object? sender, EventArgs e)
        {
            try
            {
                int id = (int)dgvExport.CurrentRow.Cells[0].Value;

                if (id.Equals(-1))
                {
                    MessageBox.Show("Please Choose Export You Want To Delete First ...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show($"Are you sure you want to delete the Export member with ID {id}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    bool isDeleted = ExportServices.Delete(id);

                    if (isDeleted)
                    {
                        MessageBox.Show($"Export with ID {id} has been successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        countEventHandler!.Invoke(this);
                    }
                    else
                    {
                        MessageBox.Show($"No Export member found with ID {id}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            LoadEntities.LoadExportFromDataGrid(controls, dgvExport);
        }



        #region method
        public static ExportForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ExportForm();
            }
            return instance;
        }
        public void LoadData()
        {
            dgvExport.Rows.Clear();
            var result = ExportServices.GetAll();
            foreach (Export export in result)
            {
                AddToView(export);
            }
        }
        private void AddToView(Export export)
        {
            dgvExport.Rows.Add(export.ID, export.ExportDate, export.TotalCost, export.TotalItem, export.HandledBy);
        }

        #endregion

        #region

        private bool IsExportValid()
        {
            bool isVilid = true;
            isVilid = Validator.IsValidData(controls.Skip(1).ToArray());
            return isVilid;
        }

        #endregion
    }
}
