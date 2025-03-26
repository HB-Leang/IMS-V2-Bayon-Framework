namespace InventoryManagementSystem
{
    partial class MainForm
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabform = new TabControl();
            menubar = new MenuStrip();
            homeMenuItemBar = new ToolStripMenuItem();
            inventoryMenuItemBar = new ToolStripMenuItem();
            categoryMenuItem = new ToolStripMenuItem();
            productMenuItem = new ToolStripMenuItem();
            inventoryMenuItem = new ToolStripMenuItem();
            importExportMenuItemBar = new ToolStripMenuItem();
            importMenuItem = new ToolStripMenuItem();
            exportMenuItem = new ToolStripMenuItem();
            exportLogMenuItem = new ToolStripMenuItem();
            exportHistoryMenuItem = new ToolStripMenuItem();
            profilesMenuItemBar = new ToolStripMenuItem();
            supplierMenuItem = new ToolStripMenuItem();
            staffMenuItem = new ToolStripMenuItem();
            userMenuItem = new ToolStripMenuItem();
            settingMenuItemBar = new ToolStripMenuItem();
            aboutUsMenuItem = new ToolStripMenuItem();
            menubar.SuspendLayout();
            SuspendLayout();
            // 
            // tabform
            // 
            tabform.Dock = DockStyle.Fill;
            tabform.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabform.Location = new Point(0, 47);
            tabform.Margin = new Padding(0);
            tabform.Name = "tabform";
            tabform.Padding = new Point(20, 4);
            tabform.SelectedIndex = 0;
            tabform.Size = new Size(1178, 632);
            tabform.TabIndex = 0;
            // 
            // menubar
            // 
            menubar.BackColor = SystemColors.ActiveCaption;
            menubar.Font = new Font("Segoe UI", 10F);
            menubar.ImageScalingSize = new Size(20, 20);
            menubar.Items.AddRange(new ToolStripItem[] { homeMenuItemBar, inventoryMenuItemBar, importExportMenuItemBar, profilesMenuItemBar, settingMenuItemBar });
            menubar.Location = new Point(0, 0);
            menubar.Name = "menubar";
            menubar.Padding = new Padding(5, 4, 0, 4);
            menubar.Size = new Size(1178, 47);
            menubar.TabIndex = 1;
            menubar.Text = "menu";
            // 
            // homeMenuItemBar
            // 
            homeMenuItemBar.Name = "homeMenuItemBar";
            homeMenuItemBar.Padding = new Padding(5, 8, 5, 8);
            homeMenuItemBar.Size = new Size(60, 39);
            homeMenuItemBar.Text = "Home";
            // 
            // inventoryMenuItemBar
            // 
            inventoryMenuItemBar.DropDownItems.AddRange(new ToolStripItem[] { categoryMenuItem, productMenuItem, inventoryMenuItem });
            inventoryMenuItemBar.Name = "inventoryMenuItemBar";
            inventoryMenuItemBar.Size = new Size(80, 39);
            inventoryMenuItemBar.Text = "Inventory";
            // 
            // categoryMenuItem
            // 
            categoryMenuItem.Name = "categoryMenuItem";
            categoryMenuItem.Size = new Size(137, 24);
            categoryMenuItem.Text = "Category";
            // 
            // productMenuItem
            // 
            productMenuItem.Name = "productMenuItem";
            productMenuItem.Size = new Size(137, 24);
            productMenuItem.Text = "Product";
            // 
            // inventoryMenuItem
            // 
            inventoryMenuItem.Name = "inventoryMenuItem";
            inventoryMenuItem.Size = new Size(137, 24);
            inventoryMenuItem.Text = "Inventory";
            // 
            // importExportMenuItemBar
            // 
            importExportMenuItemBar.DropDownItems.AddRange(new ToolStripItem[] { importMenuItem, exportMenuItem });
            importExportMenuItemBar.Name = "importExportMenuItemBar";
            importExportMenuItemBar.Size = new Size(115, 39);
            importExportMenuItemBar.Text = "Import / Export";
            // 
            // importMenuItem
            // 
            importMenuItem.Name = "importMenuItem";
            importMenuItem.Size = new Size(120, 24);
            importMenuItem.Text = "Import";
            // 
            // exportMenuItem
            // 
            exportMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportLogMenuItem, exportHistoryMenuItem });
            exportMenuItem.Name = "exportMenuItem";
            exportMenuItem.Size = new Size(120, 24);
            exportMenuItem.Text = "Export";
            // 
            // exportLogMenuItem
            // 
            exportLogMenuItem.Name = "exportLogMenuItem";
            exportLogMenuItem.Size = new Size(165, 24);
            exportLogMenuItem.Text = "Export Log";
            // 
            // exportHistoryMenuItem
            // 
            exportHistoryMenuItem.Name = "exportHistoryMenuItem";
            exportHistoryMenuItem.Size = new Size(165, 24);
            exportHistoryMenuItem.Text = "Export History";
            // 
            // profilesMenuItemBar
            // 
            profilesMenuItemBar.DropDownItems.AddRange(new ToolStripItem[] { supplierMenuItem, staffMenuItem, userMenuItem });
            profilesMenuItemBar.Name = "profilesMenuItemBar";
            profilesMenuItemBar.Size = new Size(65, 39);
            profilesMenuItemBar.Text = "Profiles";
            // 
            // supplierMenuItem
            // 
            supplierMenuItem.Name = "supplierMenuItem";
            supplierMenuItem.Size = new Size(127, 24);
            supplierMenuItem.Text = "Supplier";
            // 
            // staffMenuItem
            // 
            staffMenuItem.Name = "staffMenuItem";
            staffMenuItem.Size = new Size(127, 24);
            staffMenuItem.Text = "Staff";
            // 
            // userMenuItem
            // 
            userMenuItem.Name = "userMenuItem";
            userMenuItem.Size = new Size(127, 24);
            userMenuItem.Text = "User";
            // 
            // settingMenuItemBar
            // 
            settingMenuItemBar.DropDownItems.AddRange(new ToolStripItem[] { aboutUsMenuItem });
            settingMenuItemBar.Name = "settingMenuItemBar";
            settingMenuItemBar.Size = new Size(64, 39);
            settingMenuItemBar.Text = "Setting";
            // 
            // aboutUsMenuItem
            // 
            aboutUsMenuItem.Name = "aboutUsMenuItem";
            aboutUsMenuItem.Size = new Size(136, 24);
            aboutUsMenuItem.Text = "About Us";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1178, 679);
            Controls.Add(tabform);
            Controls.Add(menubar);
            Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            menubar.ResumeLayout(false);
            menubar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabform;
        private MenuStrip menubar;
        private ToolStripMenuItem homeMenuItemBar;
        private ToolStripMenuItem inventoryMenuItemBar;
        private ToolStripMenuItem productMenuItem;
        private ToolStripMenuItem categoryMenuItem;
        private ToolStripMenuItem settingMenuItemBar;
        private ToolStripMenuItem aboutUsMenuItem;
        private ToolStripMenuItem importExportMenuItemBar;
        private ToolStripMenuItem importMenuItem;
        private ToolStripMenuItem exportMenuItem;
        private ToolStripMenuItem exportLogMenuItem;
        private ToolStripMenuItem inventoryMenuItem;
        private ToolStripMenuItem profilesMenuItemBar;
        private ToolStripMenuItem userMenuItem;
        private ToolStripMenuItem staffMenuItem;
        private ToolStripMenuItem exportHistoryMenuItem;
        private ToolStripMenuItem supplierMenuItem;
    }
}