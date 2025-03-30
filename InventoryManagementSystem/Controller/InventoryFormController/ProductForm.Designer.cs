namespace InventoryManagementSystem.Controller
{
    partial class ProductForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            pHead = new Panel();
            productFormTitle = new Label();
            pBottom = new Panel();
            pBody = new Panel();
            panel3 = new Panel();
            dgvProduct = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colBar = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colSalePrice = new DataGridViewTextBoxColumn();
            colUOM = new DataGridViewTextBoxColumn();
            colTotalStock = new DataGridViewTextBoxColumn();
            colCat = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            listStockMessage = new ListBox();
            panel4 = new Panel();
            label1 = new Label();
            txtSearch = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            panel1 = new Panel();
            pHead.SuspendLayout();
            pBody.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // pHead
            // 
            pHead.Controls.Add(productFormTitle);
            pHead.Dock = DockStyle.Top;
            pHead.Location = new Point(0, 0);
            pHead.Margin = new Padding(3, 2, 3, 2);
            pHead.Name = "pHead";
            pHead.Size = new Size(1698, 80);
            pHead.TabIndex = 0;
            // 
            // productFormTitle
            // 
            productFormTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productFormTitle.AutoSize = true;
            productFormTitle.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productFormTitle.Location = new Point(791, 24);
            productFormTitle.Name = "productFormTitle";
            productFormTitle.Size = new Size(290, 33);
            productFormTitle.TabIndex = 12;
            productFormTitle.Text = "Product's Information";
            // 
            // pBottom
            // 
            pBottom.Dock = DockStyle.Bottom;
            pBottom.Location = new Point(0, 722);
            pBottom.Margin = new Padding(3, 2, 3, 2);
            pBottom.Name = "pBottom";
            pBottom.Size = new Size(1698, 103);
            pBottom.TabIndex = 1;
            // 
            // pBody
            // 
            pBody.Controls.Add(panel3);
            pBody.Controls.Add(panel2);
            pBody.Controls.Add(panel1);
            pBody.Dock = DockStyle.Fill;
            pBody.Location = new Point(0, 80);
            pBody.Name = "pBody";
            pBody.Size = new Size(1698, 642);
            pBody.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvProduct);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(300, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1350, 642);
            panel3.TabIndex = 3;
            // 
            // dgvProduct
            // 
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.AllowUserToDeleteRows = false;
            dgvProduct.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Columns.AddRange(new DataGridViewColumn[] { colId, colBar, colName, colSalePrice, colUOM, colTotalStock, colCat });
            dgvProduct.Dock = DockStyle.Fill;
            dgvProduct.GridColor = SystemColors.Control;
            dgvProduct.Location = new Point(0, 0);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.ReadOnly = true;
            dgvProduct.RowHeadersVisible = false;
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(1350, 642);
            dgvProduct.TabIndex = 0;
            // 
            // colId
            // 
            colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colId.DefaultCellStyle = dataGridViewCellStyle2;
            colId.FillWeight = 120F;
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 45;
            // 
            // colBar
            // 
            colBar.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colBar.DefaultCellStyle = dataGridViewCellStyle3;
            colBar.FillWeight = 80F;
            colBar.HeaderText = "BarCode";
            colBar.MinimumWidth = 6;
            colBar.Name = "colBar";
            colBar.ReadOnly = true;
            // 
            // colName
            // 
            colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colName.DefaultCellStyle = dataGridViewCellStyle4;
            colName.HeaderText = "Name";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colSalePrice
            // 
            colSalePrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            colSalePrice.DefaultCellStyle = dataGridViewCellStyle5;
            colSalePrice.HeaderText = "SalePrice";
            colSalePrice.MinimumWidth = 6;
            colSalePrice.Name = "colSalePrice";
            colSalePrice.ReadOnly = true;
            colSalePrice.Width = 91;
            // 
            // colUOM
            // 
            colUOM.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            colUOM.HeaderText = "Unit Of Measure";
            colUOM.MinimumWidth = 6;
            colUOM.Name = "colUOM";
            colUOM.ReadOnly = true;
            colUOM.Width = 116;
            // 
            // colTotalStock
            // 
            colTotalStock.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            colTotalStock.HeaderText = "Total Stock";
            colTotalStock.MinimumWidth = 6;
            colTotalStock.Name = "colTotalStock";
            colTotalStock.ReadOnly = true;
            colTotalStock.Width = 92;
            // 
            // colCat
            // 
            colCat.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCat.FillWeight = 20F;
            colCat.HeaderText = "Category ID";
            colCat.MinimumWidth = 6;
            colCat.Name = "colCat";
            colCat.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(listStockMessage);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnAdd);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 642);
            panel2.TabIndex = 2;
            // 
            // listStockMessage
            // 
            listStockMessage.Dock = DockStyle.Bottom;
            listStockMessage.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listStockMessage.FormattingEnabled = true;
            listStockMessage.ItemHeight = 20;
            listStockMessage.Location = new Point(0, 478);
            listStockMessage.Margin = new Padding(3, 2, 3, 2);
            listStockMessage.Name = "listStockMessage";
            listStockMessage.SelectionMode = SelectionMode.None;
            listStockMessage.Size = new Size(300, 164);
            listStockMessage.TabIndex = 29;
            // 
            // panel4
            // 
            panel4.Controls.Add(label1);
            panel4.Controls.Add(txtSearch);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 98);
            panel4.TabIndex = 28;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 18);
            label1.Name = "label1";
            label1.Size = new Size(70, 24);
            label1.TabIndex = 26;
            label1.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BackColor = SystemColors.Control;
            txtSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(17, 53);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "search ...";
            txtSearch.Size = new Size(269, 26);
            txtSearch.TabIndex = 27;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.Salmon;
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(82, 365);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 60);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.BackColor = Color.LightYellow;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(82, 252);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 60);
            btnUpdate.TabIndex = 24;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(82, 143);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 60);
            btnAdd.TabIndex = 23;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(1650, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(48, 642);
            panel1.TabIndex = 1;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1698, 825);
            Controls.Add(pBody);
            Controls.Add(pBottom);
            Controls.Add(pHead);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProductForm";
            Text = "ProductForm";
            pHead.ResumeLayout(false);
            pHead.PerformLayout();
            pBody.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pHead;
        private Panel pBottom;
        private Panel pBody;
        private DataGridView dgvProduct;
        private Label productFormTitle;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colBar;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colSalePrice;
        private DataGridViewTextBoxColumn colUOM;
        private DataGridViewTextBoxColumn colTotalStock;
        private DataGridViewTextBoxColumn colCat;
        private Button btnDelete;
        private TextBox txtSearch;
        private Button btnUpdate;
        private Label label1;
        private Button btnAdd;
        private Panel panel4;
        private ListBox listStockMessage;
    }
}