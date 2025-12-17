using DemoMaui.Models;
using System.Net.Http.Json;

namespace DemoMaui.Services
{
    public class MeteoService(HttpClient client)
    {
        public async Task<MeteoData> GetMeteoAsync(double latidude, double longitude)
        {
            MeteoData result = (await client.GetFromJsonAsync<MeteoData>($"https://api.openweathermap.org/data/2.5/weather?lat={latidude}&lon={longitude}&appid=631d8910e6e2b10be6d70baee2b38510&units=metric&lang=fr")
            )!;
            return result;
        }
    }
}
