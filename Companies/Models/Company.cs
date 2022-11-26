namespace Companies.Models;

public class Company
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public string? Exchange { get; set; }
    public string? Ticker { get; set; }
    //[UniqueKey] // Unique Key 
    public string? Isin { get; set; }
    public string? Website { get; set; }
}