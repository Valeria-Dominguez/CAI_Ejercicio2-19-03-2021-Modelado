using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Libreria.Entidades
{
    public class Paciente
    {
        public int IdPaci { private set; get; }
        public string NombrePaci { private set; get; }
        public string EspeciePaci { private set; get; }
        public string EdadPaci { private set; get; }
        public string NombreDueño { private set; get; }
        const int cantMaxVisitas = 200;
        public Visita[] Visitas { private set; get; }
        const int cantMaxAntecedentes = 50;
        public string[] AntecedentesPaci { private set; get; } = new string[cantMaxAntecedentes];

       

        



    }
}
