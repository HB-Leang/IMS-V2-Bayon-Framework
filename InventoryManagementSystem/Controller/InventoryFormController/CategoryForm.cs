
using IMS_Services.Entities;
using IMS_Services.Services.Implementation;
using InventoryManagementSystem.Utils;
using InventoryManagementSystem.Validation;
using Microsoft.IdentityModel.Tokens;

namespace InventoryManagementSystem.Controller
{
    public partial class CategoryForm : Form
    {
        private Control[] controls;

        public CategoryForm()
        {
            InitializeComponent();

            LoadData();

            controls = new Control[]
            {
                txtId,
                txtName,
                rtxtDesc,
                dgvCategory,
            };


            btnInsert.Click += DoClickInsertCategory;
            btnUpdate.Click += DoClickUpdateCategory;
            btnDelete.Click += DoClickDeleteCategory;
            btnClear.Click += DoClickClear;

            dgvCategory.Click += DoClickDataGridView;
            txtSearch.TextChanged += DoSearchTextChange;

        }        

        #region Event

        private void DoClickDataGridView(object? sender, EventArgs e)
        {
            btnInsert.Enabled = false;
            LoadEntities.LoadCategoryFromDataGrid(controls, dgvCategory);
        }

        private void DoClickDeleteCategory(object? sender, EventArgs e)
        {
            try
            {
                if (txtId.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("Please Choose Category You Want To Delete First ...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show($"Are you sure you want to delete the Category member with ID {txtId.Text}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    bool isDeleted = CategoryServices.Delete(byte.Parse(txtId.Text));

                    if (isDeleted)
                    {
                        MessageBox.Show($"Category with ID {txtId.Text} has been successfully deleted.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"No Category member found with ID {txtId.Text}.",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Deletion canceled.",
                        "Canceled",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                Util.ClearControls(controls);
                LoadData();
                btnInsert.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DoClickUpdateCategory(object? sender, EventArgs e)
        {
            try
            {
                if (IsCategoryValid())
                {

                    Category category = CreatorEntities.CreateCategory(controls);

                    category.ID = byte.Parse(txtId.Text);

                    bool effected = CategoryServices.Update(category);

                    if (effected)
                    {
                        MessageBox.Show($"Category ID : {txtId.Text} Info Updated!", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        Util.ClearControls(controls);
                        
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show($"Error Updating Data", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    btnInsert.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Some Inputs are missing or not correct format!", "Creating", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DoClickClear(object? sender, EventArgs e)
        {
            Util.ClearControls(controls);
            btnInsert.Enabled = true;
        }

        private void DoClickInsertCategory(object? sender, EventArgs e)
        {
            try
            {
                if (IsCategoryValid())
                {

                    Category category = CreatorEntities.CreateCategory(controls);

                    CategoryServices.Add(category);

                    Util.ClearControls(controls);

                    LoadData();

                    // show message to user
                    MessageBox.Show($"Category Added!", "Creating", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Some Inputs are missing or not correct format!", "Creating", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DoSearchTextChange(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                LoadData();
                return;
            };

            var result = CategoryServices.GetByName(txtSearch.Text);
            dgvCategory.Rows.Clear();
            foreach (var category in result)
            {
                AddToView(category);
            }
        }

        #endregion

        #region

        private void LoadData()
        {
            dgvCategory.Rows.Clear();

            var result = CategoryServices.GetAll();

            foreach (var category in result)
            {
                AddToView(category);
            }
        }

        private void AddToView(Category category)
        {
            dgvCategory.Rows.Add(category.ID, category.Name, category.Description);
        }

        #endregion

        #region Validation

        private bool IsCategoryValid()
        {
            bool isVilid = true;
            isVilid = Validator.IsValidData(controls.Skip(1).ToArray());
            return isVilid;
        }

        #endregion

    }
}
