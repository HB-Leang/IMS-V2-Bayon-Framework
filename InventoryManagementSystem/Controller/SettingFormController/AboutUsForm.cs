using InventoryManagementSystem.Controller.ImportExportFormController.SubImportExportForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Controller.SettingFormController
{
    public partial class AboutUsForm : Form
    {

        private static AboutUsForm instance = null!;

        public AboutUsForm()
        {
            InitializeComponent();
        }


        #region SingleTon For Only Show One Form
        public static AboutUsForm GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new AboutUsForm();
            }
            return instance;
        }
        public new void Show()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = this;
                base.Show();
            }
            else
            {
                // Bring the existing form to the front if already open
                instance.BringToFront();
            }
        }
        #endregion

    }
}
