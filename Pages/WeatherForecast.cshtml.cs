using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Helpers;

namespace WebApp.Pages;

public class WeatherForecastModel : PageModel
{
    // public DateTime _date { get; set; }
    // public int _temperatureC { get; set; }
    // public int _temperatureF { get; set; }
    // public string _summary { get; set; }
    private readonly ILogger<WeatherForecastModel> _logger;

    public WeatherForecastModel(ILogger<WeatherForecastModel> logger//,
                                // DateTime date,
                                // int temperatureC,
                                // int temperatureF,
                                // string summary
                                )
    {
        _logger = logger;
        // _date = date;
        // _temperatureC = temperatureC;
        // _temperatureF = temperatureF;
        // _summary = summary;
    }

    public void OnGet()
    {
       string clientToken = GenerateToken.GenerateClientToken();
       ViewData["clienttoken"] = clientToken;
       ViewData["username"] = User.Identity.Name;
    }
}