using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Libreria.Entidades
{
    public class Cliente
    {
        int _idCliente;
        string _nombreCliente;
        string _domicilioCliente;
        int _telCliente;

        public int IdCliente
        {
            get
            {
                return _idCliente;
            }
            set
            {
                value = _idCliente;
            }
        }

        public string NombreCliente
        {
            get
            {
                return _nombreCliente;
            }
            set
            {
                value = _nombreCliente;
            }
        }

        public string DomicilioCLiente
        {
            get
            {
                return _domicilioCliente;
            }
            set
            {
                value = _domicilioCliente;
            }
        }
        public int TelCliente
        {
            get
            {
                return _telCliente;
            }
            set
            {
                value = _telCliente;
            }
        }

    }
}
