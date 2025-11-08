using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WeatherDashboardCICD.Pages
{
    public class IndexModel : PageModel
    {
        public record Weather(string City, int TemperatureC, string Condition);

        public List<Weather> WeatherList { get; set; } = new();

        public void OnGet()
        {
            var random = new Random();
            var cities = new[] { "Delhi", "Mumbai", "Bangalore", "Chennai", "Hyderabad" };
            var conditions = new[] { "Sunny", "Cloudy", "Rainy", "Stormy", "Foggy" };

            WeatherList = cities.Select(c =>
                new Weather(
                    c,
                    random.Next(15, 42),
                    conditions[random.Next(conditions.Length)]
                )
            ).ToList();
        }
    }
}
