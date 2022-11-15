using Parcial2POO.Entidades;
using Parcial2POO.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2POO.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectorTecnico dt1 = new DirectorTecnico("Jorge", "Ibarra");
            Equipo e1 = new Equipo("Boca Juniors", dt1);

            Jugador j1 = new Jugador("Agustin", "Rossi", 1, false);
            Jugador j2 = new Jugador("Dario", "Benedetto", 10, false );
            Jugador j3 = new Jugador("Ezequiel", "Zeballos");
            Jugador j4 = new Jugador("Marcos", "Rojo",3, true);

            // agrego jugadores al equipo con el operador +
            e1 += j1;
            e1 += j2;
            e1 += j3;
            e1 += j4;

            // resto un jugador del equipo con el operador - 
            e1 -= j1;

            // conversión implicita de un equipo a un dato del tipo string
            string datosEquipo = e1;

            Console.WriteLine(datosEquipo);
            Console.WriteLine();
            
            // creo un nuevo jugador con mismos atributos que j1
            Jugador j20 = new Jugador("Agustin", "Rossi", 1, false);

            if (j1 == j20)
                Console.WriteLine("Los jugadores j1 y j20 son iguales...");
            else
                Console.WriteLine("Jugadores distintos...");

            Console.WriteLine();

            DirectorTecnico dt2 = new DirectorTecnico("Angela", "Barrios");
            Equipo e2 = new Equipo("Tigre", dt2, Deporte.Handball);

            Jugador j5 = new Jugador("Malena", "Rodriguez", 19, true);
            Jugador j6 = new Jugador("Ana", "Benitez", 25, false);
            Jugador j7 = new Jugador("Valeria", "Perez");

            // intento agregar otra capitana al equipo pero no se puede
            Jugador j8 = new Jugador("Romina", "Virelli", 55, true);

            e2 += j5;
            e2 += j6;
            e2 += j7;
            e2 += j8;

            string equipoDatos = e2;
            Console.WriteLine(equipoDatos);



            Console.ReadLine();
        }
    }
}
