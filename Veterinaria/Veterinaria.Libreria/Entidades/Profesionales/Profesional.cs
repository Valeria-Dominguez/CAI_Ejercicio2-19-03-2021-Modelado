using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Libreria.Entidades
{
    public class Profesional
    {
        public int IdProf { private set; get;}
        public string NombreProf { set; get; }
        public int NumMatriculaProf { private set; get; }
        public int CuitProf { private set; get; }
        public string DomicilioProf { private set; get; }
        public int NumTelProf { private set; get; }
        public string Email { private set; get; }

        private string horarioProf;
        public string HorarioProf
        {
            get
            {
                return this.horarioProf;
            }
            set
            {
                this.horarioProf = value;
            }
        }              
        
    }
}
