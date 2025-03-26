using IMS_Services.EnumUtils;
using System.Windows.Forms;
namespace InventoryManagementSystem.Utils;

public static class Util
{

    private static void ClearControl(Control control)
    {
        if (control is TextBox textBox)
        {
            textBox.Text = "";
        } else if (control is RichTextBox richText)
        {
            richText.Text = string.Empty;
        }
        else if (control is ComboBox comboBox)
        {
            comboBox.SelectedIndex = -1;
        }
        else if (control is MaskedTextBox maskTextBox)
        {
            maskTextBox.Text = "";
        }
        else if (control is DateTimePicker dateTimePicker)
        {
            dateTimePicker.Value = DateTime.Now;
        }
        else if (control is CheckBox checkBox)
        {
            checkBox.Checked = false;
        }
        else if (control is ListBox listBox)
        {
            listBox.ClearSelected();
        }
        else if (control is DataGridView dataGridView)
        {
            dataGridView.ClearSelection();
        }else if (control is NumericUpDown numericUpDown)
        {
            numericUpDown.Value = 0;
        }
    }

    public static void ClearControls(Control[] controls)
    {
        foreach (Control control in controls)
        {
            ClearControl(control);
        }
    }

}
