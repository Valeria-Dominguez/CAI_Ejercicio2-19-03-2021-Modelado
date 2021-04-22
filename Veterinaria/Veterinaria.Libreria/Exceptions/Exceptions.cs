using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Libreria.Exceptions
{
    public class SinPacientesIngresadosException : Exception
    {
        public SinPacientesIngresadosException (string message): base (message)
        {

        }
        public SinPacientesIngresadosException(): base ("No hay pacientes ingresados\n")
        {

        }
    }

    public class ElPacienteNoExisteException : Exception
    {
        public ElPacienteNoExisteException (string message) : base (message)
        {

        }
        public ElPacienteNoExisteException (): base ("El paciente no existe\n")
        {

        }
    }
    
}
