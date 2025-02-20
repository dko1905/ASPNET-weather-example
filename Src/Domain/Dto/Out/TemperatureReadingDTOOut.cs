
using System.Text.Json.Serialization;

public sealed record TemperatureReadingDTOOut(
    [property: JsonPropertyName("degrees_c")]
    double DegreesC,
    [property: JsonPropertyName("degrees_f")]
    double DegreesF
);
