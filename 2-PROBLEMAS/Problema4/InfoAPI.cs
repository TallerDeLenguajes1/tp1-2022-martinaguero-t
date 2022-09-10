namespace Problema4;

using System.Text.Json.Serialization;
public class InfoAPI
{
    [JsonPropertyName("cantidad")]
    public int Cantidad { get; set; }

    [JsonPropertyName("inicio")]
    public int Inicio { get; set; }

    [JsonPropertyName("parametros")]
    public Parametros Parametros { get; set; }

    [JsonPropertyName("provincias")]
    public List<Provincia> Provincias { get; set; }

    [JsonPropertyName("total")]
    public int Total { get; set; }
}