using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Libreria.Entidades
{
    class Plato : ComponentCarta
    {   
        const int cantMaxIngredPlato = 10;
        public IngredientePlato[] IngredientesPlato { private set; get; } = new IngredientePlato[cantMaxIngredPlato];       
    }
}
