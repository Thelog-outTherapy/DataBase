using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.DAL;

public class Session
{
    [Key]public int SessionID  { get; set; }
    public string SessionUser { get; set; }
    [ForeignKey("SessionUser")]public Client? Client { get; set; } 
    
    public string ComputerUser { get; set; }
    [ForeignKey("ComputerUser")]public Computer? Computer  { get; set; } 
    
    public string GameUser { get; set; }
    [ForeignKey("GameUser")]public Game? Game { get; set; } 
    
}