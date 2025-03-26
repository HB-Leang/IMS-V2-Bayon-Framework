using IMS_Services.Entities;
using IMS_Services.Services.Implementation;
using InventoryManagementSystem.Utils;
using InventoryManagementSystem.Validation;
using Microsoft.IdentityModel.Tokens;


namespace InventoryManagementSystem.Controller.InventoryFormController.InventorySubForm
{
    public partial class UpdateInventoryForm : Form
    {
        private static UpdateInventoryForm instance = null!;
        private Control[] controls;

        public event InventoryEventHandler? InventoryModified;
        public static Inventory inventory { get; set; } = null!;

        public UpdateInventoryForm()
        {
            InitializeComponent();

            LoadComboBoxes.LoadProductCBO(cboProduct);
            LoadComboBoxes.LoadImportID(cboImportID);

            controls = new Control[]
            {
                txtId,
                cboImportID,
                rtxtNote,
                txtUnitCost,
                nudInitQty,
                nudCurrStock,
                txtSubTotal,
                dtExpireDate,
                cboProduct,
            };

            LoadEntities.LoadInvnetoryFromObject(controls, inventory);

            btnSubmit.Click += DoClickSubmit;
            txtUnitCost.TextChanged += DoCalculate;
            nudInitQty.ValueChanged += DoCalculate;
        }

        private void DoCalculate(object? sender, EventArgs e)
        {
            if (txtUnitCost.Text.IsNullOrEmpty()) return;
            if (nudInitQty.Value == 0) return;

            decimal subTotal = decimal.Parse(txtUnitCost.Text.Trim()) * (decimal)nudInitQty.Value;

            txtSubTotal.Text = subTotal.ToString();
        }

        private void DoClickSubmit(object? sender, EventArgs e)
        {
            try
            {
                if (IsInventoryValid())
                {
                    Inventory inventory = CreatorEntities.CreateInventory(controls.Skip(2).ToArray());

                    inventory.ID = int.Parse(txtId.Text);

                    inventory.ImportID = int.Parse(cboImportID.SelectedItem.ToString());

                    bool effected = InventoryServices.Update(inventory);

                    if (effected)
                    {
                        MessageBox.Show($"Inventory ID : {txtId.Text} Info Updated!", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        Util.ClearControls(controls);

                        InventoryModified?.Invoke(this);
                    }
                    else
                    {
                        MessageBox.Show($"Error Updating Data", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    
                    Util.ClearControls(controls);
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


        #region Validation


        private bool IsInventoryValid()
        {
            bool isVilid = true;
            isVilid = Validator.IsValidData(controls.Skip(3).ToArray());
            return isVilid;
        }

        #endregion

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
            if (mainForm != null)
            {
                mainForm.Activate();
            }
            base.OnFormClosed(e);
        }

        #region SingleTon For Only Show One Form
        public static UpdateInventoryForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new UpdateInventoryForm();
            }
            return instance;
        }
        public new void Show()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = this;
                base.Show();
            }
            else
            {
                // Bring the existing form to the front if already open
                instance.BringToFront();
            }
        }
        #endregion

    }
}
