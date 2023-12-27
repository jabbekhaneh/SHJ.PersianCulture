using Newtonsoft.Json;
using SHJ.PersianCulture.IRINRegion.Models;

namespace SHJ.PersianCulture.IRINRegion;

public class IRINRegionServices
{
    public List<Province> GetProvinces()
    {
        string json = File.ReadAllText(@"Provinces.json");
        return JsonConvert.DeserializeObject<List<Province>>(json);
    }

    public List<City> GetCities(int provinceId)
    {
        string json = File.ReadAllText(@"Cities.json");
        return JsonConvert.DeserializeObject<List<City>>(json)
            .Where(_ => _.province_id == provinceId).ToList();
    }
}
