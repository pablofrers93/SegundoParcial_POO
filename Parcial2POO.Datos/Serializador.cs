using Parcial2POO.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Parcial2POO.Datos
{
    public static class Serializador
    {
        public static void GuardarJson(string archivo, List<Jugador> objeto)
        {
            using (var escritor =new StreamWriter(archivo))
            {
                var stringJson = JsonSerializer.Serialize(objeto);
                escritor.WriteLine(stringJson);
            }
        }
        public static Equipo LeerJson(string archivo)
        {
            using (var lector = new StreamReader(archivo))
            {
                string linea = lector.ReadToEnd();
                return JsonSerializer.Deserialize<Equipo>(linea);

            }
        }
 
    }
}
