using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace RestaurantePedidos
{
    public class ArchivoProductos
    {
        string ruta = "productos_restaurante.json";

        public void Guardar(List<Producto> lista)
        {
            string json = JsonConvert.SerializeObject(lista, Newtonsoft.Json.Formatting.Indented);

            File.WriteAllText(ruta, json);
        }

        public List<Producto> Leer()
        {
            if (!File.Exists(ruta))
            {
                return new List<Producto>();
            }

            string json = File.ReadAllText(ruta);

            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            };

            return JsonConvert.DeserializeObject<List<Producto>>(json, settings)
                   ?? new List<Producto>();
        }
    }
}
