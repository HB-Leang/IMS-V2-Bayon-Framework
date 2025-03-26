namespace InventoryManagementSystem.Controller.InventoryFormController.InventorySubForm
{
    partial class SubInventory
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            SubInventoryFormTitle = new Label();
            panel3 = new Panel();
            btnDelete = new Button();
            btnAdd = new Button();
            btnSubmit = new Button();
            cboImportID = new ComboBox();
            label2 = new Label();
            panel5 = new Panel();
            nudCurrQty = new NumericUpDown();
            txtSubTotal = new TextBox();
            label1 = new Label();
            txtId = new TextBox();
            txtUnitCost = new TextBox();
            rtxtNote = new RichTextBox();
            lbProductId = new Label();
            cboProductId = new ComboBox();
            lbNote = new Label();
            nudInitQty = new NumericUpDown();
            lbInitQty = new Label();
            lbExpireDate = new Label();
            dtExpireDate = new DateTimePicker();
            lbUnitCost = new Label();
            panel4 = new Panel();
            panel6 = new Panel();
            panel2 = new Panel();
            dgvInventory = new DataGridView();
            panel7 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCurrQty).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudInitQty).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(SubInventoryFormTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 59);
            panel1.TabIndex = 0;
            // 
            // SubInventoryFormTitle
            // 
            SubInventoryFormTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SubInventoryFormTitle.AutoSize = true;
            SubInventoryFormTitle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubInventoryFormTitle.Location = new Point(85, 13);
            SubInventoryFormTitle.Name = "SubInventoryFormTitle";
            SubInventoryFormTitle.Size = new Size(218, 31);
            SubInventoryFormTitle.TabIndex = 3;
            SubInventoryFormTitle.Text = "Adding Inventory";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(btnSubmit);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 576);
            panel3.Name = "panel3";
            panel3.Size = new Size(1184, 58);
            panel3.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.Salmon;
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(218, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 44);
            btnDelete.TabIndex = 83;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(86, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(109, 44);
            btnAdd.TabIndex = 82;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.None;
            btnSubmit.BackColor = Color.LightGoldenrodYellow;
            btnSubmit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(360, 6);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(109, 44);
            btnSubmit.TabIndex = 81;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // cboImportID
            // 
            cboImportID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboImportID.BackColor = SystemColors.Control;
            cboImportID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboImportID.FormattingEnabled = true;
            cboImportID.Location = new Point(86, 459);
            cboImportID.MaxDropDownItems = 4;
            cboImportID.Name = "cboImportID";
            cboImportID.Size = new Size(223, 28);
            cboImportID.TabIndex = 84;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(86, 432);
            label2.Name = "label2";
            label2.Size = new Size(242, 20);
            label2.TabIndex = 84;
            label2.Text = "ImportID (Choose before submit)";
            // 
            // panel5
            // 
            panel5.Controls.Add(nudCurrQty);
            panel5.Controls.Add(txtSubTotal);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(cboImportID);
            panel5.Controls.Add(txtId);
            panel5.Controls.Add(txtUnitCost);
            panel5.Controls.Add(rtxtNote);
            panel5.Controls.Add(lbProductId);
            panel5.Controls.Add(cboProductId);
            panel5.Controls.Add(lbNote);
            panel5.Controls.Add(nudInitQty);
            panel5.Controls.Add(lbInitQty);
            panel5.Controls.Add(lbExpireDate);
            panel5.Controls.Add(dtExpireDate);
            panel5.Controls.Add(lbUnitCost);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(666, 517);
            panel5.TabIndex = 1;
            // 
            // nudCurrQty
            // 
            nudCurrQty.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nudCurrQty.BackColor = SystemColors.Control;
            nudCurrQty.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCurrQty.Location = new Point(372, 8);
            nudCurrQty.Name = "nudCurrQty";
            nudCurrQty.Size = new Size(223, 26);
            nudCurrQty.TabIndex = 87;
            nudCurrQty.Visible = false;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSubTotal.Font = new Font("Microsoft Sans Serif", 12F);
            txtSubTotal.Location = new Point(87, 279);
            txtSubTotal.Margin = new Padding(3, 2, 3, 2);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.PlaceholderText = "0.00";
            txtSubTotal.Size = new Size(223, 26);
            txtSubTotal.TabIndex = 86;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(87, 257);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 85;
            label1.Text = "SubTotal";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtId.BackColor = SystemColors.Control;
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(86, 6);
            txtId.Name = "txtId";
            txtId.Size = new Size(224, 29);
            txtId.TabIndex = 81;
            txtId.Visible = false;
            // 
            // txtUnitCost
            // 
            txtUnitCost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUnitCost.Font = new Font("Microsoft Sans Serif", 12F);
            txtUnitCost.Location = new Point(86, 139);
            txtUnitCost.Margin = new Padding(3, 2, 3, 2);
            txtUnitCost.Name = "txtUnitCost";
            txtUnitCost.PlaceholderText = "0.00";
            txtUnitCost.Size = new Size(223, 26);
            txtUnitCost.TabIndex = 75;
            // 
            // rtxtNote
            // 
            rtxtNote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtxtNote.BackColor = SystemColors.Control;
            rtxtNote.BorderStyle = BorderStyle.FixedSingle;
            rtxtNote.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtxtNote.Location = new Point(372, 55);
            rtxtNote.Name = "rtxtNote";
            rtxtNote.Size = new Size(243, 419);
            rtxtNote.TabIndex = 70;
            rtxtNote.Text = "";
            // 
            // lbProductId
            // 
            lbProductId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbProductId.AutoSize = true;
            lbProductId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbProductId.ForeColor = Color.Black;
            lbProductId.Location = new Point(86, 47);
            lbProductId.Name = "lbProductId";
            lbProductId.Size = new Size(82, 20);
            lbProductId.TabIndex = 73;
            lbProductId.Text = "Product Id";
            // 
            // cboProductId
            // 
            cboProductId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboProductId.BackColor = SystemColors.Control;
            cboProductId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboProductId.FormattingEnabled = true;
            cboProductId.Location = new Point(86, 70);
            cboProductId.Name = "cboProductId";
            cboProductId.Size = new Size(223, 28);
            cboProductId.TabIndex = 74;
            // 
            // lbNote
            // 
            lbNote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbNote.AutoSize = true;
            lbNote.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNote.Location = new Point(372, 32);
            lbNote.Name = "lbNote";
            lbNote.Size = new Size(43, 20);
            lbNote.TabIndex = 69;
            lbNote.Text = "Note";
            // 
            // nudInitQty
            // 
            nudInitQty.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nudInitQty.BackColor = SystemColors.Control;
            nudInitQty.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudInitQty.Location = new Point(84, 210);
            nudInitQty.Name = "nudInitQty";
            nudInitQty.Size = new Size(223, 26);
            nudInitQty.TabIndex = 66;
            // 
            // lbInitQty
            // 
            lbInitQty.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbInitQty.AutoSize = true;
            lbInitQty.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbInitQty.ForeColor = Color.Black;
            lbInitQty.Location = new Point(84, 187);
            lbInitQty.Name = "lbInitQty";
            lbInitQty.Size = new Size(74, 20);
            lbInitQty.TabIndex = 65;
            lbInitQty.Text = "Initial Qty";
            // 
            // lbExpireDate
            // 
            lbExpireDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbExpireDate.AutoSize = true;
            lbExpireDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbExpireDate.ForeColor = Color.Black;
            lbExpireDate.Location = new Point(87, 322);
            lbExpireDate.Name = "lbExpireDate";
            lbExpireDate.Size = new Size(92, 20);
            lbExpireDate.TabIndex = 62;
            lbExpireDate.Text = "Expire Date";
            // 
            // dtExpireDate
            // 
            dtExpireDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtExpireDate.CustomFormat = " yyyy/MM/dd";
            dtExpireDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtExpireDate.Format = DateTimePickerFormat.Custom;
            dtExpireDate.Location = new Point(87, 345);
            dtExpireDate.Margin = new Padding(3, 2, 3, 2);
            dtExpireDate.Name = "dtExpireDate";
            dtExpireDate.Size = new Size(223, 26);
            dtExpireDate.TabIndex = 61;
            // 
            // lbUnitCost
            // 
            lbUnitCost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbUnitCost.AutoSize = true;
            lbUnitCost.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUnitCost.ForeColor = Color.Black;
            lbUnitCost.Location = new Point(86, 117);
            lbUnitCost.Name = "lbUnitCost";
            lbUnitCost.Size = new Size(75, 20);
            lbUnitCost.TabIndex = 59;
            lbUnitCost.Text = "Unit Cost";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel4.Location = new Point(0, 59);
            panel4.Name = "panel4";
            panel4.Size = new Size(1184, 517);
            panel4.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(666, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(36, 517);
            panel6.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvInventory);
            panel2.Controls.Add(panel7);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(702, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(482, 517);
            panel2.TabIndex = 2;
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.BackgroundColor = SystemColors.Control;
            dgvInventory.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvInventory.DefaultCellStyle = dataGridViewCellStyle2;
            dgvInventory.Dock = DockStyle.Fill;
            dgvInventory.GridColor = SystemColors.Control;
            dgvInventory.Location = new Point(0, 0);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.RowHeadersWidth = 51;
            dgvInventory.Size = new Size(441, 517);
            dgvInventory.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(441, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(41, 517);
            panel7.TabIndex = 0;
            // 
            // SubInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1184, 634);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "SubInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory Adding";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCurrQty).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudInitQty).EndInit();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel5;
        private RichTextBox rtxtNote;
        private Label lbNote;
        private NumericUpDown nudInitQty;
        private Label lbInitQty;
        private Label lbExpireDate;
        private DateTimePicker dtExpireDate;
        private Label lbUnitCost;
        private Panel panel4;
        private Label lbProductId;
        private ComboBox cboProductId;
        private Panel panel6;
        private Panel panel2;
        private Panel panel7;
        private DataGridView dgvInventory;
        private TextBox txtUnitCost;
        private Label SubInventoryFormTitle;
        private Button btnAdd;
        private Button btnSubmit;
        private TextBox txtId;
        private ComboBox cboImportID;
        private Label label2;
        private Button btnDelete;
        private TextBox txtSubTotal;
        private Label label1;
        private NumericUpDown nudCurrQty;
    }
}