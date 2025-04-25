using IMS_Services.Entities;
using IMS_Services.Services.Implementation;
using InventoryManagementSystem.Utils;
using InventoryManagementSystem.Validation;
using Microsoft.IdentityModel.Tokens;

namespace InventoryManagementSystem.Controller.ProfilesFormController
{
    public partial class UserForm : Form
    {

        public static event CountEventHandler? countEventHandler;

        private Control[] controls;

        private string _oldPassword = string.Empty;

        public UserForm()
        {
            InitializeComponent();

            LoadData();
            LoadComboBoxes.LoadHandleByCBO(cboStaff);

            VisibleControl();

            txtPassword.Enabled = true;
            chkPassword.Checked = false;
            chkLocked.Checked = false;
            cboStaff.SelectedIndex = -1;
            
            controls = new Control[] {
                txtId,
                txtUserName,
                txtPassword,
                chkLocked,
                numAttempt,
                cboStaff,
                listUser
            };

            btnInsert.Click += DoClickInsertUser;
            btnUpdate.Click += DoClickUpdateUser;
            btnClear.Click += DoClickClearUser;
            btnDelete.Click += DoClickDeleteUser;
            chkPassword.Click += DoClickCheckPassword;

            listUser.Click += DoClickListUser;
            txtSearch.TextChanged += DoSearchTextChange;
        }

        #region Event

        private void DoSearchTextChange(object? sender, EventArgs e)
        {
            var result = UserServices.GetByName(txtSearch.Text);
            listUser.Items.Clear();
            foreach (var user in result)
            {
                listUser.Items.Add(user.ID + "." + user.Username);
            }
        }

        private void DoClickListUser(object? sender, EventArgs e)
        {
            btnInsert.Enabled = false;
            txtPassword.Enabled = false;
            VisibleControl(true);
            LoadEntities.LoadUserFromListStaff(controls, listUser);
        }

        private void DoClickDeleteUser(object? sender, EventArgs e)
        {
            try
            {
                if (txtId.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("Please Choose User You Want To Delete First ...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show($"Are you sure you want to delete the User member with ID {txtId.Text}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    bool isDeleted = UserServices.Delete(short.Parse(txtId.Text));

                    if (isDeleted)
                    {
                        MessageBox.Show($"User with ID {txtId.Text} has been successfully deleted.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        countEventHandler!.Invoke(this);
                    }
                    else
                    {
                        MessageBox.Show($"No User member found with ID {txtId.Text}.",
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
                VisibleControl();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DoClickClearUser(object? sender, EventArgs e)
        {
            Util.ClearControls(controls);
            VisibleControl();
            txtPassword.Enabled = true;
            btnInsert.Enabled = true;
        }

        private void DoClickUpdateUser(object? sender, EventArgs e)
        {
            try
            {
                if (IsUserValid())
                {
                    User user = CreatorEntities.CreateUser(controls);

                    user.ID = short.Parse(txtId.Text);

                    bool effected = UserServices.Update(user, chkPassword.Checked);

                    if (effected)
                    {
                        MessageBox.Show($"User ID : {txtId.Text} Info Updated!", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Util.ClearControls(controls);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show($"Error Updating Data", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    btnInsert.Enabled = true;
                    VisibleControl();
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

        private void DoClickInsertUser(object? sender, EventArgs e)
        {
            try
            {
                if (IsUserValid())
                {
                    User user = CreatorEntities.CreateUser(controls);

                    UserServices.Add(user);

                    Util.ClearControls(controls);

                    LoadData();

                    MessageBox.Show($"User Added!", "Creating", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VisibleControl();
                    chkPassword.Checked = true;
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

        private void DoClickCheckPassword(object? sender, EventArgs e)
        {
            if (chkPassword.Checked == false)
            {
                txtPassword.Text = _oldPassword;
                txtPassword.Enabled = false;
                return;
            }
            txtPassword.Enabled = true;
            _oldPassword = txtPassword.Text;
            txtPassword.Clear();
        }
        
        #endregion

        #region method
        private void VisibleControl(bool state = false)
        {
            chkPassword.Visible = state;
            lbAttempt.Visible = state;
            numAttempt.Visible = state;
        }
        private void LoadData()
        {
            listUser.Items.Clear();
            var result = UserServices.GetAll();
            foreach (var user in result)
            {
                listUser.Items.Add(user.ID + "." + user.Username);
            }
        }
        #endregion

        #region Validation

        private bool IsUserValid()
        {
            bool isVilid = true;
            isVilid = Validator.IsValidData(controls.Skip(1).ToArray());
            return isVilid;
        }

        #endregion
    }
}
