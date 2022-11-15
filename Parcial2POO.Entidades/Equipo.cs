using Parcial2POO.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2POO.Entidades
{
    public class Equipo
    {
        public static Deporte Deporte { get; set; }
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        public string nombre;

        static Equipo()
        {
            Deporte = Deporte.Futbol;
        }
        private Equipo()
        {
            jugadores = new List<Jugador>();
        }
        public Equipo(string nombre, DirectorTecnico dt) : this()
        {
            this.nombre = nombre;
            this.directorTecnico = dt;
        }
        public Equipo(string nombre, DirectorTecnico dt, Deporte deporte) : this()
        {
            this.nombre = nombre;
            this.directorTecnico = dt;
            Deporte = deporte;
        }
        private bool ExisteCapitan()
        {
            foreach (Jugador jugador in jugadores)
            {
                if (jugador.EsCapitan)
                    return true;
            }
            return false;
        }
        public static bool operator ==(Equipo e1, Jugador j1)
        {
            return e1.jugadores.Contains(j1);
        }
        public static bool operator !=(Equipo e1, Jugador j1)
        {
            return !e1.jugadores.Contains(j1);
        }
        public static Equipo operator +(Equipo e1, Jugador j1)
        {
            if (e1 != j1)
            {
                if (e1.ExisteCapitan() && !(j1.EsCapitan) || 
                    !(e1.ExisteCapitan()) && j1.EsCapitan || 
                    !(e1.ExisteCapitan()) && !(j1.EsCapitan))
                    e1.jugadores.Add(j1);
                return e1;
            }

            else
                return e1;
        }
        public static Equipo operator -(Equipo e1, Jugador j1)
        {
            if (e1 == j1)
            {
                e1.jugadores.Remove(j1);
                return e1;
            }
            else
                return e1;
        }
        public string ListaJugadores()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Jugador jugador in jugadores)
            {
                sb.AppendLine(jugador.FichaTecnica());
            }
            return sb.ToString();
        }
        public static implicit operator string(Equipo e1)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(e1.nombre);
            sb.AppendLine("Nómina de jugadores: ");
            sb.AppendLine(e1.ListaJugadores());
            sb.AppendLine(e1.directorTecnico.FichaTecnica());
            return sb.ToString();
        }
    }
}
