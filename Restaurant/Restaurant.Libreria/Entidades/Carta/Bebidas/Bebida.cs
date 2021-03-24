using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Libreria.Entidades
{
    class Bebida : ComponentCarta
    {       
        public float Medida { private set; get; }
        public bool Alcohol { private set; get; }
        public bool Preparado { private set; get; }

    }
}
