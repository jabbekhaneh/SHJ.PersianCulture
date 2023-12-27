namespace SHJ.PersianCulture.IRINRegion.Models;

public class City
{
    public int id { get; set; }
    public string name { get; set; } = string.Empty;
    public string slug { get; set; } = string.Empty;
    public int province_id { get; set; }
}