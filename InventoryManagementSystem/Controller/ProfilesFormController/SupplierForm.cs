using IMS_Services.Entities;
using IMS_Services.EnumUtils;
using IMS_Services.Services.Implementation;
using InventoryManagementSystem.Utils;
using InventoryManagementSystem.Validation;
using Microsoft.IdentityModel.Tokens;

namespace InventoryManagementSystem.Controller.ProfilesFormController
{
    public partial class SupplierForm : Form
    {
        private Control[] controls;

        public SupplierForm()
        {
            InitializeComponent();

            LoadData();

            controls = new Control[]
            {
                txtId,
                txtName,
                txtEmail,
                txtAddress,
                mtxtPhone,
                cboPaymentMethod,
                txtPaymentTerm,
                dgvSupplier
            };


            cboPaymentMethod.DataSource = Enum.GetValues<EnumPaymentMethod>();
            cboPaymentMethod.SelectedIndex = 0;


            btnInsert.Click += DoClickInsertSupplier;
            btnUpdate.Click += DoClickUpdateSupplier;
            btnClear.Click += DoClickClear;
            btnDelete.Click += DoClickDeleteSupplier;


            dgvSupplier.Click += DoClickDataGridView;
            txtSearch.TextChanged += DoSearchTextChange;
        }


        #region Click Event

        private void DoSearchTextChange(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                LoadData();
                return;
            };

            var result = SupplierServices.GetByName(txtSearch.Text);
            dgvSupplier.Rows.Clear();
            foreach (var supplier in result)
            {
                AddToView(supplier);
            }
        }


        private void DoClickDeleteSupplier(object? sender, EventArgs e)
        {
            try
            {
                if (txtId.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("Please Choose Supplier You Want To Delete First ...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show($"Are you sure you want to delete the Supplier member with ID {txtId.Text}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    bool isDeleted = SupplierServices.Delete(byte.Parse(txtId.Text));

                    if (isDeleted)
                    {
                        MessageBox.Show($"Supplier with ID {txtId.Text} has been successfully deleted.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"No Supplier member found with ID {txtId.Text}.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Deletion canceled.",
                        "Canceled",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
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

        private void DoClickInsertSupplier(object? sender, EventArgs e)
        {
            try
            {
                if (IsSupplierValid())
                {

                    Supplier supplier = CreatorEntities.CreateSupplier(controls);


                    SupplierServices.Add(supplier);


                    Util.ClearControls(controls);
                    cboPaymentMethod.SelectedIndex = 0;
                    LoadData();

                    // show message to user
                    MessageBox.Show($"Supplier Added!", "Creating", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void DoClickUpdateSupplier(object? sender, EventArgs e)
        {
            try
            {
                if (IsSupplierValid())
                {


                    Supplier supplier = CreatorEntities.CreateSupplier(controls);
                    
                    supplier.ID = byte.Parse(txtId.Text);

                    bool effected = SupplierServices.Update(supplier);

                    if (effected)
                    {
                        MessageBox.Show($"Supplier ID : {txtId.Text} Info Updated!", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Util.ClearControls(controls);
                        cboPaymentMethod.SelectedIndex = 0;
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


        private void DoClickDataGridView(object? sender, EventArgs e)
        {
            btnInsert.Enabled = false;
            LoadEntities.LoadSupplierFromDataGrid(controls, dgvSupplier);
        }

        private void DoClickClear(object? sender, EventArgs e)
        {

            Util.ClearControls(controls);
            cboPaymentMethod.SelectedIndex = 0;
            btnInsert.Enabled = true;
        }

        #endregion

        #region

        private void LoadData()
        {
            dgvSupplier.Rows.Clear();

            var result = SupplierServices.GetAll();
            foreach (var supplier in result)
            {
                AddToView(supplier);
            }
        }

        private void AddToView(Supplier supplier)
        {
            dgvSupplier.Rows.Add(supplier.ID, supplier.Name, supplier.Phone, supplier.PaymentMethod, supplier.PaymentTerm);
        }

        #endregion

        #region Validation
        private bool IsSupplierValid()
        {
            bool isVilid = true;
            isVilid = Validator.IsValidData(controls.Skip(1).ToArray());
            return isVilid;
        }
        #endregion

        
    }
}
