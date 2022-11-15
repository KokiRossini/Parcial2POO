using Parcial2POO.Datos;
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
            Jugador j5 = new Jugador("Alvez", "Emanuel", 2, false);



            if (j1+e1)
            {
                Console.WriteLine("Jugador agregado");
            }
            else
            {
                Console.WriteLine("Jugador no agregado ERROR!!!");
            }
            if (j2 + e1)
            {
                Console.WriteLine("Jugador agregado");
            }
            else
            {
                Console.WriteLine("Jugador no agregado ERROR!!!");
            }
            if (j3 + e1)
            {
                Console.WriteLine("Jugador agregado");
            }
            else
            {
                Console.WriteLine("Jugador no agregado ERROR!!!");
            }
            if (j4 + e1)
            {
                Console.WriteLine("Jugador agregado");
            }
            else
            {
                Console.WriteLine("Jugador no agregado ERROR!!!");
            }
            if (j1 + e1)
            {
                Console.WriteLine("Jugador agregado");
            }
            else
            {
                Console.WriteLine("Jugador no agregado ERROR!!!");
            }

            List<Equipo> listaEquipos = new List<Equipo>();
            listaEquipos.Add(e1);
            Serializador<List<Equipo>>.GuardarJson("equipos.json", listaEquipos);

            //List<Equipo> listaEquiposdesc = new List<Equipo>();
            //listaEquiposdesc = Serializador<List<Equipo>>.LeerJson("equipos.json");



            List<Jugador> lista = new List<Jugador>();
            lista.Add(j1);
            lista.Add(j2);
            lista.Add(j3);
            lista.Add(j4);

            Serializador<List<Jugador>>.GuardarJson("jugadores.json", lista);


            //if (j1==j2)
            //{
            //    Console.WriteLine("Son iguales");
            //}
            //else
            //{
            //    Console.WriteLine("Son diferentes");
            //}

            //if (j1 == j5)
            //{
            //    Console.WriteLine("Son iguales");
            //}
            //else
            //{
            //    Console.WriteLine("Son diferentes");
            //}




            string datosE1;

            datosE1 = e1;
            Console.WriteLine(datosE1);

            Console.Read();


        }
    }
}
