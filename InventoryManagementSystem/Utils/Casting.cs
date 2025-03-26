namespace InventoryManagementSystem.Utils;

public class Casting
{
    public static ComboBox CastCombobox(Control control)
    {
        if (control is ComboBox)
        {
            ComboBox castCbo = (ComboBox)control;
            return castCbo;
        }
        throw new Exception("Problem While Casting Combo Box ....");
    }

    public static CheckBox CastCheckbox(Control control)
    {
        if (control is CheckBox)
        {
            CheckBox checkBox = (CheckBox)control;
            return checkBox;
        }
        throw new Exception("Problem While Converting To Bool From Check Box ....");
    }

    public static DateTimePicker CastDateTimePicker(Control control) {
        if (control is DateTimePicker)
        {
            DateTimePicker dateTimePicker = (DateTimePicker)control;
            return dateTimePicker;
        }
        throw new Exception("Problem While Converting To DateTime ....");
    }

    public static NumericUpDown CastNumericUpDown(Control control)
    {
        if (control is NumericUpDown)
        {
            NumericUpDown numericUpDown = (NumericUpDown)control;
            return numericUpDown;
        }
        throw new Exception("Problem while converting to NumericUpDown...");
    }
}
