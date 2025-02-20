using Microsoft.AspNetCore.Mvc;

public class WeatherService : IWeatherService
{
    public TemperatureReading GetTemperatureForCity(string cityName)
    {
        if (cityName == "cph")
        {
            return new TemperatureReading(5);
        }
        else if (cityName == "koge")
        {
            return new TemperatureReading(15);
        }
        else
        {
            throw new NotFoundError();
        }
    }

    public double GetTemperatureCelsius()
    {
        return 3.14;
    }
}
