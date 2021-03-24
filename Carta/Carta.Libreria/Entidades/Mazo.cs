using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carta.Libreria.Entidades
{
    public class Mazo
    {        
        private const int cantCartas = 40;
        public Carta[] MazoUnJuego { set; get; } = new Carta[cantCartas];

    }
}
