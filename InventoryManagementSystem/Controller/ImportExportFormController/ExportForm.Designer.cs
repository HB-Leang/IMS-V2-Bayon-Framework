namespace InventoryManagementSystem.Controller.ImportExportFormController
{
    partial class ExportForm
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
            exportFormTitle = new Label();
            btnDelete = new Button();
            btnInsert = new Button();
            btnUpdate = new Button();
            pBottom = new Panel();
            pBody = new Panel();
            panel3 = new Panel();
            dgvExport = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colExportDate = new DataGridViewTextBoxColumn();
            colTotalCost = new DataGridViewTextBoxColumn();
            colTotalItem = new DataGridViewTextBoxColumn();
            colHandleBy = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel4 = new Panel();
            txtId = new TextBox();
            panel5 = new Panel();
            panel6 = new Panel();
            btnClear = new Button();
            nudTotalItem = new NumericUpDown();
            lbTotalItem = new Label();
            lbDate = new Label();
            cboHandleBy = new ComboBox();
            lbTotalCost = new Label();
            lbHandleBy = new Label();
            txtTotalCost = new TextBox();
            dtExportDate = new DateTimePicker();
            panel1 = new Panel();
            pHead.SuspendLayout();
            pBody.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExport).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTotalItem).BeginInit();
            SuspendLayout();
            // 
            // pHead
            // 
            pHead.Controls.Add(exportFormTitle);
            pHead.Dock = DockStyle.Top;
            pHead.Location = new Point(0, 0);
            pHead.Margin = new Padding(3, 2, 3, 2);
            pHead.Name = "pHead";
            pHead.Size = new Size(1800, 93);
            pHead.TabIndex = 0;
            // 
            // exportFormTitle
            // 
            exportFormTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            exportFormTitle.AutoSize = true;
            exportFormTitle.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exportFormTitle.Location = new Point(69, 32);
            exportFormTitle.Name = "exportFormTitle";
            exportFormTitle.Size = new Size(274, 33);
            exportFormTitle.TabIndex = 12;
            exportFormTitle.Text = "Export's Information";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Left | AnchorStyles.Right;
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
            btnInsert.Anchor = AnchorStyles.Left | AnchorStyles.Right;
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
            btnUpdate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
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
            panel3.Controls.Add(dgvExport);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(877, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(843, 725);
            panel3.TabIndex = 3;
            // 
            // dgvExport
            // 
            dgvExport.AllowUserToAddRows = false;
            dgvExport.AllowUserToDeleteRows = false;
            dgvExport.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvExport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvExport.ColumnHeadersHeight = 40;
            dgvExport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvExport.Columns.AddRange(new DataGridViewColumn[] { colId, colExportDate, colTotalCost, colTotalItem, colHandleBy });
            dgvExport.Dock = DockStyle.Fill;
            dgvExport.GridColor = SystemColors.Control;
            dgvExport.Location = new Point(0, 0);
            dgvExport.Name = "dgvExport";
            dgvExport.ReadOnly = true;
            dgvExport.RowHeadersVisible = false;
            dgvExport.Size = new Size(843, 725);
            dgvExport.TabIndex = 0;
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
            // colExportDate
            // 
            colExportDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colExportDate.HeaderText = "Export Date";
            colExportDate.Name = "colExportDate";
            colExportDate.ReadOnly = true;
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
            panel4.Controls.Add(nudTotalItem);
            panel4.Controls.Add(lbTotalItem);
            panel4.Controls.Add(lbDate);
            panel4.Controls.Add(cboHandleBy);
            panel4.Controls.Add(lbTotalCost);
            panel4.Controls.Add(lbHandleBy);
            panel4.Controls.Add(txtTotalCost);
            panel4.Controls.Add(dtExportDate);
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
            txtId.TabIndex = 82;
            txtId.Visible = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(btnClear);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 512);
            panel5.Name = "panel5";
            panel5.Size = new Size(562, 213);
            panel5.TabIndex = 57;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(75, 213);
            panel6.TabIndex = 54;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightSkyBlue;
            btnClear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(93, 34);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(120, 60);
            btnClear.TabIndex = 53;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // nudTotalItem
            // 
            nudTotalItem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nudTotalItem.BackColor = SystemColors.Control;
            nudTotalItem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudTotalItem.Location = new Point(93, 234);
            nudTotalItem.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudTotalItem.Name = "nudTotalItem";
            nudTotalItem.Size = new Size(390, 26);
            nudTotalItem.TabIndex = 56;
            // 
            // lbTotalItem
            // 
            lbTotalItem.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbTotalItem.AutoSize = true;
            lbTotalItem.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotalItem.ForeColor = Color.Black;
            lbTotalItem.Location = new Point(93, 211);
            lbTotalItem.Name = "lbTotalItem";
            lbTotalItem.Size = new Size(80, 20);
            lbTotalItem.TabIndex = 54;
            lbTotalItem.Text = "Total Item";
            // 
            // lbDate
            // 
            lbDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDate.ForeColor = Color.Black;
            lbDate.Location = new Point(93, 126);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(44, 20);
            lbDate.TabIndex = 39;
            lbDate.Text = "Date";
            // 
            // cboHandleBy
            // 
            cboHandleBy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboHandleBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHandleBy.Font = new Font("Microsoft Sans Serif", 12F);
            cboHandleBy.FormattingEnabled = true;
            cboHandleBy.Location = new Point(93, 395);
            cboHandleBy.Margin = new Padding(3, 2, 3, 2);
            cboHandleBy.Name = "cboHandleBy";
            cboHandleBy.Size = new Size(390, 28);
            cboHandleBy.TabIndex = 52;
            // 
            // lbTotalCost
            // 
            lbTotalCost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbTotalCost.AutoSize = true;
            lbTotalCost.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTotalCost.ForeColor = Color.Black;
            lbTotalCost.Location = new Point(93, 289);
            lbTotalCost.Name = "lbTotalCost";
            lbTotalCost.Size = new Size(81, 20);
            lbTotalCost.TabIndex = 12;
            lbTotalCost.Text = "Total Cost";
            // 
            // lbHandleBy
            // 
            lbHandleBy.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lbHandleBy.AutoSize = true;
            lbHandleBy.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHandleBy.ForeColor = Color.Black;
            lbHandleBy.Location = new Point(93, 368);
            lbHandleBy.Name = "lbHandleBy";
            lbHandleBy.Size = new Size(82, 20);
            lbHandleBy.TabIndex = 50;
            lbHandleBy.Text = "Handle By";
            // 
            // txtTotalCost
            // 
            txtTotalCost.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtTotalCost.Font = new Font("Microsoft Sans Serif", 12F);
            txtTotalCost.Location = new Point(93, 311);
            txtTotalCost.Margin = new Padding(3, 2, 3, 2);
            txtTotalCost.Name = "txtTotalCost";
            txtTotalCost.PlaceholderText = "0.00";
            txtTotalCost.Size = new Size(390, 26);
            txtTotalCost.TabIndex = 37;
            // 
            // dtExportDate
            // 
            dtExportDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dtExportDate.CustomFormat = " yyyy/MM/dd";
            dtExportDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtExportDate.Format = DateTimePickerFormat.Custom;
            dtExportDate.Location = new Point(93, 148);
            dtExportDate.Margin = new Padding(3, 2, 3, 2);
            dtExportDate.Name = "dtExportDate";
            dtExportDate.Size = new Size(390, 26);
            dtExportDate.TabIndex = 38;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1720, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(80, 725);
            panel1.TabIndex = 1;
            // 
            // ExportForm
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
            Name = "ExportForm";
            Text = "ExportForm";
            pHead.ResumeLayout(false);
            pHead.PerformLayout();
            pBody.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExport).EndInit();
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
        private DataGridView dgvExport;
        private Button btnDelete;
        private Button btnInsert;
        private Button btnUpdate;
        private Label exportFormTitle;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private TextBox txtTotalCost;
        private Label lbTotalCost;
        private ComboBox cboHandleBy;
        private Label lbHandleBy;
        private Label label3;
        private Label lbDate;
        private DateTimePicker dtExportDate;
        private Button btnClear;
        private Panel panel4;
        private Label lbTotalItem;
        private NumericUpDown nudTotalItem;
        private Panel panel5;
        private Panel panel6;
        private TextBox txtId;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colExportDate;
        private DataGridViewTextBoxColumn colTotalCost;
        private DataGridViewTextBoxColumn colTotalItem;
        private DataGridViewTextBoxColumn colHandleBy;
    }
}