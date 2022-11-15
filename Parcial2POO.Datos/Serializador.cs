using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Parcial2POO.Datos
{
    public static class Serializador<T> where T:class,new()
    {
        public static void GuardarJson(string archivo, T objeto)
        {
            using (var escritor = new StreamWriter(archivo))
            {
                JsonSerializerOptions opciones = new JsonSerializerOptions();
                opciones.WriteIndented = true;
                var stringJson = JsonSerializer.Serialize(objeto, opciones);
                escritor.WriteLine(stringJson);
            }
        }
        public static T LeerJson(string archivo)
        {
            using (var lector = new StreamReader(archivo))
            {
                string linea = lector.ReadToEnd();
                return JsonSerializer.Deserialize<T>(linea);
            }
        }
    }
}
