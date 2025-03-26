using IMS_Services.Entities;
using IMS_Services.Services.Implementation;
using InventoryManagementSystem.Utils;
using InventoryManagementSystem.Validation;
using Microsoft.IdentityModel.Tokens;

namespace InventoryManagementSystem.Controller.ImportExportFormController.SubImportExportForm;

public partial class UpdateExportDetail : Form
{
    public event ExportDetailHandler? ExportModified;


    private static UpdateExportDetail instance = null!;
    private Control[] controls;
    private int oldQtyStock;
    public static ExportDetail exportDetail { get; set; } = null!;
    public UpdateExportDetail()
    {
        InitializeComponent();

        LoadComboBoxes.LoadProductCBO(cboProductId);
        
        LoadComboBoxes.LoadExportID(cboExportID);
        

        controls = new Control[]
        {
                txtId,
                cboExportID,
                txtUnitPrice,
                nudQuantityExport,
                txtSubTotal,
                cboProductId,
                cboInvID,
        };

        LoadEntities.LoadExportDetailFromObject(controls, exportDetail);
        oldQtyStock = (int)nudQuantityExport.Value;
        nudQuantityExport.ValueChanged += DoQtyValueChanged;
        cboProductId.SelectedIndexChanged += DoProductIdIndexChanged;
        btnSubmit.Click += DoClickSubmit;
    }

    private void DoQtyValueChanged(object? sender, EventArgs e)
    {
        if (txtUnitPrice.Text.IsNullOrEmpty()) return ;
        if (nudQuantityExport.Value == 0) return;
        DoCalculate();
    }

    private void DoProductIdIndexChanged(object? sender, EventArgs e)
    {
        if (cboProductId.SelectedItem == null) return;
        Product pro = cboProductId.SelectedItem as Product;
        txtUnitPrice.Text = pro.SalePrice.ToString();
        LoadComboBoxes.LoadInventoryID(cboInvID, (int)cboProductId.SelectedValue!);
        DoCalculate();
    }
    
    private void DoClickSubmit(object? sender, EventArgs e)
    {
        try
        {
            if (IsExportDetailValid())
            {
                string[] arr = cboInvID.Text.Split('-');
                int qtyStock = int.Parse(arr[1]);
                if (nudQuantityExport.Value - oldQtyStock > qtyStock)
                {
                    MessageBox.Show("Not enough quantity on this inventory!", "Adding Row", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                ExportDetail exportDetail = CreatorEntities.CreateExportDetail(controls.Skip(2).ToArray());

                exportDetail.ID = int.Parse(txtId.Text);

                exportDetail.ExportID = int.Parse(cboExportID.SelectedItem.ToString());

                bool effected = ExportDetailServices.Update(exportDetail);

                if (effected)
                {
                    MessageBox.Show($"Export Detail ID : {txtId.Text} Info Updated!", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ExportModified?.Invoke(this);

                    Util.ClearControls(controls);
                }
                else
                {
                    MessageBox.Show($"Error Updating Data", "Updating", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                Util.ClearControls(controls);
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

    private void DoCalculate()
    {
        if (cboProductId.SelectedItem == null) return;

        decimal subTotal = decimal.Parse(txtUnitPrice.Text.Trim()) * (decimal)nudQuantityExport.Value;

        txtSubTotal.Text = subTotal.ToString();
    }

    #region Validation


    private bool IsExportDetailValid()
    {
        bool isVilid = true;
        isVilid = Validator.IsValidData(controls.Skip(1).ToArray());
        return isVilid;
    }

    #endregion

    #region SingleTon For Only Show One Form
    public static UpdateExportDetail GetInstance()
    {
        if (instance == null || instance.IsDisposed)
        {
            instance = new UpdateExportDetail();
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


    protected override void OnFormClosed(FormClosedEventArgs e)
    {
        MainForm mainForm = Application.OpenForms["MainForm"] as MainForm;
        if (mainForm != null)
        {
            mainForm.Activate();
        }
        base.OnFormClosed(e);
    }
}
