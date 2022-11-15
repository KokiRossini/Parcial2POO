using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2POO.Entidades.Entidades
{
    public abstract class Persona
    {        
        private string apellido;
        public string Apellido
        {
            get { return apellido; }
        }

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
        }
        public Persona(string a, string n)
        {
            apellido = a;
            nombre = n;
        }
        public abstract string FichaTecnica();
        public virtual string NombreCompleto()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}
