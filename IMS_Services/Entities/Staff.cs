using IMS_Services.EnumUtils;


namespace IMS_Services.Entities;

public class Staff
{
    public static string TableName = "tbStaff";
    public short StaffId { get; set; }
    public string? StaffName { get; set; }
    public EnumGender Gender { get; set; }
    public DateTime BirthDate { get; set; }
    public string? StaffPosition { get; set; }
    public string? Address { get; set; }
    public string? WorkNumber { get; set; }
    public string? PersonalNumber { get; set; }
    public DateTime HiredDate { get; set; }
    public decimal Salary { get; set; }
    public bool StoppedWork { get; set; }
}
