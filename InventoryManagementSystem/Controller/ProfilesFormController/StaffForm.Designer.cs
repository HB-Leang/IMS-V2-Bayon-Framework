namespace InventoryManagementSystem.Controller.ProfilesFormController
{
    partial class StaffForm
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
            staffFormTitle = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            panel1 = new Panel();
            txtSearch = new TextBox();
            lbSearch = new Label();
            listStaff = new ListBox();
            panel3 = new Panel();
            txtId = new TextBox();
            mtxtPersonalTel = new MaskedTextBox();
            mtxtWorkTel = new MaskedTextBox();
            chkStoppedWork = new CheckBox();
            panel4 = new Panel();
            txtSalary = new TextBox();
            lbName = new Label();
            txtName = new TextBox();
            lbGender = new Label();
            dtHireDate = new DateTimePicker();
            cboGender = new ComboBox();
            lbHiredDate = new Label();
            lbDob = new Label();
            dtDob = new DateTimePicker();
            lbSalary = new Label();
            lbPosition = new Label();
            cboPosition = new ComboBox();
            lbPhone = new Label();
            lbAddress = new Label();
            txtAddress = new TextBox();
            lbWorkPhone = new Label();
            btnClear = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // staffFormTitle
            // 
            staffFormTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            staffFormTitle.AutoSize = true;
            staffFormTitle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            staffFormTitle.Location = new Point(70, 30);
            staffFormTitle.Name = "staffFormTitle";
            staffFormTitle.Size = new Size(233, 31);
            staffFormTitle.TabIndex = 2;
            staffFormTitle.Text = "Staff's Information";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.Salmon;
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(197, 520);
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
            btnUpdate.Location = new Point(197, 436);
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
            btnInsert.Location = new Point(197, 351);
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
            panel1.Controls.Add(listStaff);
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
            txtSearch.PlaceholderText = "eg. heng kakada";
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
            // listStaff
            // 
            listStaff.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listStaff.BackColor = SystemColors.Control;
            listStaff.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listStaff.FormattingEnabled = true;
            listStaff.ItemHeight = 24;
            listStaff.Location = new Point(21, 191);
            listStaff.Margin = new Padding(3, 2, 3, 2);
            listStaff.Name = "listStaff";
            listStaff.Size = new Size(534, 628);
            listStaff.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtId);
            panel3.Controls.Add(mtxtPersonalTel);
            panel3.Controls.Add(mtxtWorkTel);
            panel3.Controls.Add(chkStoppedWork);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(staffFormTitle);
            panel3.Controls.Add(txtSalary);
            panel3.Controls.Add(lbName);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(lbGender);
            panel3.Controls.Add(dtHireDate);
            panel3.Controls.Add(cboGender);
            panel3.Controls.Add(lbHiredDate);
            panel3.Controls.Add(lbDob);
            panel3.Controls.Add(dtDob);
            panel3.Controls.Add(lbSalary);
            panel3.Controls.Add(lbPosition);
            panel3.Controls.Add(cboPosition);
            panel3.Controls.Add(lbPhone);
            panel3.Controls.Add(lbAddress);
            panel3.Controls.Add(txtAddress);
            panel3.Controls.Add(lbWorkPhone);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(616, 900);
            panel3.TabIndex = 20;
            // 
            // txtId
            // 
            txtId.Location = new Point(114, 113);
            txtId.Name = "txtId";
            txtId.Size = new Size(96, 23);
            txtId.TabIndex = 43;
            txtId.Visible = false;
            // 
            // mtxtPersonalTel
            // 
            mtxtPersonalTel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mtxtPersonalTel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtxtPersonalTel.InsertKeyMode = InsertKeyMode.Insert;
            mtxtPersonalTel.Location = new Point(115, 565);
            mtxtPersonalTel.Margin = new Padding(3, 2, 3, 2);
            mtxtPersonalTel.Mask = "(855) ##-###-####";
            mtxtPersonalTel.Name = "mtxtPersonalTel";
            mtxtPersonalTel.Size = new Size(458, 26);
            mtxtPersonalTel.TabIndex = 42;
            // 
            // mtxtWorkTel
            // 
            mtxtWorkTel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mtxtWorkTel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mtxtWorkTel.Location = new Point(115, 495);
            mtxtWorkTel.Margin = new Padding(3, 2, 3, 2);
            mtxtWorkTel.Mask = "(855) ##-###-####";
            mtxtWorkTel.Name = "mtxtWorkTel";
            mtxtWorkTel.Size = new Size(458, 26);
            mtxtWorkTel.TabIndex = 41;
            // 
            // chkStoppedWork
            // 
            chkStoppedWork.AutoSize = true;
            chkStoppedWork.Location = new Point(115, 747);
            chkStoppedWork.Name = "chkStoppedWork";
            chkStoppedWork.Size = new Size(101, 19);
            chkStoppedWork.TabIndex = 40;
            chkStoppedWork.Text = "Stopped Work";
            chkStoppedWork.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 783);
            panel4.Name = "panel4";
            panel4.Size = new Size(616, 117);
            panel4.TabIndex = 39;
            // 
            // txtSalary
            // 
            txtSalary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSalary.Font = new Font("Microsoft Sans Serif", 12F);
            txtSalary.Location = new Point(114, 702);
            txtSalary.Margin = new Padding(3, 2, 3, 2);
            txtSalary.Name = "txtSalary";
            txtSalary.PlaceholderText = "0.00";
            txtSalary.Size = new Size(459, 26);
            txtSalary.TabIndex = 38;
            // 
            // lbName
            // 
            lbName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbName.AutoSize = true;
            lbName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbName.ForeColor = Color.Black;
            lbName.Location = new Point(114, 149);
            lbName.Name = "lbName";
            lbName.Size = new Size(51, 20);
            lbName.TabIndex = 0;
            lbName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtName.BackColor = SystemColors.Control;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.Location = new Point(114, 175);
            txtName.Name = "txtName";
            txtName.Size = new Size(459, 29);
            txtName.TabIndex = 1;
            // 
            // lbGender
            // 
            lbGender.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbGender.AutoSize = true;
            lbGender.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbGender.ForeColor = Color.Black;
            lbGender.Location = new Point(114, 210);
            lbGender.Name = "lbGender";
            lbGender.Size = new Size(63, 20);
            lbGender.TabIndex = 2;
            lbGender.Text = "Gender";
            // 
            // dtHireDate
            // 
            dtHireDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtHireDate.CalendarFont = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtHireDate.CalendarMonthBackground = SystemColors.Control;
            dtHireDate.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtHireDate.Location = new Point(114, 633);
            dtHireDate.Name = "dtHireDate";
            dtHireDate.Size = new Size(459, 22);
            dtHireDate.TabIndex = 17;
            // 
            // cboGender
            // 
            cboGender.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboGender.BackColor = SystemColors.Control;
            cboGender.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboGender.FormattingEnabled = true;
            cboGender.Location = new Point(114, 233);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(459, 28);
            cboGender.TabIndex = 3;
            // 
            // lbHiredDate
            // 
            lbHiredDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbHiredDate.AutoSize = true;
            lbHiredDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHiredDate.ForeColor = Color.Black;
            lbHiredDate.Location = new Point(114, 610);
            lbHiredDate.Name = "lbHiredDate";
            lbHiredDate.Size = new Size(86, 20);
            lbHiredDate.TabIndex = 16;
            lbHiredDate.Text = "Hired Date";
            // 
            // lbDob
            // 
            lbDob.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbDob.AutoSize = true;
            lbDob.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDob.ForeColor = Color.Black;
            lbDob.Location = new Point(114, 276);
            lbDob.Name = "lbDob";
            lbDob.Size = new Size(102, 20);
            lbDob.TabIndex = 4;
            lbDob.Text = "Date Of Birth";
            // 
            // dtDob
            // 
            dtDob.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtDob.CalendarFont = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtDob.CalendarMonthBackground = SystemColors.Control;
            dtDob.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtDob.Location = new Point(114, 299);
            dtDob.Name = "dtDob";
            dtDob.Size = new Size(459, 22);
            dtDob.TabIndex = 5;
            // 
            // lbSalary
            // 
            lbSalary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbSalary.AutoSize = true;
            lbSalary.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSalary.ForeColor = Color.Black;
            lbSalary.Location = new Point(114, 671);
            lbSalary.Name = "lbSalary";
            lbSalary.Size = new Size(53, 20);
            lbSalary.TabIndex = 14;
            lbSalary.Text = "Salary";
            // 
            // lbPosition
            // 
            lbPosition.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbPosition.AutoSize = true;
            lbPosition.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPosition.ForeColor = Color.Black;
            lbPosition.Location = new Point(114, 342);
            lbPosition.Name = "lbPosition";
            lbPosition.Size = new Size(65, 20);
            lbPosition.TabIndex = 6;
            lbPosition.Text = "Position";
            // 
            // cboPosition
            // 
            cboPosition.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboPosition.BackColor = SystemColors.Control;
            cboPosition.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboPosition.FormattingEnabled = true;
            cboPosition.Location = new Point(114, 365);
            cboPosition.Name = "cboPosition";
            cboPosition.Size = new Size(459, 28);
            cboPosition.TabIndex = 7;
            // 
            // lbPhone
            // 
            lbPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbPhone.AutoSize = true;
            lbPhone.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPhone.ForeColor = Color.Black;
            lbPhone.Location = new Point(114, 541);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(96, 20);
            lbPhone.TabIndex = 12;
            lbPhone.Text = "Personal Tel";
            // 
            // lbAddress
            // 
            lbAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbAddress.AutoSize = true;
            lbAddress.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAddress.ForeColor = Color.Black;
            lbAddress.Location = new Point(114, 406);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(68, 20);
            lbAddress.TabIndex = 8;
            lbAddress.Text = "Address";
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtAddress.BackColor = SystemColors.Control;
            txtAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.Location = new Point(114, 429);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(459, 29);
            txtAddress.TabIndex = 9;
            // 
            // lbWorkPhone
            // 
            lbWorkPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbWorkPhone.AutoSize = true;
            lbWorkPhone.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbWorkPhone.ForeColor = Color.Black;
            lbWorkPhone.Location = new Point(114, 473);
            lbWorkPhone.Name = "lbWorkPhone";
            lbWorkPhone.Size = new Size(71, 20);
            lbWorkPhone.TabIndex = 10;
            lbWorkPhone.Text = "Work Tel";
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.None;
            btnClear.BackColor = Color.LightSkyBlue;
            btnClear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(197, 604);
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
            panel2.Location = new Point(616, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(509, 900);
            panel2.TabIndex = 21;
            // 
            // StaffForm
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
            Name = "StaffForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "StaffForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label staffFormTitle;
        private DateTimePicker dtDob;
        private Label lbDob;
        private ComboBox cboGender;
        private Label lbGender;
        private TextBox txtName;
        private Label lbName;
        private Panel panel1;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtAddress;
        private Label lbAddress;
        private ComboBox cboPosition;
        private Label lbPosition;
        private DateTimePicker dtHireDate;
        private Label lbHiredDate;
        private Label lbSalary;
        private Label lbPhone;
        private Label lbWorkPhone;
        private Panel panel3;
        private ListBox listStaff;
        private TextBox txtSearch;
        private Label lbSearch;
        private Button btnClear;
        private TextBox txtSalary;
        private Panel panel2;
        private Panel panel4;
        private CheckBox chkStoppedWork;
        private MaskedTextBox mtxtPersonalTel;
        private MaskedTextBox mtxtWorkTel;
        private TextBox txtId;
    }
}