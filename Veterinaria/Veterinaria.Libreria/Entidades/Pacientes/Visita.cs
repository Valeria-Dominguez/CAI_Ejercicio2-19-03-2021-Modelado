using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Libreria.Entidades
{
    public class Visita
    {
        public string FechaVisita { private set; get; }
        public string MotivoConsulta { private set; get; }
        public string Diagnostico { private set; get; }
        public string Prescripciones { private set; get; }
        public string Observaciones { private set; get; }
        public string NombreProfesional { private set; get; }        
    }
}
