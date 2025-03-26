namespace InventoryManagementSystem.Controller.ImportExportFormController
{
    partial class ImportForm
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
            pHead = new Panel();
            importFormTitle = new Label();
            btnDelete = new Button();
            btnInsert = new Button();
            btnUpdate = new Button();
            pBottom = new Panel();
            pBody = new Panel();
            panel3 = new Panel();
            dgvImport = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colImportDate = new DataGridViewTextBoxColumn();
            colTotalCost = new DataGridViewTextBoxColumn();
            colTotalItem = new DataGridViewTextBoxColumn();
            colHandleBy = new DataGridViewTextBoxColumn();
            colSupplierId = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel4 = new Panel();
            txtId = new TextBox();
            panel5 = new Panel();
            btnClear = new Button();
            cboHandleBy = new ComboBox();
            lbSupplierId = new Label();
            nudTotalItem = new NumericUpDown();
            lbTotalItem = new Label();
            lbDate = new Label();
            lbTotalCost = new Label();
            cboSupplier = new ComboBox();
            txtTotalCost = new TextBox();
            lbHandleBy = new Label();
            dtImportDate = new DateTimePicker();
            panel1 = new Panel();
            pHead.SuspendLayout();
            pBody.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvImport).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTotalItem).BeginInit();
            SuspendLayout();
            // 
            // pHead
            // 
            pHead.Controls.Add(importFormTitle);
            pHead.Dock = DockStyle.Top;
            pHead.Location = new Point(0, 0);
            pHead.Margin = new Padding(3, 2, 3, 2);
            pHead.Name = "pHead";
            pHead.Size = new Size(1800, 93);
            pHead.TabIndex = 0;
            // 
            // importFormTitle
            // 
            importFormTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            importFormTitle.AutoSize = true;
            importFormTitle.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            importFormTitle.Location = new Point(70, 30);
            importFormTitle.Name = "importFormTitle";
            importFormTitle.Size = new Size(273, 33);
            importFormTitle.TabIndex = 12;
            importFormTitle.Text = "Import's Information";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Left;
            btnDelete.BackColor = Color.Salmon;
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(659, 401);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 60);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnInsert
            // 
            btnInsert.Anchor = AnchorStyles.Left;
            btnInsert.BackColor = Color.LightGreen;
            btnInsert.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInsert.Location = new Point(659, 215);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(120, 60);
            btnInsert.TabIndex = 7;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Left;
            btnUpdate.BackColor = Color.LightYellow;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(659, 304);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 60);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // pBottom
            // 
            pBottom.Dock = DockStyle.Bottom;
            pBottom.Location = new Point(0, 818);
            pBottom.Margin = new Padding(3, 2, 3, 2);
            pBottom.Name = "pBottom";
            pBottom.Size = new Size(1800, 82);
            pBottom.TabIndex = 1;
            // 
            // pBody
            // 
            pBody.Controls.Add(panel3);
            pBody.Controls.Add(panel2);
            pBody.Controls.Add(panel1);
            pBody.Dock = DockStyle.Fill;
            pBody.Location = new Point(0, 93);
            pBody.Name = "pBody";
            pBody.Size = new Size(1800, 725);
            pBody.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvImport);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(877, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(843, 725);
            panel3.TabIndex = 3;
            // 
            // dgvImport
            // 
            dgvImport.AllowUserToAddRows = false;
            dgvImport.AllowUserToDeleteRows = false;
            dgvImport.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvImport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvImport.ColumnHeadersHeight = 40;
            dgvImport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvImport.Columns.AddRange(new DataGridViewColumn[] { colId, colImportDate, colTotalCost, colTotalItem, colHandleBy, colSupplierId });
            dgvImport.Dock = DockStyle.Fill;
            dgvImport.GridColor = SystemColors.Control;
            dgvImport.Location = new Point(0, 0);
            dgvImport.MultiSelect = false;
            dgvImport.Name = "dgvImport";
            dgvImport.ReadOnly = true;
            dgvImport.RowHeadersVisible = false;
            dgvImport.Size = new Size(843, 725);
            dgvImport.TabIndex = 0;
            // 
            // colId
            // 
            colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colId.DefaultCellStyle = dataGridViewCellStyle2;
            colId.FillWeight = 120F;
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 45;
            // 
            // colImportDate
            // 
            colImportDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colImportDate.HeaderText = "Import Date";
            colImportDate.Name = "colImportDate";
            colImportDate.ReadOnly = true;
            // 
            // colTotalCost
            // 
            colTotalCost.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTotalCost.HeaderText = "Total Cost";
            colTotalCost.Name = "colTotalCost";
            colTotalCost.ReadOnly = true;
            // 
            // colTotalItem
            // 
            colTotalItem.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTotalItem.HeaderText = "Total Item";
            colTotalItem.Name = "colTotalItem";
            colTotalItem.ReadOnly = true;
            // 
            // colHandleBy
            // 
            colHandleBy.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colHandleBy.HeaderText = "Handle By";
            colHandleBy.Name = "colHandleBy";
            colHandleBy.ReadOnly = true;
            // 
            // colSupplierId
            // 
            colSupplierId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colSupplierId.HeaderText = "Supplier ID";
            colSupplierId.Name = "colSupplierId";
            colSupplierId.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnInsert);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(877, 725);
            panel2.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtId);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(cboHandleBy);
            panel4.Controls.Add(lbSupplierId);
            panel4.Controls.Add(nudTotalItem);
            panel4.Controls.Add(lbTotalItem);
            panel4.Controls.Add(lbDate);
            panel4.Controls.Add(lbTotalCost);
            panel4.Controls.Add(cboSupplier);
            panel4.Controls.Add(txtTotalCost);
            panel4.Controls.Add(lbHandleBy);
            panel4.Controls.Add(dtImportDate);
            panel4.Dock = DockStyle.Left;
            panel4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(562, 725);
            panel4.TabIndex = 54;
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtId.BackColor = SystemColors.Control;
            txtId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(93, 79);
            txtId.Name = "txtId";
            txtId.Size = new Size(390, 29);
            txtId.TabIndex = 81;
            txtId.Visible = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnClear);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 526);
            panel5.Name = "panel5";
            panel5.Size = new Size(562, 199);
            panel5.TabIndex = 61;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.None;
            btnClear.BackColor = Color.LightSkyBlue;
            btnClear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(93, 22);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 60);
            btnClear.TabIndex = 53;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // cboHandleBy
            // 
            cboHandleBy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboHandleBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHandleBy.Font = new Font("Microsoft Sans Serif", 12F);
            cboHandleBy.FormattingEnabled = true;
            cboHandleBy.Location = new Point(93, 358);
            cboHandleBy.Margin = new Padding(3, 2, 3, 2);
            cboHandleBy.Name = "cboHandleBy";
            cboHandleBy.Size = new Size(390, 28);
            cboHandleBy.TabIndex = 60;
            // 
            // lbSupplierId
            // 
            lbSupplierId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbSupplierId.AutoSize = true;
            lbSupplierId.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSupplierId.ForeColor = Color.Black;
            lbSupplierId.Location = new Point(93, 396);
            lbSupplierId.Name = "lbSupplierId";
            lbSupplierId.Size = new Size(88, 20);
            lbSupplierId.TabIndex = 59;
            lbSupplierId.Text = "Supplier ID";
            // 
            // nudTotalItem
            // 
            nudTotalItem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nudTotalItem.BackColor = SystemColors.Control;
            nudTotalItem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudTotalItem.Location = new Point(93, 295);
            nudTotalItem.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudTotalItem.Name = "nudTotalItem";
            nudTotalItem.Size = new Size(390, 26);
            nudTotalItem.TabIndex = 58;
            // 
            // lbTotalItem
            // 
            lbTotalItem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbTotalItem.AutoSize = true;
            lbTotalItem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotalItem.ForeColor = Color.Black;
            lbTotalItem.Location = new Point(93, 272);
            lbTotalItem.Name = "lbTotalItem";
            lbTotalItem.Size = new Size(80, 20);
            lbTotalItem.TabIndex = 57;
            lbTotalItem.Text = "Total Item";
            // 
            // lbDate
            // 
            lbDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDate.ForeColor = Color.Black;
            lbDate.Location = new Point(93, 122);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(44, 20);
            lbDate.TabIndex = 39;
            lbDate.Text = "Date";
            // 
            // lbTotalCost
            // 
            lbTotalCost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbTotalCost.AutoSize = true;
            lbTotalCost.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotalCost.ForeColor = Color.Black;
            lbTotalCost.Location = new Point(93, 193);
            lbTotalCost.Name = "lbTotalCost";
            lbTotalCost.Size = new Size(81, 20);
            lbTotalCost.TabIndex = 10;
            lbTotalCost.Text = "Total Cost";
            // 
            // cboSupplier
            // 
            cboSupplier.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSupplier.Font = new Font("Microsoft Sans Serif", 12F);
            cboSupplier.FormattingEnabled = true;
            cboSupplier.Location = new Point(93, 423);
            cboSupplier.Margin = new Padding(3, 2, 3, 2);
            cboSupplier.Name = "cboSupplier";
            cboSupplier.Size = new Size(390, 28);
            cboSupplier.TabIndex = 52;
            // 
            // txtTotalCost
            // 
            txtTotalCost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTotalCost.Font = new Font("Microsoft Sans Serif", 12F);
            txtTotalCost.Location = new Point(93, 215);
            txtTotalCost.Margin = new Padding(3, 2, 3, 2);
            txtTotalCost.Name = "txtTotalCost";
            txtTotalCost.PlaceholderText = "0.00";
            txtTotalCost.Size = new Size(390, 26);
            txtTotalCost.TabIndex = 36;
            // 
            // lbHandleBy
            // 
            lbHandleBy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbHandleBy.AutoSize = true;
            lbHandleBy.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHandleBy.ForeColor = Color.Black;
            lbHandleBy.Location = new Point(93, 334);
            lbHandleBy.Name = "lbHandleBy";
            lbHandleBy.Size = new Size(82, 20);
            lbHandleBy.TabIndex = 48;
            lbHandleBy.Text = "Handle By";
            // 
            // dtImportDate
            // 
            dtImportDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtImportDate.CustomFormat = " yyyy/MM/dd";
            dtImportDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtImportDate.Format = DateTimePickerFormat.Custom;
            dtImportDate.Location = new Point(93, 144);
            dtImportDate.Margin = new Padding(3, 2, 3, 2);
            dtImportDate.Name = "dtImportDate";
            dtImportDate.Size = new Size(390, 26);
            dtImportDate.TabIndex = 38;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1720, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(80, 725);
            panel1.TabIndex = 1;
            // 
            // ImportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1800, 900);
            Controls.Add(pBody);
            Controls.Add(pBottom);
            Controls.Add(pHead);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ImportForm";
            Text = "ImportForm";
            pHead.ResumeLayout(false);
            pHead.PerformLayout();
            pBody.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvImport).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudTotalItem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pHead;
        private Panel pBottom;
        private Panel pBody;
        private DataGridView dgvImport;
        private Button btnDelete;
        private Button btnInsert;
        private Button btnUpdate;
        private Label importFormTitle;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colImportDate;
        private DataGridViewTextBoxColumn colTotalCost;
        private DataGridViewTextBoxColumn colTotalItem;
        private DataGridViewTextBoxColumn colHandleBy;
        private DataGridViewTextBoxColumn colSupplierId;
        private Label lbTotalCost;
        private TextBox textBox1;
        private TextBox txtTotalCost;
        private Label label1;
        private ComboBox cboSupplier;
        private Label label4;
        private Label lbHandleBy;
        private Label lbDate;
        private DateTimePicker dtImportDate;
        private Button btnClear;
        private Panel panel4;
        private NumericUpDown nudTotalItem;
        private Label lbTotalItem;
        private Label lbSupplierId;
        private ComboBox cboHandleBy;
        private Panel panel5;
        private TextBox txtId;
    }
}