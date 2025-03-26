using InventoryManagementSystem.Controller;
using InventoryManagementSystem.Controller.ImportExportFormController;
using InventoryManagementSystem.Controller.InventoryFormController;
using InventoryManagementSystem.Controller.ProfilesFormController;
using InventoryManagementSystem.Controller.SettingFormController;

namespace InventoryManagementSystem
{
    public partial class MainForm : Form
    {

        public static event CloseHandler? closeHandler;
        public MainForm()
        {
            InitializeComponent();
            //tabform.Padding = new Point(20, 4);
            HomePage();

            // Tap Click Menu Item
            homeMenuItemBar.Click += DoClickHomeMenu;
            productMenuItem.Click += DoClickProductForm;
            categoryMenuItem.Click += DoClickCategoryForm;
            inventoryMenuItem.Click += DoClickInventoryForm;

            importMenuItem.Click += DoClickImportForm;
            exportLogMenuItem.Click += DoClickExportForm;
            exportHistoryMenuItem.Click += DoClickExportDetailForm;

            userMenuItem.Click += DoClickUserForm;
            staffMenuItem.Click += DoClickStaffForm;
            supplierMenuItem.Click += DoClickSupplierForm;


            aboutUsMenuItem.Click += DoClickAboutUsForm;

            tabform.DrawItem += DoDrawItem;
            tabform.MouseDown += DoCloseTab;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            closeHandler!.Invoke();
            base.OnFormClosing(e);
        }

        private void DoClickSupplierForm(object? sender, EventArgs e)
        {
            TabPage supplierFrmPage = new();
            OpenTabPage(new SupplierForm(), supplierFrmPage);

        }

        private void DoClickAboutUsForm(object? sender, EventArgs e)
        {
            AboutUsForm aboutForm = new AboutUsForm();
            aboutForm.Show();
        }

        

        private void DoClickStaffForm(object? sender, EventArgs e)
        {
            TabPage staffFrmPage = new();
            OpenTabPage(new StaffForm(), staffFrmPage);
        }

        private void DoClickUserForm(object? sender, EventArgs e)
        {
            TabPage userFrmPage = new();
            OpenTabPage(new UserForm(), userFrmPage);
        }

        private void DoClickExportDetailForm(object? sender, EventArgs e)
        {
            TabPage exportDetailFrmPage = new();
            OpenTabPage(new ExportDetailForm(), exportDetailFrmPage);
        }

        private void DoClickExportForm(object? sender, EventArgs e)
        {
            TabPage exportFrmPage = new();
            OpenTabPage(new ExportForm(), exportFrmPage);
        }

        private void DoClickImportForm(object? sender, EventArgs e)
        {
            TabPage importFrmPage = new();
            OpenTabPage(new ImportForm(), importFrmPage);
        }

        private void DoClickInventoryForm(object? sender, EventArgs e)
        {
            TabPage invnetoryFrmPage = new();
            OpenTabPage(new InventoryForm(), invnetoryFrmPage);
        }

        private void DoClickCategoryForm(object? sender, EventArgs e)
        {
            TabPage categoryFrmPage = new();
            OpenTabPage(new CategoryForm(), categoryFrmPage);
        }

        private void DoDrawItem(object? sender, DrawItemEventArgs e)
        {
            e.Graphics.DrawString("X", e.Font!, Brushes.Black, e.Bounds.Right - 20, e.Bounds.Top + 4);
            e.Graphics.DrawString(this.tabform.TabPages[e.Index].Text, e.Font!, Brushes.Black, e.Bounds.Left + 15, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }

        private void DoCloseTab(object? sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.tabform.TabPages.Count; i++)
            {
                Rectangle r = tabform.GetTabRect(i);

                Rectangle closeButton = new Rectangle(r.Right - 20, r.Top + 4, 25, 20);
                if (closeButton.Contains(e.Location))
                {
                    if (MessageBox.Show("Would you like to Close this Tab?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.tabform.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        private void DoClickProductForm(object? sender, EventArgs e)
        {
            TabPage productFrmPage = new();
            OpenTabPage(new ProductForm(), productFrmPage);
        }

        private void DoClickHomeMenu(object? sender, EventArgs e)
        {
            HomePage();
        }

        private void HomePage()
        {
            TabPage frmHomePage = new();
            OpenTabPage(new HomeForm(), frmHomePage);
        }

        private void OpenTabPage(Form frm, TabPage tabPage)
        {
            int index = CheckTabPageInTabControl(tabform, frm);

            if (index != -1)
            {
                tabform.SelectedIndex = index;
                return;
            }

            tabPage.Text = frm.Text;
            tabPage.BorderStyle = BorderStyle.Fixed3D;

            tabform.TabPages.Add(tabPage);
            tabform.AllowDrop = true;
            tabform.SelectedTab = tabPage;

            frm.TopLevel = false;
            frm.Parent = tabPage;
            frm.Show();
            frm.Dock = DockStyle.Fill;

        }

        private int CheckTabPageInTabControl(TabControl tabControl, Form frm)
        {
            for (int i = 0; i < tabControl.TabCount; i++)
            {
                if (tabControl.TabPages[i].Text.Trim().Equals(frm.Text.Trim()))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
