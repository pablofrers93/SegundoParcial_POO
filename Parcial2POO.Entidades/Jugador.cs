using Parcial2POO.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2POO.Entidades
{
    public class Jugador : Persona
    {
        public int Numero { get; }
        public bool EsCapitan { get; }
        public static Tipo tipo;
        public override string FichaTecnica()
        {
            if (EsCapitan == true)
                return this.Apellido + " " +
                       this.Nombre + " capitán del equipo, camiseta número: " +
                       this.Numero;
            else
                return this.Apellido + " " +
                       this.Nombre + " camiseta numero: " +
                       this.Numero;
        }
        static Jugador()
        {
            tipo = Tipo.Jugador;
        }
        public Jugador (string nombre, string apellido, int numero, bool capitan):base(nombre, apellido)
        {
            this.Numero = numero;
            this.EsCapitan = capitan;
        }
        public Jugador (string nombre, string apellido):base(nombre, apellido)
        {
            this.Numero = 0;
            this.EsCapitan = false; 
        }
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return ((j1.Nombre == j2.Nombre) && 
                    (j1.Apellido == j2.Apellido) &&
                    (j1.Numero == j2.Numero));
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return ((j1.Nombre != j2.Nombre) ||
                    (j1.Apellido != j2.Apellido) ||
                    (j1.Numero != j2.Numero));
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Jugador))
            {
                return false;
            }

            return this.Nombre == ((Jugador)obj).Nombre &&
                   this.Apellido == ((Jugador)obj).Apellido &&
                   this.Numero == ((Jugador)obj).Numero; 
        }
        public static explicit operator int (Jugador jugador)
        {
            return jugador.Numero;
        }
    }
}
