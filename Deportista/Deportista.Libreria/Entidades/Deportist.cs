using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deportista.Libreria.Entidades
{
    public class Deportist
    {
        string _nombreDeportista;
        Rutina[] _rutinaSemanal;
        Estadistica[] _estadisticas;

        public string NombreDeportista
        {
            get
            {
                return _nombreDeportista;
            }
            set
            {
                value = _nombreDeportista;
            }
        }
        public Rutina [] RutinaSemanal
        {
            get
            {
                return _rutinaSemanal;
            }
            set
            {
                value = _rutinaSemanal;
            }
        }
        public Estadistica[] Estadisticas
        {
            get
            {
                return _estadisticas;
            }
            set
            {
                value = _estadisticas;
            }
        }




    }
}
