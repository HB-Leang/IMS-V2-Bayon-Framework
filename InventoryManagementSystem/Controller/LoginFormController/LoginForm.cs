using IMS_Services.Entities;
using IMS_Services.Services.Implementation;
using InventoryManagementSystem;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSRMS_Project.Forms
{
    public partial class LoginForm : Form
    {
        private Control[] controls;

        private User? user = null;

        public LoginForm()
        {
            InitializeComponent();
            controls = new Control[]
            {
                txtUsername, txtPassword,
            };
            foreach (Control control in controls)
            {
                control.KeyPress += TextBox_KeyPress;
            }
            btnLogin.Click += DoClickLogin;
            chkShwPw.Click += DoClickCheckShow;

            this.ActiveControl = txtUsername;

            MainForm.closeHandler += DoCloseClose;

        }

        #region [Event Handler Function]

        private void DoCloseClose()
        {
            this.Dispose();

        }

        private void DoClickLogin(object? sender, EventArgs e)
        {
            checkLogin();
        }

        private void DoClickCheckShow(object? sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShwPw.Checked ? '\0' : '*';
        }
        
        #endregion

        #region [User Defined Functions]
        private void checkLogin()
        {
            
            try
            {
                if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
                {
                    MessageBox.Show("Missing Username", "Logging", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
                {
                    MessageBox.Show("Missing Password", "Logging", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                user = UserServices.GetUserByUserName(txtUsername.Text.Trim());
                if (user == null)
                {
                    MessageBox.Show("User Not Found !", "Alter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate the password
                if (user.Password != txtPassword.Text.Trim() || user.Username != txtUsername.Text.Trim())
                {
                    MessageBox.Show("Incorrect Password Or UserName", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //MessageBox.Show("Login Successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                (new MainForm()).Show();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void TextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the beep sound on Enter key press
                SelectNextControl((Control)sender!, true, true, true, true);
            }
        }

        #endregion

    }
}
