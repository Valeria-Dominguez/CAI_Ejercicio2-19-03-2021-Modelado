using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Libreria.Entidades
{
    public class Visita
    {
        string _fechaVisita;
        string _motivoConsulta;
        string _diagnostico;
        string _prescripciones;
        string _observaciones;
        string _nombreProfesional;

        internal Visita (string fechaVisita, string motivoConsulta, string diagnostico, string prescripciones, string observaciones, string nombreProfesional)
        {
            this._fechaVisita = fechaVisita;
            this._motivoConsulta = motivoConsulta;
            this._diagnostico = diagnostico;
            this._prescripciones = prescripciones;
            this._observaciones = observaciones;
            this._nombreProfesional = nombreProfesional;
        }

        internal string ListarVisita()
        {
            string valor = "";
            valor = "Fecha: " + this._fechaVisita
                + "\nMotivo consulta: " + this._motivoConsulta
                + "\nDiagnóstico: " + this._diagnostico
                + "\nPrescripciones: " + this._prescripciones
                + "\nObservaciones: " + this._observaciones
                + "\nProfesional: " + this._nombreProfesional
                ;
            return valor;
        }
      
    }
}
