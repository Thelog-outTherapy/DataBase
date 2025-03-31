using System.ComponentModel.DataAnnotations;

namespace Models.DAL;

public class Client
{
    [Key]public int ClientID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public TimeOnly SessionTime { get; set; }
}