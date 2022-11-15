using Parcial2POO.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2POO.Entidades
{
    public class DirectorTecnico : Persona
    {
        public static Tipo tipo ;

        static DirectorTecnico()
        {
            tipo = Tipo.Tecnico;
        }

        public DirectorTecnico(string nombre, string apellido) : base(nombre, apellido)
        {
        }

        public override string FichaTecnica()
        {
            return this.Nombre.ToUpper() + " " +
                   this.Apellido.ToUpper() + ", director técnico";
        }
    }
}
