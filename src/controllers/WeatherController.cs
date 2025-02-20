using AutoMapper;
using Microsoft.AspNetCore.Mvc;


[Route("api")]
public sealed class WeatherController : ControllerBase
{
    private readonly IWeatherService weatherService;
    private readonly IMapper mapper;

    public WeatherController(IWeatherService weatherService, IMapper mapper)
    {
        this.weatherService = weatherService;
        this.mapper = mapper;
    }

    [HttpGet("{cityName}")]
    public ActionResult<TemperatureReadingDTOOut> Koge(string cityName)
    {
        // var temp = weatherService.GetTemperatureForCity(cityName);

        // return Ok(mapper.Map<TemperatureReadingDTOOut>(temp));
        return new TemperatureReadingDTOOut(1, 1);
    }
}
