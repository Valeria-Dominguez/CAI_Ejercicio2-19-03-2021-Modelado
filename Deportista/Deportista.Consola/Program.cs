using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deportista.Libreria.Entidades;

namespace Deportista.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Deportist unDeportista = new Deportist("Maria Suarez");
            
            unDeportista.AgregarRutina("GAP", "Frog Pump/Sentadilla/Reverse nordic curl/Lunge/Kneeling get up", 3, 5);
            unDeportista.BuscarRutina("GAP");
            unDeportista.BuscarRutina("BLA");
            Console.ReadKey();
        }
    }
}
