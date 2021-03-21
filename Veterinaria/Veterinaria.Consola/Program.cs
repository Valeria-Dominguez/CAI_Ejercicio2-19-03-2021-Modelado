using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.Libreria.Entidades;

namespace Veterinaria.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Profesional unProfesional = new Profesional();
            Insumo unInsumo = new Insumo ();
            Paciente UnPaciente = new Paciente();
            Turno UnTurno = new Turno();

            unProfesional.NombreProf = "Jose López";
            Console.WriteLine(unProfesional.NombreProf);

        }
    }
}
