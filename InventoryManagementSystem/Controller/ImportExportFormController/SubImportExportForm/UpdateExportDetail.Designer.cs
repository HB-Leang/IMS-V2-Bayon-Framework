namespace InventoryManagementSystem.Controller.ImportExportFormController.SubImportExportForm
{
    partial class UpdateExportDetail
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
            cboInvID = new ComboBox();
            lbCategoryId = new Label();
            cboExportID = new ComboBox();
            txtUnitPrice = new TextBox();
            lbSubTotal = new Label();
            nudQuantityExport = new NumericUpDown();
            lbUnitPrice = new Label();
            lbQuanityExported = new Label();
            txtId = new TextBox();
            lbProductId = new Label();
            cboProductId = new ComboBox();
            panel4 = new Panel();
            panel6 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantityExport).BeginInit();
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
            panel1.Size = new Size(410, 59);
            panel1.TabIndex = 0;
            // 
            // updateInvFormTitle
            // 
            updateInvFormTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            updateInvFormTitle.AutoSize = true;
            updateInvFormTitle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateInvFormTitle.Location = new Point(80, 12);
            updateInvFormTitle.Name = "updateInvFormTitle";
            updateInvFormTitle.Size = new Size(264, 31);
            updateInvFormTitle.TabIndex = 4;
            updateInvFormTitle.Text = "Update Export Detail";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnSubmit);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 541);
            panel3.Name = "panel3";
            panel3.Size = new Size(410, 120);
            panel3.TabIndex = 2;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.None;
            btnSubmit.BackColor = Color.LightGoldenrodYellow;
            btnSubmit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(248, 32);
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
            panel5.Controls.Add(cboInvID);
            panel5.Controls.Add(lbCategoryId);
            panel5.Controls.Add(cboExportID);
            panel5.Controls.Add(txtUnitPrice);
            panel5.Controls.Add(lbSubTotal);
            panel5.Controls.Add(nudQuantityExport);
            panel5.Controls.Add(lbUnitPrice);
            panel5.Controls.Add(lbQuanityExported);
            panel5.Controls.Add(txtId);
            panel5.Controls.Add(lbProductId);
            panel5.Controls.Add(cboProductId);
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
            txtSubTotal.Location = new Point(28, 293);
            txtSubTotal.Margin = new Padding(3, 2, 3, 2);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.PlaceholderText = "0.00";
            txtSubTotal.Size = new Size(224, 26);
            txtSubTotal.TabIndex = 109;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(27, 338);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 107;
            label2.Text = "Inventory ID";
            // 
            // cboInvID
            // 
            cboInvID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboInvID.BackColor = SystemColors.Control;
            cboInvID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboInvID.FormattingEnabled = true;
            cboInvID.Location = new Point(27, 361);
            cboInvID.Name = "cboInvID";
            cboInvID.Size = new Size(225, 28);
            cboInvID.TabIndex = 108;
            // 
            // lbCategoryId
            // 
            lbCategoryId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbCategoryId.AutoSize = true;
            lbCategoryId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCategoryId.ForeColor = Color.Black;
            lbCategoryId.Location = new Point(27, 408);
            lbCategoryId.Name = "lbCategoryId";
            lbCategoryId.Size = new Size(76, 20);
            lbCategoryId.TabIndex = 105;
            lbCategoryId.Text = "Export ID";
            // 
            // cboExportID
            // 
            cboExportID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboExportID.BackColor = SystemColors.Control;
            cboExportID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboExportID.FormattingEnabled = true;
            cboExportID.Location = new Point(27, 431);
            cboExportID.Name = "cboExportID";
            cboExportID.Size = new Size(225, 28);
            cboExportID.TabIndex = 106;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUnitPrice.Enabled = false;
            txtUnitPrice.Font = new Font("Microsoft Sans Serif", 12F);
            txtUnitPrice.Location = new Point(29, 230);
            txtUnitPrice.Margin = new Padding(3, 2, 3, 2);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.PlaceholderText = "0.00";
            txtUnitPrice.Size = new Size(224, 26);
            txtUnitPrice.TabIndex = 104;
            // 
            // lbSubTotal
            // 
            lbSubTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbSubTotal.AutoSize = true;
            lbSubTotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSubTotal.ForeColor = Color.Black;
            lbSubTotal.Location = new Point(28, 271);
            lbSubTotal.Name = "lbSubTotal";
            lbSubTotal.Size = new Size(77, 20);
            lbSubTotal.TabIndex = 103;
            lbSubTotal.Text = "Sub Total";
            // 
            // nudQuantityExport
            // 
            nudQuantityExport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nudQuantityExport.BackColor = SystemColors.Control;
            nudQuantityExport.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudQuantityExport.Location = new Point(29, 172);
            nudQuantityExport.Name = "nudQuantityExport";
            nudQuantityExport.Size = new Size(224, 26);
            nudQuantityExport.TabIndex = 102;
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUnitPrice.ForeColor = Color.Black;
            lbUnitPrice.Location = new Point(28, 208);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(77, 20);
            lbUnitPrice.TabIndex = 101;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbQuanityExported
            // 
            lbQuanityExported.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbQuanityExported.AutoSize = true;
            lbQuanityExported.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbQuanityExported.ForeColor = Color.Black;
            lbQuanityExported.Location = new Point(29, 149);
            lbQuanityExported.Name = "lbQuanityExported";
            lbQuanityExported.Size = new Size(131, 20);
            lbQuanityExported.TabIndex = 100;
            lbQuanityExported.Text = "Quanity Exported";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtId.BackColor = SystemColors.Control;
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(29, 34);
            txtId.Name = "txtId";
            txtId.Size = new Size(224, 29);
            txtId.TabIndex = 95;
            txtId.Visible = false;
            // 
            // lbProductId
            // 
            lbProductId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbProductId.AutoSize = true;
            lbProductId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbProductId.ForeColor = Color.Black;
            lbProductId.Location = new Point(29, 79);
            lbProductId.Name = "lbProductId";
            lbProductId.Size = new Size(82, 20);
            lbProductId.TabIndex = 92;
            lbProductId.Text = "Product Id";
            // 
            // cboProductId
            // 
            cboProductId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboProductId.BackColor = SystemColors.Control;
            cboProductId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboProductId.FormattingEnabled = true;
            cboProductId.Location = new Point(29, 102);
            cboProductId.Name = "cboProductId";
            cboProductId.Size = new Size(223, 28);
            cboProductId.TabIndex = 93;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel4.Location = new Point(0, 59);
            panel4.Name = "panel4";
            panel4.Size = new Size(410, 482);
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
            // UpdateExportDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(410, 661);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "UpdateExportDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Update ExportDetail";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantityExport).EndInit();
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
        private TextBox txtId;
        private Label lbProductId;
        private ComboBox cboProductId;
        private TextBox txtSubTotal;
        private Label label2;
        private ComboBox cboInvID;
        private Label lbCategoryId;
        private ComboBox cboExportID;
        private TextBox txtUnitPrice;
        private Label lbSubTotal;
        private NumericUpDown nudQuantityExport;
        private Label lbUnitPrice;
        private Label lbQuanityExported;
    }
}