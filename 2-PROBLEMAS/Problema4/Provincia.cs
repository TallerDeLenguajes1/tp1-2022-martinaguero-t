namespace Problema4;

using System.Text.Json.Serialization;

public class Provincia
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("nombre")]
    public string Nombre { get; set; }
}