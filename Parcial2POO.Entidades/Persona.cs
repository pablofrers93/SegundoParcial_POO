using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2POO.Entidades
{
    public abstract class Persona
    {
        public string Nombre { get; }
        public string Apellido { get;}

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
        public abstract string FichaTecnica();
        public virtual string NombreCompleto()
        {
            return Nombre + " " + Apellido;
        }
    }
}
