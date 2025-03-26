namespace Database_Tools
{
    partial class Databasetools
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

        private void InitializeComponent()
        {
            label6 = new Label();
            btnConnect = new Button();
            txtPassword = new TextBox();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            label11 = new Label();
            txtServerName = new TextBox();
            label3 = new Label();
            txtUserName = new TextBox();
            label2 = new Label();
            label4 = new Label();
            cbAthor = new ComboBox();
            txtDatabaseName = new TextBox();
            label1 = new Label();
            label13 = new Label();
            panel2 = new Panel();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 10.2F);
            label6.Location = new Point(81, 276);
            label6.Name = "label6";
            label6.Size = new Size(66, 16);
            label6.TabIndex = 0;
            label6.Text = "Password:";
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.FromArgb(128, 255, 255);
            btnConnect.Font = new Font("Times New Roman", 10.2F);
            btnConnect.ForeColor = Color.Black;
            btnConnect.Location = new Point(344, 331);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(106, 41);
            btnConnect.TabIndex = 3;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            txtPassword.Enabled = false;
            txtPassword.Font = new Font("Times New Roman", 10.2F);
            txtPassword.Location = new Point(256, 268);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(252, 23);
            txtPassword.TabIndex = 4;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(255, 255, 128);
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Copyright;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 25;
            iconPictureBox1.Location = new Point(141, 47);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(25, 26);
            iconPictureBox1.TabIndex = 7;
            iconPictureBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(172, 52);
            label10.Name = "label10";
            label10.Size = new Size(238, 17);
            label10.TabIndex = 9;
            label10.Text = "Copyright ISAD_M3_25_Group(Roza)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 20F);
            label11.Location = new Point(186, 3);
            label11.Name = "label11";
            label11.Size = new Size(202, 39);
            label11.TabIndex = 9;
            label11.Text = "Ticket's Form";
            // 
            // txtServerName
            // 
            txtServerName.Font = new Font("Times New Roman", 10.2F);
            txtServerName.Location = new Point(256, 94);
            txtServerName.Name = "txtServerName";
            txtServerName.Size = new Size(252, 23);
            txtServerName.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.2F);
            label3.Location = new Point(84, 100);
            label3.Name = "label3";
            label3.Size = new Size(88, 16);
            label3.TabIndex = 12;
            label3.Text = "Server Name :";
            // 
            // txtUserName
            // 
            txtUserName.Enabled = false;
            txtUserName.Font = new Font("Times New Roman", 10.2F);
            txtUserName.Location = new Point(256, 223);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(252, 23);
            txtUserName.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.2F);
            label2.Location = new Point(81, 187);
            label2.Name = "label2";
            label2.Size = new Size(91, 16);
            label2.TabIndex = 26;
            label2.Text = "Authentication:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.2F);
            label4.Location = new Point(81, 231);
            label4.Name = "label4";
            label4.Size = new Size(73, 16);
            label4.TabIndex = 28;
            label4.Text = "UserName :";
            // 
            // cbAthor
            // 
            cbAthor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAthor.Font = new Font("Times New Roman", 10.2F);
            cbAthor.FormattingEnabled = true;
            cbAthor.Items.AddRange(new object[] { "Windows Authentication ", "SQL Server Authentication" });
            cbAthor.Location = new Point(256, 179);
            cbAthor.Name = "cbAthor";
            cbAthor.Size = new Size(252, 24);
            cbAthor.TabIndex = 31;
            // 
            // txtDatabaseName
            // 
            txtDatabaseName.Font = new Font("Times New Roman", 10.2F);
            txtDatabaseName.Location = new Point(256, 136);
            txtDatabaseName.Name = "txtDatabaseName";
            txtDatabaseName.Size = new Size(252, 23);
            txtDatabaseName.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.2F);
            label1.Location = new Point(84, 142);
            label1.Name = "label1";
            label1.Size = new Size(102, 16);
            label1.TabIndex = 32;
            label1.Text = "Database Name :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 20F);
            label13.Location = new Point(170, 21);
            label13.Name = "label13";
            label13.Size = new Size(271, 31);
            label13.TabIndex = 2;
            label13.Text = "Database Configuration";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Ivory;
            panel2.Controls.Add(label13);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(605, 76);
            panel2.TabIndex = 7;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(128, 255, 255);
            btnClose.Font = new Font("Times New Roman", 10.2F);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(487, 331);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(106, 41);
            btnClose.TabIndex = 34;
            btnClose.Text = "Save";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // Databasetools
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(605, 384);
            Controls.Add(btnClose);
            Controls.Add(txtDatabaseName);
            Controls.Add(label1);
            Controls.Add(cbAthor);
            Controls.Add(label4);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(txtServerName);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(txtPassword);
            Controls.Add(btnConnect);
            Controls.Add(label6);
            Font = new Font("Times New Roman", 9F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Databasetools";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DatabaseTool Form";
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label6;
        private Button btnConnect;
        private TextBox txtPassword;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
#pragma warning disable CS0169 // The field 'Ticket.panel1' is never used
#pragma warning restore CS0169 // The field 'Ticket.panel1' is never used
        private Label label10;
        private PictureBox pictureBox1;
        private Label label11;
        private TextBox txtServerName;
        private Label label3;
        private TextBox txtUserName;
        private Label label2;
        private Label label4;
        private ComboBox cbAthor;
        private TextBox txtDatabaseName;
        private Label label1;
        private Label label13;
        private Panel panel2;
        private Button btnClose;
    }
}