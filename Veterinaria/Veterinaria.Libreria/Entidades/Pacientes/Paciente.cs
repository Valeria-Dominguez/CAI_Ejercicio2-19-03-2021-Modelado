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

        const int cantMaxAntecedentes = 50;
        public string[] AntecedentesPaci { private set; get; } = new string[cantMaxAntecedentes];

        const int cantMaxVisitas = 200;
        const int cantColumVisitas = 6;
        const int columFechaVisita = 0;
        const int columMotivoConsulta = 1;
        const int columDiagnostico = 2;
        const int columPrescripciones = 3;
        const int columObservaciones = 4;
        const int columProfesional = 5;

        public string[,] VisitasPaci { private set; get; } = new string[cantMaxVisitas,cantColumVisitas];



    }
}
