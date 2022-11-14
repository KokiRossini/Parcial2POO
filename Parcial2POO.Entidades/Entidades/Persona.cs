using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2POO.Entidades.Entidades
{
    public abstract class Persona
    {
        private protected string Apellido { get; }
        private protected string Nombre { get; }

        public Persona(string a, string n)
        {
            Apellido = a;
            Nombre = n;
        }
        public abstract string FichaTecnica();
        public virtual string NombreCompleto()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}
