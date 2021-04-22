using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Libreria.Entidades
{
    public class PacienteYCliente
    {
        Paciente _paciente;
        Cliente _cliente;

        public Paciente Paciente { get => _paciente; set => _paciente = value; }
        public Cliente Cliente { get => _cliente; set => _cliente = value; }
    }
}
