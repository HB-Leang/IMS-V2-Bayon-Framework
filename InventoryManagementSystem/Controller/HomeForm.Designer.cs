namespace InventoryManagementSystem.Controller
{
    partial class HomeForm
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1 = new Panel();
            lbHomeTitle = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel9 = new Panel();
            totalExport = new Label();
            lbTotalExport = new Label();
            panel8 = new Panel();
            totalImport = new Label();
            lbTotalImport = new Label();
            panel7 = new Panel();
            totalStaff = new Label();
            lbTotalStaff = new Label();
            panel6 = new Panel();
            totalUser = new Label();
            lbTotalUser = new Label();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbHomeTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1800, 116);
            panel1.TabIndex = 0;
            // 
            // lbHomeTitle
            // 
            lbHomeTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbHomeTitle.AutoSize = true;
            lbHomeTitle.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHomeTitle.Location = new Point(652, 45);
            lbHomeTitle.Name = "lbHomeTitle";
            lbHomeTitle.Size = new Size(498, 39);
            lbHomeTitle.TabIndex = 0;
            lbHomeTitle.Text = "Inventory Management System";
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 116);
            panel2.Name = "panel2";
            panel2.Size = new Size(209, 784);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1589, 116);
            panel3.Name = "panel3";
            panel3.Size = new Size(211, 784);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(209, 800);
            panel4.Name = "panel4";
            panel4.Size = new Size(1380, 100);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Fill;
            panel5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel5.Location = new Point(209, 116);
            panel5.Name = "panel5";
            panel5.Size = new Size(1380, 684);
            panel5.TabIndex = 4;
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.None;
            panel9.BackColor = SystemColors.GradientInactiveCaption;
            panel9.Controls.Add(totalExport);
            panel9.Controls.Add(lbTotalExport);
            panel9.Location = new Point(1040, 127);
            panel9.Name = "panel9";
            panel9.Size = new Size(236, 148);
            panel9.TabIndex = 2;
            // 
            // totalExport
            // 
            totalExport.AutoSize = true;
            totalExport.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalExport.Location = new Point(12, 105);
            totalExport.Name = "totalExport";
            totalExport.Size = new Size(63, 33);
            totalExport.TabIndex = 1;
            totalExport.Text = "100";
            // 
            // lbTotalExport
            // 
            lbTotalExport.AutoSize = true;
            lbTotalExport.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotalExport.Location = new Point(12, 12);
            lbTotalExport.Name = "lbTotalExport";
            lbTotalExport.Size = new Size(79, 16);
            lbTotalExport.TabIndex = 0;
            lbTotalExport.Text = "Total Export";
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.None;
            panel8.BackColor = SystemColors.GradientInactiveCaption;
            panel8.Controls.Add(totalImport);
            panel8.Controls.Add(lbTotalImport);
            panel8.Location = new Point(739, 127);
            panel8.Name = "panel8";
            panel8.Size = new Size(236, 148);
            panel8.TabIndex = 2;
            // 
            // totalImport
            // 
            totalImport.AutoSize = true;
            totalImport.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalImport.Location = new Point(12, 105);
            totalImport.Name = "totalImport";
            totalImport.Size = new Size(63, 33);
            totalImport.TabIndex = 1;
            totalImport.Text = "100";
            // 
            // lbTotalImport
            // 
            lbTotalImport.AutoSize = true;
            lbTotalImport.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotalImport.Location = new Point(12, 15);
            lbTotalImport.Name = "lbTotalImport";
            lbTotalImport.Size = new Size(78, 16);
            lbTotalImport.TabIndex = 0;
            lbTotalImport.Text = "Total Import";
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.None;
            panel7.BackColor = SystemColors.GradientInactiveCaption;
            panel7.Controls.Add(totalStaff);
            panel7.Controls.Add(lbTotalStaff);
            panel7.Location = new Point(413, 127);
            panel7.Name = "panel7";
            panel7.Size = new Size(236, 148);
            panel7.TabIndex = 2;
            // 
            // totalStaff
            // 
            totalStaff.AutoSize = true;
            totalStaff.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalStaff.Location = new Point(12, 105);
            totalStaff.Name = "totalStaff";
            totalStaff.Size = new Size(63, 33);
            totalStaff.TabIndex = 1;
            totalStaff.Text = "100";
            // 
            // lbTotalStaff
            // 
            lbTotalStaff.AutoSize = true;
            lbTotalStaff.Location = new Point(12, 12);
            lbTotalStaff.Name = "lbTotalStaff";
            lbTotalStaff.Size = new Size(83, 20);
            lbTotalStaff.TabIndex = 0;
            lbTotalStaff.Text = "Total Staff";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.BackColor = SystemColors.GradientInactiveCaption;
            panel6.Controls.Add(totalUser);
            panel6.Controls.Add(lbTotalUser);
            panel6.Location = new Point(102, 127);
            panel6.Name = "panel6";
            panel6.Size = new Size(236, 148);
            panel6.TabIndex = 0;
            // 
            // totalUser
            // 
            totalUser.AutoSize = true;
            totalUser.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalUser.Location = new Point(12, 105);
            totalUser.Name = "totalUser";
            totalUser.Size = new Size(63, 33);
            totalUser.TabIndex = 1;
            totalUser.Text = "100";
            // 
            // lbTotalUser
            // 
            lbTotalUser.AutoSize = true;
            lbTotalUser.Location = new Point(12, 12);
            lbTotalUser.Name = "lbTotalUser";
            lbTotalUser.Size = new Size(82, 20);
            lbTotalUser.TabIndex = 0;
            lbTotalUser.Text = "Total User";
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1800, 900);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormHome";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label lbHomeTitle;
        private Panel panel9;
        private Label totalExport;
        private Label lbTotalExport;
        private Panel panel8;
        private Label totalImport;
        private Label lbTotalImport;
        private Panel panel7;
        private Label totalStaff;
        private Label lbTotalStaff;
        private Panel panel6;
        private Label totalUser;
        private Label lbTotalUser;
    }
}