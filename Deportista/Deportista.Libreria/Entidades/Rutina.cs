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
                value = _nombreRutina;
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
                value = _descripRutina;
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
                value = _repeticionesRutina;
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
                value = _duracionRutinaMinutos;
            }
        }
    }
}
