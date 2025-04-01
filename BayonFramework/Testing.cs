namespace BayonFramework;

public class Testing
{
    static void Main(string[] args)
    {
        try
        {

            //QueryTesting.Run();
             AuthTesting.Run();

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }




}
