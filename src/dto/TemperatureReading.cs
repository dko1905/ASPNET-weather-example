
public sealed record TemperatureReading(double DegreesC)
{
    const double factor = 9 / 5;
    public double DegreesF => DegreesC * factor + 32;
}
