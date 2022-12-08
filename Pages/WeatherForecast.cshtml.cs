using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages;

public class WeatherForecastModel : PageModel
{
    private readonly ILogger<WeatherForecastModel> _logger;

    public WeatherForecastModel(ILogger<WeatherForecastModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}