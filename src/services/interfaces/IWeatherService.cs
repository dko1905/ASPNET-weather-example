
public interface IWeatherService
{
    public double GetTemperatureCelsius();
    /// <summary>
    /// Get temperature for city specified using "cityName".
    /// </summary>
    /// <param name="cityName">Name of city.</param>
    /// <returns>Temperature reading.</returns>
    /// <exception cref="NotFoundError">City not found.</exception>
    public TemperatureReading GetTemperatureForCity(string cityName);
}
