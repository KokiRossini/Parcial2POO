using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2POO.Entidades.Entidades
{
    public class DirectorTecnico : Persona
    {
        private static Tipo Tipo;

        static DirectorTecnico()
        {
            Tipo = Tipo.Tecnico;
        }
        public DirectorTecnico(string a, string n):base(a,n)
        {
        }
        public override string FichaTecnica()
        {
            return $"{Nombre.ToUpper()} {Apellido.ToUpper()}, director tecino";
        }
    }
}
