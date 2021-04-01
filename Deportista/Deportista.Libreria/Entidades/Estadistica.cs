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
                _numeroSesion = value;
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
                _duracionSesion = value;
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
                _cantSesionesAcum = value;
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
                _duracionSesionesAcum = value;
            }
        }

        public Estadistica(int numeroSesion, int duracionSesion, int cantSesionesAcum, int duracionSesionesAcum)
        {
            NumeroSesion = numeroSesion;
            DuracionSesion = duracionSesion;
            CantSesionesACum = cantSesionesAcum;
            DuracionSesionesAcum = duracionSesionesAcum;
        }
    }
}
