

using IMS_Services.Entities;
using IMS_Services.EnumUtils;
using IMS_Services.Services.Implementation;
using InventoryManagementSystem.Utils;
using InventoryManagementSystem.Validation;
using Microsoft.IdentityModel.Tokens;


namespace InventoryManagementSystem.Controller.ProfilesFormController;

public partial class StaffForm : Form
{

    public static event CountEventHandler? countEventHandler;

    private Control[] controls;

    public StaffForm()
    {
        InitializeComponent();
        LoadData(); 

        controls = new Control[]
        {
            txtId,
            txtName,
            cboGender,
            dtDob,
            cboPosition,
            txtAddress,
            mtxtWorkTel,
            mtxtPersonalTel,
            dtHireDate,
            txtSalary,
            chkStoppedWork,
            listStaff
        };

        cboGender.DataSource = Enum.GetValues<EnumGender>();
        cboGender.SelectedIndex = 0;

        cboPosition.DataSource = new List<string>() { "Sale", "Accountant", "Manager", "Software Engineer" };
        cboPosition.SelectedIndex = 0;

        btnInsert.Click += DoClickInsertStaff;
        btnUpdate.Click += DoClickUpdateStaff;
        btnClear.Click += DoClickClearStaff;
        btnDelete.Click += DoClickDeleteStaff;

        listStaff.Click += DoClickListStaff;
        txtSearch.TextChanged += DoSearchTextChange;
    }

    #region click event

    private void DoClickDeleteStaff(object? sender, EventArgs e)
    {

        try
        {
            if(txtId.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please Choose Staff You Want To Delete First ...", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure you want to delete the staff member with ID {txtId.Text}?","Confirm Deletion",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                bool isDeleted = StaffServices.Delete(short.Parse(txtId.Text));

                if (isDeleted)
                {
                    MessageBox.Show($"Staff with ID {txtId.Text} has been successfully deleted.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        countEventHandler!.Invoke(this);
                }
                else
                {
                    MessageBox.Show($"No staff member found with ID {txtId.Text}.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }else
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

    private void DoClickUpdateStaff(object? sender, EventArgs e)
    {
        try
        {
            if (IsStaffValid())
            {
                // create instance staff
                Staff staff = CreatorEntities.CreateStaff(controls);

                // assign staff id for staff
                staff.StaffId = short.Parse(txtId.Text);
                
                // add staff to database
                bool effected = StaffServices.Update(staff);

                if (effected)
                {
                    MessageBox.Show($"Staff ID : {txtId.Text} Info Updated!", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    private void DoClickInsertStaff(object? sender, EventArgs e)
    {
        try
        {
            if (IsStaffValid())
            {
                // create instance staff
                Staff staff = CreatorEntities.CreateStaff(controls);

                // add staff to database
                StaffServices.Add(staff);

                //clear control
                Util.ClearControls(controls);

                // LoadData
                LoadData();

                // show message to user
                MessageBox.Show($"Staff Added!", "Creating", MessageBoxButtons.OK, MessageBoxIcon.Information);

                countEventHandler!.Invoke(this);
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

    private void DoClickListStaff(object? sender, EventArgs e)
    {
        btnInsert.Enabled = false;
        LoadEntities.LoadStaffFromListStaff(controls, listStaff);
    }

    private void DoSearchTextChange(object? sender, EventArgs e)
    {
        
        var result = StaffServices.GetByName(txtSearch.Text);
        listStaff.Items.Clear();
        foreach (var staff in result)
        {
            listStaff.Items.Add(staff.StaffId + "." + staff.StaffName);
        }
    }

    private void DoClickClearStaff(object? sender, EventArgs e)
    {
        //clear control
        Util.ClearControls(controls);
        btnInsert.Enabled = true;
    }


    #endregion

    #region method

    private void LoadData()
    {
        listStaff.Items.Clear();
        var result = StaffServices.GetAll();
        foreach (var staff in result) {
            listStaff.Items.Add(staff.StaffId + "." + staff.StaffName);
        }
    }

    #endregion

    #region Validation

    
    private bool IsStaffValid()
    {
        bool isVilid = true;
        isVilid = Validator.IsValidData(controls.Skip(1).ToArray());
        return isVilid;
    }




    #endregion

    
}