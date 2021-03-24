using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Libreria.Entidades
{
    class BebidaPreparada : Bebida
    {
        const int cantMaxIngredBebida = 10;
        public IngredienteBebida[] IngredientesBebida { private set; get; } = new IngredienteBebida[cantMaxIngredBebida];
    }

}
  

