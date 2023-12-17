using Microsoft.AspNetCore.Mvc;

namespace lr9.ViewComponents
{
    public class WeatherViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string city)
        {
            var apiKey = "0d99ca06941bfa04d9b9fb925fa818d9";
            var apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}";
            WeatherResponse? response;
            using (var client = new HttpClient())
            {
                response = await client.GetFromJsonAsync<WeatherResponse>(apiUrl);
            }
            return View(response);
        }
    }

    public class WeatherResponse
    {
        public MainInfo Main { get; set; }
        public WeatherInfo[] Weather { get; set; }
    }

    public class MainInfo
    {
        public float Temp { get; set; }
    }

    public class WeatherInfo
    {
        public string Description { get; set; }
    }
}
