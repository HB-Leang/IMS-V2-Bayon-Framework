using IMS_Services.Entities;
using IMS_Services.EnumUtils;
using InventoryManagementSystem.Utils;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InventoryManagementSystem.Convertion;

public static class Convertor
{
    public static string ConvertToString(Control control)
    {
        return control.Text.Trim();
    }
    public static int ConvertToInt(Control control)
    {
        if (int.TryParse(control.Text.Trim(), out int data))
        {
            return data;
        }
        throw new Exception("Problem While Converting ...");
    }
    public static Int16 ConvertToInt16(Control control)
    {
        if (Int16.TryParse(control.Text.Trim(), out Int16 data))
        {
            return data;
        }
        throw new Exception("Problem While Converting ...");
    }
    public static decimal ConvertToDecimal(Control control)
    {
        if (decimal.TryParse(control.Text.Trim(), out decimal data))
        {
            return data;
        }
        throw new Exception("Problem While Converting ...");
    }
    public static short ConvertToShort(Control control)
    {
        if (short.TryParse(control.Text.Trim(), out short data))
        {
            return data;
        }
        throw new Exception("Problem While Converting ...");
    }
    public static byte ConvertToByte(Control control)
    {
        if (byte.TryParse(control.Text.Trim(), out byte data))
        {
            return data;
        }
        throw new Exception("Problem While Converting ...");
    }

    public static EnumUOM ConvertToEnumUOM(Control control)
    {
        return (EnumUOM)Casting.CastCombobox(control).SelectedIndex!;
    }

    public static EnumGender ConvertToEnumGender(Control control)
    {
        return (EnumGender)Casting.CastCombobox(control).SelectedIndex;
    }
    public static EnumPaymentMethod ConvertToEnumPaymentMethod(Control control)
    {
        return (EnumPaymentMethod)Casting.CastCombobox(control).SelectedIndex;
    }
    public static string? ConvertToStringFromCbo(Control control)
    {
        if (control is ComboBox) {
            ComboBox castCbo = (ComboBox)control;
            return castCbo.SelectedItem!.ToString();
        }
        throw new Exception("Problem While Converting To String From Combo Box ....");
    }
    public static DateTime ConvertToDateTime(Control control)
    {
        return Casting.CastDateTimePicker(control).Value;
    }
    public static bool ConvertToBooleanFromCheckBox(Control control) {
         return Casting.CastCheckbox(control).Checked;
    }

    public static byte ConvertToCategoryID(Control control)
    {
        return (Casting.CastCombobox(control).SelectedItem as Category)!.ID;
    }
    public static int ConvertToProductID(Control control)
    {
        if (control is ComboBox)
        {
            ComboBox castCbo = (ComboBox)control;
            return (int)castCbo.SelectedValue!;
        }
        throw new Exception("Problem While Converting To ProductID From Combo Box ....");
    }
    public static int ConvertToInvID(Control control)
    {
        if (control is ComboBox)
        {
            ComboBox castCbo = (ComboBox)control;
            string[] arr = ((string)castCbo.SelectedItem!).Split('-');
            return int.Parse(arr[0]);
        }
        throw new Exception("Problem While Converting To ProductID From Combo Box ....");
    }

    public static short ConvertToHandleByID(Control control)
    {
        return (Casting.CastCombobox(control).SelectedItem as Staff)!.StaffId;
    }

    public static byte ConvertToSupplierID(Control control)
    {
        return (Casting.CastCombobox(control).SelectedItem as Supplier)!.ID;
    }

}
