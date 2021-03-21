using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Libreria.Entidades
{
    public class Insumo
    {
        public int IdIns { private set; get; }
        public string NombreIns { private set; get; }
        public string MarcaIns { private set; get; }
        public string PresentacionIns { private set; get; }
        public string VencimIns { private set; get; }

        private string fechaAltaIns;
        public string FechaAltaIns
        {
            get
            {
                return this.fechaAltaIns;
            }
            set
            {
                this.fechaAltaIns = value;
            }
        }

    }
}
