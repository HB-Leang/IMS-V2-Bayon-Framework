

namespace InventoryManagementSystem.Validation;

public static class Validator
{
    public static bool IsValidData(Control[] controls)
    {
        bool isValid = true;
        foreach (var control in controls)
        {
            isValid &= IsPresent(control);
        }
        return isValid;
    }

    private static bool IsPresent(Control control)
    {
        if (control is TextBox textBox)
        {
            return !string.IsNullOrWhiteSpace(textBox.Text);
        }
        else if (control is ComboBox comboBox)
        {
            return comboBox.SelectedIndex != -1;
        }
        else if (control is MaskedTextBox maskedTextBox)
        {
            return !string.IsNullOrWhiteSpace(maskedTextBox.Text);
        }
        else if (control is RichTextBox richTextBox)
        {
            return !string.IsNullOrWhiteSpace(richTextBox.Text);
        }
        return true;
    }


}
