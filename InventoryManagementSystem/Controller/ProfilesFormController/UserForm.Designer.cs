namespace InventoryManagementSystem.Controller.ProfilesFormController
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region
        private void InitializeComponent()
        {
            userFormTitle = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            panel1 = new Panel();
            txtSearch = new TextBox();
            lbSearch = new Label();
            listUser = new ListBox();
            panel3 = new Panel();
            lbAttempt = new Label();
            numAttempt = new NumericUpDown();
            chkLocked = new CheckBox();
            txtId = new TextBox();
            lbUserName = new Label();
            txtUserName = new TextBox();
            lbStaffId = new Label();
            cboStaff = new ComboBox();
            lbPassword = new Label();
            txtPassword = new TextBox();
            btnClear = new Button();
            panel2 = new Panel();
            chkPassword = new CheckBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAttempt).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // userFormTitle
            // 
            userFormTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userFormTitle.AutoSize = true;
            userFormTitle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userFormTitle.Location = new Point(70, 30);
            userFormTitle.Name = "userFormTitle";
            userFormTitle.Size = new Size(234, 31);
            userFormTitle.TabIndex = 2;
            userFormTitle.Text = "User's Information";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.Salmon;
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(175, 520);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 60);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.BackColor = Color.LightYellow;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(175, 436);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 60);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            btnInsert.Anchor = AnchorStyles.None;
            btnInsert.BackColor = Color.LightGreen;
            btnInsert.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(175, 351);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(120, 60);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(txtSearch);
            panel1.Controls.Add(lbSearch);
            panel1.Controls.Add(listUser);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1125, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(675, 900);
            panel1.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BackColor = SystemColors.Control;
            txtSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(21, 149);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(393, 26);
            txtSearch.TabIndex = 4;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSearch.Location = new Point(21, 116);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(60, 20);
            lbSearch.TabIndex = 3;
            lbSearch.Text = "Search";
            // 
            // listUser
            // 
            listUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listUser.BackColor = SystemColors.Control;
            listUser.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listUser.FormattingEnabled = true;
            listUser.ItemHeight = 20;
            listUser.Location = new Point(21, 191);
            listUser.Margin = new Padding(3, 2, 3, 2);
            listUser.Name = "listUser";
            listUser.Size = new Size(534, 644);
            listUser.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(chkPassword);
            panel3.Controls.Add(lbAttempt);
            panel3.Controls.Add(numAttempt);
            panel3.Controls.Add(chkLocked);
            panel3.Controls.Add(txtId);
            panel3.Controls.Add(lbUserName);
            panel3.Controls.Add(userFormTitle);
            panel3.Controls.Add(txtUserName);
            panel3.Controls.Add(lbStaffId);
            panel3.Controls.Add(cboStaff);
            panel3.Controls.Add(lbPassword);
            panel3.Controls.Add(txtPassword);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(660, 900);
            panel3.TabIndex = 20;
            // 
            // lbAttempt
            // 
            lbAttempt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbAttempt.AutoSize = true;
            lbAttempt.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAttempt.ForeColor = Color.Black;
            lbAttempt.Location = new Point(118, 523);
            lbAttempt.Name = "lbAttempt";
            lbAttempt.Size = new Size(66, 20);
            lbAttempt.TabIndex = 13;
            lbAttempt.Text = "Attempt";
            // 
            // numAttempt
            // 
            numAttempt.Location = new Point(116, 546);
            numAttempt.Name = "numAttempt";
            numAttempt.Size = new Size(120, 23);
            numAttempt.TabIndex = 12;
            // 
            // chkLocked
            // 
            chkLocked.AutoSize = true;
            chkLocked.Location = new Point(555, 550);
            chkLocked.Name = "chkLocked";
            chkLocked.Size = new Size(64, 19);
            chkLocked.TabIndex = 11;
            chkLocked.Text = "Locked";
            chkLocked.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtId.BackColor = SystemColors.Control;
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(116, 232);
            txtId.Name = "txtId";
            txtId.Size = new Size(503, 29);
            txtId.TabIndex = 10;
            txtId.Visible = false;
            // 
            // lbUserName
            // 
            lbUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUserName.ForeColor = Color.Black;
            lbUserName.Location = new Point(116, 280);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(85, 20);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "UserName";
            // 
            // txtUserName
            // 
            txtUserName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUserName.BackColor = SystemColors.Control;
            txtUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(116, 306);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(503, 29);
            txtUserName.TabIndex = 1;
            // 
            // lbStaffId
            // 
            lbStaffId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbStaffId.AutoSize = true;
            lbStaffId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbStaffId.ForeColor = Color.Black;
            lbStaffId.Location = new Point(116, 447);
            lbStaffId.Name = "lbStaffId";
            lbStaffId.Size = new Size(65, 20);
            lbStaffId.TabIndex = 6;
            lbStaffId.Text = "Staff ID";
            // 
            // cboStaff
            // 
            cboStaff.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboStaff.BackColor = SystemColors.Control;
            cboStaff.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboStaff.FormattingEnabled = true;
            cboStaff.Location = new Point(116, 470);
            cboStaff.Name = "cboStaff";
            cboStaff.Size = new Size(503, 28);
            cboStaff.TabIndex = 7;
            // 
            // lbPassword
            // 
            lbPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPassword.ForeColor = Color.Black;
            lbPassword.Location = new Point(116, 359);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(78, 20);
            lbPassword.TabIndex = 8;
            lbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.BackColor = SystemColors.Control;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(116, 382);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(503, 29);
            txtPassword.TabIndex = 9;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.None;
            btnClear.BackColor = Color.LightSkyBlue;
            btnClear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(175, 604);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 60);
            btnClear.TabIndex = 21;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClear);
            panel2.Controls.Add(btnInsert);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnDelete);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(660, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(465, 900);
            panel2.TabIndex = 21;
            // 
            // chkPassword
            // 
            chkPassword.AutoSize = true;
            chkPassword.Location = new Point(625, 391);
            chkPassword.Name = "chkPassword";
            chkPassword.Size = new Size(15, 14);
            chkPassword.TabIndex = 14;
            chkPassword.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1800, 900);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "User Form";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAttempt).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label userFormTitle;
        private TextBox txtUserName;
        private Label lbUserName;
        private Panel panel1;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtPassword;
        private Label lbPassword;
        private ComboBox cboStaff;
        private Label lbStaffId;
        private Panel panel3;
        private ListBox listUser;
        private TextBox txtSearch;
        private Label lbSearch;
        private Button btnClear;
        private Panel panel2;
        private TextBox txtId;
        private CheckBox chkLocked;
        private NumericUpDown numAttempt;
        private Label lbAttempt;
        private CheckBox chkPassword;
    }
}