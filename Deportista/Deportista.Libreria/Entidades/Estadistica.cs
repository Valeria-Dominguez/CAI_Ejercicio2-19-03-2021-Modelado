using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deportista.Libreria.Entidades
{
    public class Estadistica
    {
        int _numeroSesion;
        int _duracionSesion;
        int _cantSesionesAcum;
        int _duracionSesionesAcum;
        
        public int NumeroSesion
        {
            get
            {
                return _numeroSesion;
            }
            set
            {
                value = _numeroSesion;
            }
        }
        public int DuracionSesion
        {
            get
            {
                return _duracionSesion;
            }
            set
            {
                value = _duracionSesion;
            }
        }
        public int CantSesionesACum
        {
            get
            {
                return _cantSesionesAcum;
            }
            set
            {
                value = _cantSesionesAcum;
            }
        }
        public int DuracionSesionesAcum
        {
            get
            {
                return _duracionSesionesAcum;
            }
            set
            {
                value = _duracionSesionesAcum;
            }
        }
    }
}
