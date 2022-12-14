using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2POO.Entidades.Entidades
{
    public class Jugador : Persona
    {
        private int numero;
        public int Numero
        {
            get { return numero; }
        }
        private bool esCapitan;
        public bool EsCapitan
        {
            get { return esCapitan; }
        }

        private static Tipo Tipo { get; }
        static Jugador()
        {
            Tipo = Tipo.Jugador;
        }
        public Jugador(string a, string n) : base(a, n)
        {
            numero = 0;
            esCapitan = false;
        }
        public Jugador(string a, string n, int num, bool esC) : base(a, n)
        {
            numero = num;
            esCapitan = esC;
        }

        public override string FichaTecnica()
        {
            if (esCapitan == true)
            {
                return $"{Apellido.ToUpper()} {Nombre}, Capitan del equipo, camiseta numero {Numero}";
            }
            else
            {
                return $"{Apellido.ToUpper()} {Nombre}, camiseta numero {Numero}";
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Jugador))
            {
                return false;
            }
            return this.Apellido == ((Jugador)obj).Apellido &&
                this.Nombre == ((Jugador)obj).Nombre &&
                this.Numero == ((Jugador)obj).Numero;
        }

        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.Equals(j2);
        }
        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }
        public static explicit operator int(Jugador j)
        {
            return j.Numero;
        }


    }
}
