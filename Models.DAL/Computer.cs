using System.ComponentModel.DataAnnotations;

namespace Models.DAL;

public class Computer
{
    [Key]public int ComputerId { get; set; }
    public decimal Price { get; set; }
    public string RAM { get; set; }
    public string CPU { get; set; }
    public string GPU { get; set; }
    public string? SataSSD { get; set; }
}