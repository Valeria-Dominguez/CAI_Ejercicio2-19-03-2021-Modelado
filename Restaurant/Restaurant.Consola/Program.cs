using Restaurant.Libreria.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Carta unaCarta = new Carta();
            Insumo unInsumo = new Insumo();
            unInsumo.IdInsumo = 1234;
            unInsumo.NombreInsumo = "El insumo";
            Console.WriteLine(unInsumo.NombreInsumo);
        }
    }
}
