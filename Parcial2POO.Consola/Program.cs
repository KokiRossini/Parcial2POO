using Parcial2POO.Entidades.Entidades;
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
            DirectorTecnico d1 = new DirectorTecnico("Rossini", "Juan Ignacio");

            Equipo e1 = new Equipo("Defensores", d1, Deporte.Futbol);

            Jugador j1 = new Jugador("Alvez", "Emanuel", 2, false);
            Jugador j2 = new Jugador("Taricco", "Baltazar", 9, false);
            Jugador j3 = new Jugador("Agustin", "Borthiry", 3, false);
            Jugador j4 = new Jugador("Abrigatto", "Luis", 10, true);

            string datosE1;

            datosE1 = e1;
            Console.WriteLine(datosE1);

            Console.Read();


        }
    }
}
