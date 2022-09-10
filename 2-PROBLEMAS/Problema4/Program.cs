using System.Net;
using System.Text.Json;

namespace Problema4;

class Program {

    static void Main(string[] args){

        Console.WriteLine("2) PROBLEMA 4:");
        
        InfoAPI infoAPI = obtenerInformacionAPI();

        mostrarInformacionProvincias(infoAPI.Provincias);
        
        Console.ReadLine();
    }

    static void mostrarInformacionProvincias(List<Provincia> listaProvincias){
        
        try
        {
            Console.WriteLine("Se obtuvo el siguiente listado de provincias: ");
            foreach (var provincia in listaProvincias)
            {
                Console.WriteLine($"Provincia: {provincia.Nombre}");
            }
        }
        catch (NullReferenceException excepcion)
        {
            Console.WriteLine("Error, no se pudo cargar la lista de provincias.");
        }

    }
    static InfoAPI obtenerInformacionAPI(){

        InfoAPI infoAPI = new InfoAPI();

        string url = $"https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre";
        var request = (HttpWebRequest) WebRequest.Create(url);

        request.Method = "GET";
        request.Accept = "application/json";
        request.ContentType = "application/json";

        try
        {
            using (WebResponse respuesta = request.GetResponse())
            {
                using (Stream reader = respuesta.GetResponseStream())
                {
                    using (StreamReader objectReader = new StreamReader(reader))
                    {
                        string lecturaJson = objectReader.ReadToEnd();
                        infoAPI = JsonSerializer.Deserialize<InfoAPI>(lecturaJson);
                    }
                }
            }
        }
        catch (WebException excepcion)
        {
            Console.WriteLine($"Hubo un error al conectar con el servicio web. Excepción encontrada: {excepcion.Message}");

        } catch(JsonException excepcionJson){

            Console.WriteLine($"Hubo un error al deserializar el JSON recibido. Excepción encontrada: {excepcionJson.Message}");

        }

        return infoAPI;

    }

}

