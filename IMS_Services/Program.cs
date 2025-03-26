using IMS_Services.Entities;
using IMS_Services.EnumUtils;
using IMS_Services.Manager;
using IMS_Services.Services.Implementation;
using IMS_Services.Utils;
using Microsoft.Data.SqlClient;

namespace IMS_Services;

public class Program
{
    private static void Main(string[] args)
    {
        ReadJsonFile.Load("appsetting.json");

        Console.WriteLine(ReadJsonFile.Read);

        DatabaseConnection dbConnection = DatabaseConnection.Instance;

        Connection = dbConnection.GetConnection();
        
        
        Staff newStaff = new Staff
        {
            StaffName = "John",
            Gender = EnumGender.Male, 
            BirthDate = new DateTime(1990, 5, 15),
            StaffPosition = "Software Engineer",
            Address = "123 Main Street",
            WorkNumber = "1234567890",
            PersonalNumber = "0987654321",
            HiredDate = DateTime.Now,
            Salary = 60000.00m,
            StoppedWork = false
        };

        Staff updateStaff = new Staff
        {
            StaffId = 1,
            StaffName = "John Doe gggggg",
            Gender = EnumGender.Female,
            BirthDate = new DateTime(1990, 5, 20),
            StaffPosition = "Software",
            Address = "123 Main Street eeeeee",
            WorkNumber = "1234567890 11111111",
            PersonalNumber = "0987654321 2222222",
            HiredDate = DateTime.Now,
            Salary = 10000.00m,
            StoppedWork = false
        };

        // Execution

        //StaffServices.Add(newStaff);

        //if (StaffServices.Update(updateStaff))
        //{
        //    Console.WriteLine("Updated");
        //}

        // Get All
        //var resultAll = StaffServices.GetAll();

        //foreach (var staff in resultAll)
        //{
        //    Console.WriteLine(staff.StaffId + staff.StaffName);
        //}

        // Get One by Name

        //var resultOne = StaffServices.GetByName("g");
        //foreach (var staff in resultOne)
        //{
        //    Console.WriteLine(staff.StaffId + staff.StaffName);
        //}

        // Delete Staff By ID

        //if(StaffServices.Delete(1))
        //{
        //   Console.WriteLine("Staff ID 1 : Deleted");
        //}


    }

    public static SqlConnection Connection = default!;
}