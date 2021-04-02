using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carta.Libreria.Entidades;

namespace Carta.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Mazo MazoUnJuego = new Mazo(3);
            MazoUnJuego.AgregarCarta(0, 1, "espada");
            MazoUnJuego.AgregarCarta(1, 2, "espada");


            Console.ReadKey();

        }
    }
}
