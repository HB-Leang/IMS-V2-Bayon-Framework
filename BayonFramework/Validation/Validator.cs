namespace BayonFramework.Validation;

public class Validator
{
    public static void isNullOrEmpty(string? data)
    {
        if (string.IsNullOrEmpty(data))
        {
            throw new Exception($"{data} must be not null or empty");
        }
    }
}
