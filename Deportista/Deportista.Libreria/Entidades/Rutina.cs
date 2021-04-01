using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deportista.Libreria.Entidades
{
    public class Rutina
    {
        string _nombreRutina;
        string _descripRutina;
        int _repeticionesRutina;
        int _duracionRutinaMinutos;
       
        public string NombreRutina
        {
            get
            {
                return _nombreRutina;
            }
            set
            {
                _nombreRutina = value;
            }
        }
        public string DescripRutina
        {
            get
            {
                return _descripRutina;
            }
            set
            {
                _descripRutina = value;
            }
        }
        public int RepeticionesRutina
        {
            get
            {
                return _repeticionesRutina;
            }
            set
            {
                _repeticionesRutina = value;
            }
        }
        public int DuracionRutinaMinutos
        {
            get
            {
                return _duracionRutinaMinutos;
            }
            set
            {
                _duracionRutinaMinutos = value;
            }
        }

        public Rutina(string nombreRutina, string descripRutina, int repeticionesRutina, int duracionRutinaMinutos)
        {
            NombreRutina = nombreRutina;
            DescripRutina = descripRutina;
            RepeticionesRutina = repeticionesRutina;
            DuracionRutinaMinutos = duracionRutinaMinutos;
        }
    }
}
