namespace IMS_Services.Entities;

public class User
{
    public static string TableName = "tbUser";
    public short ID { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public bool? IsLocked { get; set; }
    public Int16? Attempt {  get; set; }
    public DateTime? LockTime { get; set; }
    public short StaffID { get; set; }
}
