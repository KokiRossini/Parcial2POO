using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2POO.Entidades.Entidades
{
    public class Equipo
    {
        private static Deporte deporte;
        public Deporte Deporte
        {
            set { deporte = value; }
            get { return deporte; }
        }
        private List<Jugador> jugadores;

        public List<Jugador> Jugadores
        {
            get { return jugadores; }
        }

        private DirectorTecnico directorTecnico;
        public DirectorTecnico DirectorTecnico
        {
            get { return directorTecnico; }
        }


        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        static Equipo()
        {
            deporte = Deporte.Futbol;
        }
        private Equipo()
        {
            jugadores = new List<Jugador>();
        }
        public Equipo(string n, DirectorTecnico dt)
        {
            Nombre = n;
            directorTecnico = dt;
        }
        public Equipo(string n, DirectorTecnico dt, Deporte d):this()
        {
            Nombre = n;
            directorTecnico = dt;
            Deporte = d;
        }

        public static bool operator ==(Jugador j, Equipo e)
        {
            bool existe = false;
            foreach (var jugador in e.Jugadores)
            {
                if (j==jugador)
                {
                    existe = true;
                }
            }
            return existe;
        }
        public static bool operator !=(Jugador j, Equipo e)
        {
            return !(j==e);
        }
        public static bool operator +(Jugador j, Equipo e)
        {
            bool agregado = false;
            bool capitan = false;
            if (j!=e)
            {
                if (j.EsCapitan)
                {
                    capitan = true;
                }
                if (e.ExisteCapitan()==false && capitan==false || e.ExisteCapitan() == false && capitan == true || e.ExisteCapitan() == true && capitan == false)
                {
                    agregado = true;
                    e.Jugadores.Add(j);

                }
            }
            return agregado;
        }
        public static bool operator -(Jugador j, Equipo e)
        {
            bool borrado = false;
            if (j==e)
            {
                e.Jugadores.Remove(j);
                borrado = true;
            }
            return borrado;
        }
        public bool ExisteCapitan()
        {
            bool existe = false;
            foreach (var j in Jugadores)
            {
                if (j.EsCapitan)
                {
                    existe = true;
                }
            } 
            return existe;
        }

        public static implicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"**{e.Nombre}**");
            sb.AppendLine($"Nomina Jugadores:");
            foreach (var j in e.Jugadores)
            {
                sb.AppendLine($"{j.FichaTecnica()}");
            }
            sb.AppendLine($"{e.directorTecnico.FichaTecnica()}");

            return sb.ToString();
        }
    }
}
