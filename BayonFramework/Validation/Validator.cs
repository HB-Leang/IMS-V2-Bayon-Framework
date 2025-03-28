namespace BayonFramework.Validation;

public class Validator
{
    public static void isNullOrEmpty(string Key,string? data)
    {
        if (string.IsNullOrEmpty(data))
        {
            throw new Exception($"{Key} must be not null or empty");
        }
    }
}
