
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Libreria.Entidades
{
    public class BienDeUso
    {
        public int IdBienDeUso { private set; get; }
        public string NombreBienDeUso { private set; get; }
        public string CategoriaBienDeUso { private set; get; }
        public string DescripcionBienDeUso { private set; get; }
        public int CantidadBienDeUso { private set; get; }
        public string FechaAltaBienDeUso { private set; get; }
        public string FechaBajaBienDeUso { private set; get; }
        public int VidaUtilBienDeUso { private set; get; }
        public double CostoBienDeUso { private set; get; }
    }
}
