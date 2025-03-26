using IMS_Services.Services.Implementation;
using InventoryManagementSystem.Controller.ImportExportFormController;
using InventoryManagementSystem.Controller.ProfilesFormController;
using System;
using System.Collections.Generic;
namespace InventoryManagementSystem.Controller
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();


            this.Load += DoLoadingForm;
        }

        private void DoLoadingForm(object? sender, EventArgs e)
        {
            LoadData();
            StaffForm.countEventHandler += (sender) =>
            {
                CountAmountStaff();
            };

            UserForm.countEventHandler += (sender) =>
            {
                CountAmountUser();
            };
            ExportForm.countEventHandler += (sender) =>
            {
                CountAmountExport();
            };
            ImportForm.countEventHandler += (sender) =>
            {
                CountAmountImport();
            };
        }

        private void LoadData()
        {
            CountAmountExport();
            CountAmountStaff();
            CountAmountUser();
            CountAmountImport();
        }

        private void CountAmountStaff()
        {
            var count = StaffServices.GetAll();
            totalStaff.Text = count.Count().ToString();
        }

        private void CountAmountUser()
        {
            var count = UserServices.GetAll();
            totalUser.Text = count.Count().ToString();
        }

        private void CountAmountImport()
        {
            var count = ImportServices.GetAll();
            totalImport.Text = count.Count().ToString();
        }

        private void CountAmountExport()
        {
            var count = ExportServices.GetAll();
            totalExport.Text = count.Count().ToString();
        }
        
    }
}
