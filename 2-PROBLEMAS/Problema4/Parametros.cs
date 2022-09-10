namespace Problema4;

using System.Text.Json.Serialization;
public class Parametros
{
    [JsonPropertyName("campos")]
    public List<string> Campos { get; set; }
}