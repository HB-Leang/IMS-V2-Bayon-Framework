namespace InventoryManagementSystem.Controller.InventoryFormController
{
    partial class InventoryForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pHead = new Panel();
            inventoryFormTitle = new Label();
            pBottom = new Panel();
            pBody = new Panel();
            panel3 = new Panel();
            dgvInventory = new DataGridView();
            panel2 = new Panel();
            panel4 = new Panel();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            panel1 = new Panel();
            pHead.SuspendLayout();
            pBody.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pHead
            // 
            pHead.Controls.Add(inventoryFormTitle);
            pHead.Dock = DockStyle.Top;
            pHead.Location = new Point(0, 0);
            pHead.Margin = new Padding(3, 2, 3, 2);
            pHead.Name = "pHead";
            pHead.Size = new Size(1698, 80);
            pHead.TabIndex = 0;
            // 
            // inventoryFormTitle
            // 
            inventoryFormTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inventoryFormTitle.AutoSize = true;
            inventoryFormTitle.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inventoryFormTitle.Location = new Point(773, 23);
            inventoryFormTitle.Name = "inventoryFormTitle";
            inventoryFormTitle.Size = new Size(310, 33);
            inventoryFormTitle.TabIndex = 12;
            inventoryFormTitle.Text = "Inventory's Information";
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
            panel3.Controls.Add(dgvInventory);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(300, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1350, 642);
            panel3.TabIndex = 3;
            // 
            // dgvInventory
            // 
            dgvInventory.AllowUserToAddRows = false;
            dgvInventory.AllowUserToDeleteRows = false;
            dgvInventory.BackgroundColor = SystemColors.Control;
            dgvInventory.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 192, 0);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Dock = DockStyle.Fill;
            dgvInventory.GridColor = SystemColors.Control;
            dgvInventory.Location = new Point(0, 0);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.ReadOnly = true;
            dgvInventory.RowHeadersVisible = false;
            dgvInventory.RowHeadersWidth = 51;
            dgvInventory.Size = new Size(1350, 642);
            dgvInventory.TabIndex = 0;
            // 
            // panel2
            // 
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
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 100);
            panel4.TabIndex = 23;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = Color.Salmon;
            btnDelete.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(89, 397);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 60);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.BackColor = Color.LightYellow;
            btnUpdate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(89, 283);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(120, 60);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackColor = Color.LightGreen;
            btnAdd.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(89, 173);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(120, 60);
            btnAdd.TabIndex = 18;
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
            // InventoryForm
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
            Name = "InventoryForm";
            Text = "InventoryForm";
            pHead.ResumeLayout(false);
            pHead.PerformLayout();
            pBody.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pHead;
        private Panel pBottom;
        private Panel pBody;
        private DataGridView dgvInventory;
        private Label inventoryFormTitle;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Panel panel4;
    }
}