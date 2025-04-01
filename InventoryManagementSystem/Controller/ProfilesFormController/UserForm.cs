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

        public UserForm()
        {
            InitializeComponent();

            LoadData();
            LoadComboBoxes.LoadHandleByCBO(cboStaff);

            lbAttempt.Visible = false;
            numAttempt.Visible = false;

            txtPassword.Enabled = false;

            cboStaff.SelectedIndex = -1;
            chkLocked.Checked = false;

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

        private void DoClickCheckPassword(object? sender, EventArgs e)
        {
            if (chkPassword.Checked == false)
            {
                txtPassword.Enabled = false;
                return;
            }
            txtPassword.Enabled = true;
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
            lbAttempt.Visible = true;
            numAttempt.Visible = true;
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
                lbAttempt.Visible = false;
                numAttempt.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DoClickClearUser(object? sender, EventArgs e)
        {
            Util.ClearControls(controls);
            lbAttempt.Visible = false;
            numAttempt.Visible = false;
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
                    lbAttempt.Visible = false;
                    numAttempt.Visible = false;
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
                    lbAttempt.Visible = false;
                    numAttempt.Visible = false;
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

        #endregion
        #region method

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
