using IMS_Services.Entities;
using IMS_Services.Services.Implementation;

using System.Data;
using InventoryManagementSystem.Validation;
using InventoryManagementSystem.Utils;
using Microsoft.IdentityModel.Tokens;

namespace InventoryManagementSystem.Controller.InventoryFormController.InventorySubForm
{
    public partial class SubInventory : Form
    {
        public event InventoryEventHandler? InventoryModified;


        private static SubInventory instance = null!;
        private Control[] controls;
        private BindingSource bs = new BindingSource();
        public static DataTable Table = new DataTable(InventoryServices.INV_TB_NAME);

        public SubInventory()
        {
            InitializeComponent();
            Table.Rows.Clear();
            bs.DataSource = Table;
            dgvInventory.DataSource = bs;

            LoadComboBoxes.LoadProductCBO(cboProductId);
            LoadComboBoxes.LoadImportID(cboImportID);
            ConfigView();

            controls = new Control[]
            {
                txtId,
                cboImportID,
                rtxtNote,
                txtUnitCost,
                nudInitQty,
                nudCurrQty,
                txtSubTotal,
                dtExpireDate,
                cboProductId,
            };


            btnAdd.Click += DoClickAdd;
            btnDelete.Click += DoClickDelete;
            btnSubmit.Click += DoClickSubmit;
            txtUnitCost.TextChanged += DoCalculate;
            nudInitQty.ValueChanged += DoCalculate;
        }

        

        private void DoCalculate(object? sender, EventArgs e)
        {
            if (txtUnitCost.Text.IsNullOrEmpty()) return;
            
            decimal subTotal = decimal.Parse(txtUnitCost.Text.Trim()) * (decimal)nudInitQty.Value; 

            txtSubTotal.Text = subTotal.ToString();
        }

        private void DoClickDelete(object? sender, EventArgs e)
        {
            if (dgvInventory.CurrentRow == null) return;

            DataRowView rowView = (DataRowView)dgvInventory.CurrentRow.DataBoundItem;
            DataRow row = rowView.Row;

            Table.Rows.Remove(row);
        }

        private void DoClickSubmit(object? sender, EventArgs e)
        {
            if (cboImportID.SelectedItem == null)
            {
                MessageBox.Show("Please choose an import ID first!", "Batch Submitting", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboImportID.Focus();
                return;
            }
            try
            {
                //Add import id to the table
                foreach (DataRow row in Table.Rows)
                {
                    row[InventoryServices.INV_COL_IMP_ID] = cboImportID.SelectedItem;
                }
                InventoryServices.Submit(Table.TableName).WriteToServer(Table);

                MessageBox.Show("Sucessfully Submitted", "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Table.Rows.Clear();
                InventoryModified?.Invoke(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void DoClickAdd(object? sender, EventArgs e)
        {
            try
            {
                if (IsInventoryValid())
                {
                    nudCurrQty.Value = nudInitQty.Value;

                    Inventory inventory = CreatorEntities.CreateInventory(controls.Skip(2).ToArray());

                    Table.Rows.Add(InventoryServices.AddRow(Table, inventory));

                    bs.ResetBindings(true);
                    
                    Util.ClearControls(controls);

                    MessageBox.Show($"Product Added!", "Creating", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        public static SubInventory GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new SubInventory();
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
                // Bring the existing form to the front if already open6
                instance.BringToFront();
                instance.Activate();
            }
        }
        #endregion


        #region Validation

        private bool IsInventoryValid()
        {
            bool isVilid = true;
            isVilid = Validator.IsValidData(controls.Skip(3).ToArray());
            return isVilid;
        }

        #endregion

        private void ConfigView()
        {
            dgvInventory.Columns[InventoryServices.INV_COL_EXPDATE].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvInventory.Columns[InventoryServices.INV_COL_LAST_UPDATE].DefaultCellStyle.Format = "dd/MM/yyyy";

            dgvInventory.Columns[InventoryServices.INV_COL_ID].Visible = false;
            dgvInventory.Columns[InventoryServices.INV_COL_CURRSTOCK].Visible = false;
            dgvInventory.Columns[InventoryServices.INV_COL_LAST_UPDATE].Visible = false;
            dgvInventory.Columns[InventoryServices.INV_COL_IMP_ID].Visible = false;
            dgvInventory.Columns[InventoryServices.INV_COL_CURRSTOCK].Visible = false;

            dgvInventory.Columns[InventoryServices.INV_COL_ID].HeaderText = "ID";
            dgvInventory.Columns[InventoryServices.INV_COL_ID].Width = 55;
            dgvInventory.Columns[InventoryServices.INV_COL_UNITCOST].Width = 66;
            dgvInventory.Columns[InventoryServices.INV_COL_INITQTY].Width = 82;
            dgvInventory.Columns[InventoryServices.INV_COL_EXPDATE].Width = 105;
            dgvInventory.Columns[InventoryServices.INV_COL_PRO_ID].Width = 82;

            dgvInventory.Columns[InventoryServices.INV_COL_PRO_ID].DisplayIndex = 0;

        }

    }
}
