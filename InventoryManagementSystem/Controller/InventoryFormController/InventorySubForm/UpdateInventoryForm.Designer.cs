namespace InventoryManagementSystem.Controller.InventoryFormController.InventorySubForm
{
    partial class UpdateInventoryForm
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
            panel1 = new Panel();
            updateInvFormTitle = new Label();
            panel3 = new Panel();
            btnSubmit = new Button();
            panel5 = new Panel();
            txtSubTotal = new TextBox();
            label2 = new Label();
            lbImport = new Label();
            cboImportID = new ComboBox();
            nudCurrStock = new NumericUpDown();
            label1 = new Label();
            txtId = new TextBox();
            txtUnitCost = new TextBox();
            rtxtNote = new RichTextBox();
            lbProductId = new Label();
            cboProduct = new ComboBox();
            lbNote = new Label();
            nudInitQty = new NumericUpDown();
            lbInitQty = new Label();
            lbExpireDate = new Label();
            dtExpireDate = new DateTimePicker();
            lbUnitCost = new Label();
            panel4 = new Panel();
            panel6 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCurrStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudInitQty).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(updateInvFormTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 59);
            panel1.TabIndex = 0;
            // 
            // updateInvFormTitle
            // 
            updateInvFormTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            updateInvFormTitle.AutoSize = true;
            updateInvFormTitle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateInvFormTitle.Location = new Point(80, 12);
            updateInvFormTitle.Name = "updateInvFormTitle";
            updateInvFormTitle.Size = new Size(222, 31);
            updateInvFormTitle.TabIndex = 4;
            updateInvFormTitle.Text = "Update Inventory";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSubmit);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 541);
            panel3.Name = "panel3";
            panel3.Size = new Size(584, 120);
            panel3.TabIndex = 2;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.None;
            btnSubmit.BackColor = Color.LightGoldenrodYellow;
            btnSubmit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(438, 38);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(120, 60);
            btnSubmit.TabIndex = 80;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtSubTotal);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(lbImport);
            panel5.Controls.Add(cboImportID);
            panel5.Controls.Add(nudCurrStock);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(txtId);
            panel5.Controls.Add(txtUnitCost);
            panel5.Controls.Add(rtxtNote);
            panel5.Controls.Add(lbProductId);
            panel5.Controls.Add(cboProduct);
            panel5.Controls.Add(lbNote);
            panel5.Controls.Add(nudInitQty);
            panel5.Controls.Add(lbInitQty);
            panel5.Controls.Add(lbExpireDate);
            panel5.Controls.Add(dtExpireDate);
            panel5.Controls.Add(lbUnitCost);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(595, 482);
            panel5.TabIndex = 1;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSubTotal.Font = new Font("Microsoft Sans Serif", 12F);
            txtSubTotal.Location = new Point(29, 295);
            txtSubTotal.Margin = new Padding(3, 2, 3, 2);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.PlaceholderText = "0.00";
            txtSubTotal.Size = new Size(223, 26);
            txtSubTotal.TabIndex = 101;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(29, 273);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 100;
            label2.Text = "SubTotal";
            // 
            // lbImport
            // 
            lbImport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbImport.AutoSize = true;
            lbImport.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbImport.ForeColor = Color.Black;
            lbImport.Location = new Point(29, 388);
            lbImport.Name = "lbImport";
            lbImport.Size = new Size(76, 20);
            lbImport.TabIndex = 99;
            lbImport.Text = "Import ID";
            // 
            // cboImportID
            // 
            cboImportID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboImportID.BackColor = SystemColors.Control;
            cboImportID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboImportID.FormattingEnabled = true;
            cboImportID.Location = new Point(29, 411);
            cboImportID.MaxDropDownItems = 4;
            cboImportID.Name = "cboImportID";
            cboImportID.Size = new Size(223, 28);
            cboImportID.TabIndex = 98;
            // 
            // nudCurrStock
            // 
            nudCurrStock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nudCurrStock.BackColor = SystemColors.Control;
            nudCurrStock.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCurrStock.Location = new Point(29, 239);
            nudCurrStock.Name = "nudCurrStock";
            nudCurrStock.Size = new Size(223, 26);
            nudCurrStock.TabIndex = 97;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(29, 215);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 96;
            label1.Text = "Current Stock";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtId.BackColor = SystemColors.Control;
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(303, 445);
            txtId.Name = "txtId";
            txtId.Size = new Size(224, 29);
            txtId.TabIndex = 95;
            txtId.Visible = false;
            // 
            // txtUnitCost
            // 
            txtUnitCost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUnitCost.Font = new Font("Microsoft Sans Serif", 12F);
            txtUnitCost.Location = new Point(29, 119);
            txtUnitCost.Margin = new Padding(3, 2, 3, 2);
            txtUnitCost.Name = "txtUnitCost";
            txtUnitCost.PlaceholderText = "0.00";
            txtUnitCost.Size = new Size(223, 26);
            txtUnitCost.TabIndex = 94;
            // 
            // rtxtNote
            // 
            rtxtNote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtxtNote.BackColor = SystemColors.Control;
            rtxtNote.BorderStyle = BorderStyle.FixedSingle;
            rtxtNote.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtxtNote.Location = new Point(303, 50);
            rtxtNote.Name = "rtxtNote";
            rtxtNote.Size = new Size(243, 390);
            rtxtNote.TabIndex = 91;
            rtxtNote.Text = "";
            // 
            // lbProductId
            // 
            lbProductId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbProductId.AutoSize = true;
            lbProductId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbProductId.ForeColor = Color.Black;
            lbProductId.Location = new Point(29, 34);
            lbProductId.Name = "lbProductId";
            lbProductId.Size = new Size(64, 20);
            lbProductId.TabIndex = 92;
            lbProductId.Text = "Product";
            // 
            // cboProduct
            // 
            cboProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboProduct.BackColor = SystemColors.Control;
            cboProduct.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboProduct.FormattingEnabled = true;
            cboProduct.Location = new Point(29, 57);
            cboProduct.Name = "cboProduct";
            cboProduct.Size = new Size(223, 28);
            cboProduct.TabIndex = 93;
            // 
            // lbNote
            // 
            lbNote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbNote.AutoSize = true;
            lbNote.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNote.Location = new Point(303, 27);
            lbNote.Name = "lbNote";
            lbNote.Size = new Size(43, 20);
            lbNote.TabIndex = 90;
            lbNote.Text = "Note";
            // 
            // nudInitQty
            // 
            nudInitQty.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nudInitQty.BackColor = SystemColors.Control;
            nudInitQty.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudInitQty.Location = new Point(29, 176);
            nudInitQty.Name = "nudInitQty";
            nudInitQty.Size = new Size(223, 26);
            nudInitQty.TabIndex = 89;
            // 
            // lbInitQty
            // 
            lbInitQty.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbInitQty.AutoSize = true;
            lbInitQty.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbInitQty.ForeColor = Color.Black;
            lbInitQty.Location = new Point(29, 153);
            lbInitQty.Name = "lbInitQty";
            lbInitQty.Size = new Size(74, 20);
            lbInitQty.TabIndex = 88;
            lbInitQty.Text = "Initial Qty";
            // 
            // lbExpireDate
            // 
            lbExpireDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbExpireDate.AutoSize = true;
            lbExpireDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbExpireDate.ForeColor = Color.Black;
            lbExpireDate.Location = new Point(29, 323);
            lbExpireDate.Name = "lbExpireDate";
            lbExpireDate.Size = new Size(92, 20);
            lbExpireDate.TabIndex = 87;
            lbExpireDate.Text = "Expire Date";
            // 
            // dtExpireDate
            // 
            dtExpireDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtExpireDate.CustomFormat = " yyyy/MM/dd";
            dtExpireDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtExpireDate.Format = DateTimePickerFormat.Custom;
            dtExpireDate.Location = new Point(29, 346);
            dtExpireDate.Margin = new Padding(3, 2, 3, 2);
            dtExpireDate.Name = "dtExpireDate";
            dtExpireDate.Size = new Size(223, 26);
            dtExpireDate.TabIndex = 86;
            // 
            // lbUnitCost
            // 
            lbUnitCost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbUnitCost.AutoSize = true;
            lbUnitCost.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUnitCost.ForeColor = Color.Black;
            lbUnitCost.Location = new Point(29, 97);
            lbUnitCost.Name = "lbUnitCost";
            lbUnitCost.Size = new Size(75, 20);
            lbUnitCost.TabIndex = 85;
            lbUnitCost.Text = "Unit Cost";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel4.Location = new Point(0, 59);
            panel4.Name = "panel4";
            panel4.Size = new Size(584, 482);
            panel4.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(595, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(0, 482);
            panel6.TabIndex = 3;
            // 
            // UpdateInventoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(584, 661);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "UpdateInventoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Update Inventory";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCurrStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudInitQty).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Panel panel6;
        private Label updateInvFormTitle;
        private Button btnSubmit;
        private Label lbImport;
        private ComboBox cboImportID;
        private NumericUpDown nudCurrStock;
        private Label label1;
        private TextBox txtId;
        private TextBox txtUnitCost;
        private RichTextBox rtxtNote;
        private Label lbProductId;
        private ComboBox cboProduct;
        private Label lbNote;
        private NumericUpDown nudInitQty;
        private Label lbInitQty;
        private Label lbExpireDate;
        private DateTimePicker dtExpireDate;
        private Label lbUnitCost;
        private TextBox txtSubTotal;
        private Label label2;
    }
}