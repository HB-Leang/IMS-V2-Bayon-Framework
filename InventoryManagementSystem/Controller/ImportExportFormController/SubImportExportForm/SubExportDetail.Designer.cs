namespace InventoryManagementSystem.Controller.ImportExportFormController.SubImportExportForm
{
    partial class SubExportDetail
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
            panel1 = new Panel();
            subExportDetailFormTitle = new Label();
            panel3 = new Panel();
            btnDelete = new Button();
            btnAdd = new Button();
            btnSubmit = new Button();
            panel5 = new Panel();
            txtSubTotal = new TextBox();
            label1 = new Label();
            cboInvID = new ComboBox();
            lbCategoryId = new Label();
            cboExportID = new ComboBox();
            txtUnitPrice = new TextBox();
            lbProductId = new Label();
            cboProductId = new ComboBox();
            lbSubTotal = new Label();
            nudQuantityExport = new NumericUpDown();
            lbUnitPrice = new Label();
            lbQuanityExported = new Label();
            panel4 = new Panel();
            panel6 = new Panel();
            panel2 = new Panel();
            dgvExportDetail = new DataGridView();
            panel7 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantityExport).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExportDetail).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(subExportDetailFormTitle);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1184, 59);
            panel1.TabIndex = 0;
            // 
            // subExportDetailFormTitle
            // 
            subExportDetailFormTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            subExportDetailFormTitle.AutoSize = true;
            subExportDetailFormTitle.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subExportDetailFormTitle.Location = new Point(85, 13);
            subExportDetailFormTitle.Name = "subExportDetailFormTitle";
            subExportDetailFormTitle.Size = new Size(360, 31);
            subExportDetailFormTitle.TabIndex = 3;
            subExportDetailFormTitle.Text = "Add && Update Export History";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(btnSubmit);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 603);
            panel3.Name = "panel3";
            panel3.Size = new Size(1184, 58);
            panel3.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.Salmon;
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(234, 6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 44);
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
            btnSubmit.Location = new Point(364, 6);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(109, 44);
            btnSubmit.TabIndex = 81;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtSubTotal);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(cboInvID);
            panel5.Controls.Add(lbCategoryId);
            panel5.Controls.Add(cboExportID);
            panel5.Controls.Add(txtUnitPrice);
            panel5.Controls.Add(lbProductId);
            panel5.Controls.Add(cboProductId);
            panel5.Controls.Add(lbSubTotal);
            panel5.Controls.Add(nudQuantityExport);
            panel5.Controls.Add(lbUnitPrice);
            panel5.Controls.Add(lbQuanityExported);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(463, 544);
            panel5.TabIndex = 1;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSubTotal.Font = new Font("Microsoft Sans Serif", 12F);
            txtSubTotal.Location = new Point(51, 295);
            txtSubTotal.Margin = new Padding(3, 2, 3, 2);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.PlaceholderText = "0.00";
            txtSubTotal.Size = new Size(330, 26);
            txtSubTotal.TabIndex = 80;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(50, 340);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 78;
            label1.Text = "Inventory ID";
            // 
            // cboInvID
            // 
            cboInvID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboInvID.BackColor = SystemColors.Control;
            cboInvID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboInvID.FormattingEnabled = true;
            cboInvID.Location = new Point(50, 363);
            cboInvID.Name = "cboInvID";
            cboInvID.Size = new Size(331, 28);
            cboInvID.TabIndex = 79;
            // 
            // lbCategoryId
            // 
            lbCategoryId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbCategoryId.AutoSize = true;
            lbCategoryId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCategoryId.ForeColor = Color.Black;
            lbCategoryId.Location = new Point(52, 458);
            lbCategoryId.Name = "lbCategoryId";
            lbCategoryId.Size = new Size(76, 20);
            lbCategoryId.TabIndex = 76;
            lbCategoryId.Text = "Export ID";
            // 
            // cboExportID
            // 
            cboExportID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboExportID.BackColor = SystemColors.Control;
            cboExportID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboExportID.FormattingEnabled = true;
            cboExportID.Location = new Point(52, 481);
            cboExportID.Name = "cboExportID";
            cboExportID.Size = new Size(331, 28);
            cboExportID.TabIndex = 77;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUnitPrice.Enabled = false;
            txtUnitPrice.Font = new Font("Microsoft Sans Serif", 12F);
            txtUnitPrice.Location = new Point(52, 232);
            txtUnitPrice.Margin = new Padding(3, 2, 3, 2);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.PlaceholderText = "0.00";
            txtUnitPrice.Size = new Size(330, 26);
            txtUnitPrice.TabIndex = 75;
            // 
            // lbProductId
            // 
            lbProductId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbProductId.AutoSize = true;
            lbProductId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbProductId.ForeColor = Color.Black;
            lbProductId.Location = new Point(50, 87);
            lbProductId.Name = "lbProductId";
            lbProductId.Size = new Size(64, 20);
            lbProductId.TabIndex = 73;
            lbProductId.Text = "Product";
            // 
            // cboProductId
            // 
            cboProductId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboProductId.BackColor = SystemColors.Control;
            cboProductId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboProductId.FormattingEnabled = true;
            cboProductId.Location = new Point(50, 110);
            cboProductId.Name = "cboProductId";
            cboProductId.Size = new Size(331, 28);
            cboProductId.TabIndex = 74;
            // 
            // lbSubTotal
            // 
            lbSubTotal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbSubTotal.AutoSize = true;
            lbSubTotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSubTotal.ForeColor = Color.Black;
            lbSubTotal.Location = new Point(51, 273);
            lbSubTotal.Name = "lbSubTotal";
            lbSubTotal.Size = new Size(77, 20);
            lbSubTotal.TabIndex = 65;
            lbSubTotal.Text = "Sub Total";
            // 
            // nudQuantityExport
            // 
            nudQuantityExport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nudQuantityExport.BackColor = SystemColors.Control;
            nudQuantityExport.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudQuantityExport.Location = new Point(52, 174);
            nudQuantityExport.Name = "nudQuantityExport";
            nudQuantityExport.Size = new Size(330, 26);
            nudQuantityExport.TabIndex = 64;
            // 
            // lbUnitPrice
            // 
            lbUnitPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbUnitPrice.AutoSize = true;
            lbUnitPrice.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUnitPrice.ForeColor = Color.Black;
            lbUnitPrice.Location = new Point(51, 210);
            lbUnitPrice.Name = "lbUnitPrice";
            lbUnitPrice.Size = new Size(77, 20);
            lbUnitPrice.TabIndex = 63;
            lbUnitPrice.Text = "Unit Price";
            // 
            // lbQuanityExported
            // 
            lbQuanityExported.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbQuanityExported.AutoSize = true;
            lbQuanityExported.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbQuanityExported.ForeColor = Color.Black;
            lbQuanityExported.Location = new Point(52, 151);
            lbQuanityExported.Name = "lbQuanityExported";
            lbQuanityExported.Size = new Size(131, 20);
            lbQuanityExported.TabIndex = 59;
            lbQuanityExported.Text = "Quanity Exported";
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
            panel4.Size = new Size(1184, 544);
            panel4.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(463, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(0, 544);
            panel6.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvExportDetail);
            panel2.Controls.Add(panel7);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(463, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(721, 544);
            panel2.TabIndex = 2;
            // 
            // dgvExportDetail
            // 
            dgvExportDetail.AllowUserToAddRows = false;
            dgvExportDetail.AllowUserToDeleteRows = false;
            dgvExportDetail.BackgroundColor = SystemColors.Control;
            dgvExportDetail.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvExportDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvExportDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExportDetail.Dock = DockStyle.Fill;
            dgvExportDetail.GridColor = SystemColors.Control;
            dgvExportDetail.Location = new Point(0, 0);
            dgvExportDetail.Name = "dgvExportDetail";
            dgvExportDetail.ReadOnly = true;
            dgvExportDetail.RowHeadersVisible = false;
            dgvExportDetail.Size = new Size(707, 544);
            dgvExportDetail.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Right;
            panel7.Location = new Point(707, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(14, 544);
            panel7.TabIndex = 0;
            // 
            // SubExportDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1184, 661);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "SubExportDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Export Detail Adding & Updating";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudQuantityExport).EndInit();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExportDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel5;
        private Label lbSubTotal;
        private NumericUpDown nudQuantityExport;
        private Label lbUnitPrice;
        private Label lbQuanityExported;
        private Panel panel4;
        private Label lbProductId;
        private ComboBox cboProductId;
        private Panel panel6;
        private Panel panel2;
        private Panel panel7;
        private TextBox txtUnitPrice;
        private Label subExportDetailFormTitle;
        private Button btnAdd;
        private Button btnSubmit;
        private DataGridView dgvExportDetail;
        private Label lbCategoryId;
        private ComboBox cboExportID;
        private Label label1;
        private ComboBox cboInvID;
        private TextBox txtSubTotal;
        private Button btnDelete;
    }
}