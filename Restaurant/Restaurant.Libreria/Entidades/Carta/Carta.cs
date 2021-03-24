using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Libreria.Entidades
{
    public class Carta
    {
        const int cantMaxComponCarta = 500;
        public ComponentCarta[] ComponentesCarta { private set; get; } = new ComponentCarta[cantMaxComponCarta];              
    }
}
