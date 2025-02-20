using System.Text.Json.Serialization;

public record TemperaturePlaceDTOIn(
    [property: JsonPropertyName("city_name")]
    string CityName
);
