namespace DatabaseToolVersion2
{
    partial class DatabaseTool
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbTitle = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            cboConnection = new ComboBox();
            lbConnection = new Label();
            lbHost = new Label();
            txtHost = new TextBox();
            txtDbName = new TextBox();
            lbDbName = new Label();
            txtUserName = new TextBox();
            lbUserName = new Label();
            txtPassword = new TextBox();
            lbPassword = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // tbTitle
            // 
            tbTitle.AutoSize = true;
            tbTitle.Font = new Font("JetBrains Mono", 20F);
            tbTitle.Location = new Point(144, 20);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(383, 36);
            tbTitle.TabIndex = 0;
            tbTitle.Text = "Database Tool Version 2";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // cboConnection
            // 
            cboConnection.DropDownStyle = ComboBoxStyle.DropDownList;
            cboConnection.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboConnection.FormattingEnabled = true;
            cboConnection.Location = new Point(194, 101);
            cboConnection.Name = "cboConnection";
            cboConnection.Size = new Size(136, 25);
            cboConnection.TabIndex = 1;
            // 
            // lbConnection
            // 
            lbConnection.AutoSize = true;
            lbConnection.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbConnection.Location = new Point(49, 103);
            lbConnection.Name = "lbConnection";
            lbConnection.Size = new Size(110, 21);
            lbConnection.TabIndex = 2;
            lbConnection.Text = "Connection";
            // 
            // lbHost
            // 
            lbHost.AutoSize = true;
            lbHost.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHost.Location = new Point(49, 161);
            lbHost.Name = "lbHost";
            lbHost.Size = new Size(50, 21);
            lbHost.TabIndex = 3;
            lbHost.Text = "Host";
            // 
            // txtHost
            // 
            txtHost.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHost.Location = new Point(194, 161);
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(296, 25);
            txtHost.TabIndex = 4;
            // 
            // txtDbName
            // 
            txtDbName.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDbName.Location = new Point(194, 217);
            txtDbName.Name = "txtDbName";
            txtDbName.Size = new Size(296, 25);
            txtDbName.TabIndex = 6;
            // 
            // lbDbName
            // 
            lbDbName.AutoSize = true;
            lbDbName.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDbName.Location = new Point(49, 218);
            lbDbName.Name = "lbDbName";
            lbDbName.Size = new Size(140, 21);
            lbDbName.TabIndex = 5;
            lbDbName.Text = "Database Name";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(194, 283);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(296, 25);
            txtUserName.TabIndex = 8;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUserName.Location = new Point(49, 284);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(90, 21);
            lbUserName.TabIndex = 7;
            lbUserName.Text = "UserName";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(194, 339);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(296, 25);
            txtPassword.TabIndex = 10;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPassword.Location = new Point(49, 340);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(90, 21);
            lbPassword.TabIndex = 9;
            lbPassword.Text = "Password";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 255, 192);
            btnSave.Font = new Font("JetBrains Mono", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.Black;
            btnSave.Location = new Point(577, 432);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(106, 41);
            btnSave.TabIndex = 35;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // DatabaseTool
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 485);
            Controls.Add(btnSave);
            Controls.Add(txtPassword);
            Controls.Add(lbPassword);
            Controls.Add(txtUserName);
            Controls.Add(lbUserName);
            Controls.Add(txtDbName);
            Controls.Add(lbDbName);
            Controls.Add(txtHost);
            Controls.Add(lbHost);
            Controls.Add(lbConnection);
            Controls.Add(cboConnection);
            Controls.Add(tbTitle);
            Name = "DatabaseTool";
            Text = "DatabaseTool";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tbTitle;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private ComboBox cboConnection;
        private Label lbConnection;
        private Label lbHost;
        private TextBox txtHost;
        private TextBox txtDbName;
        private Label lbDbName;
        private TextBox txtUserName;
        private Label lbUserName;
        private TextBox txtPassword;
        private Label lbPassword;
        private Button btnSave;
    }
}