namespace SSRMS_Project.Forms
{
    partial class LoginForm
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
            txtPassword = new TextBox();
            label4 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnLogin = new Button();
            chkShwPw = new CheckBox();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Times New Roman", 12F);
            txtPassword.Location = new Point(143, 150);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(214, 26);
            txtPassword.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label4.Location = new Point(52, 152);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 11;
            label4.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Times New Roman", 12F);
            txtUsername.Location = new Point(143, 103);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(214, 26);
            txtUsername.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            label2.Location = new Point(52, 104);
            label2.Name = "label2";
            label2.Size = new Size(77, 19);
            label2.TabIndex = 9;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold);
            label1.Location = new Point(141, 16);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 13;
            label1.Text = "User Login";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            btnLogin.Location = new Point(149, 275);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(110, 32);
            btnLogin.TabIndex = 14;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // chkShwPw
            // 
            chkShwPw.AutoSize = true;
            chkShwPw.Font = new Font("Times New Roman", 10.2F);
            chkShwPw.Location = new Point(143, 185);
            chkShwPw.Margin = new Padding(3, 2, 3, 2);
            chkShwPw.Name = "chkShwPw";
            chkShwPw.Size = new Size(116, 20);
            chkShwPw.TabIndex = 15;
            chkShwPw.Text = "show password";
            chkShwPw.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 338);
            Controls.Add(chkShwPw);
            Controls.Add(btnLogin);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Label label4;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
        private Button btnLogin;
        private CheckBox chkShwPw;
    }
}