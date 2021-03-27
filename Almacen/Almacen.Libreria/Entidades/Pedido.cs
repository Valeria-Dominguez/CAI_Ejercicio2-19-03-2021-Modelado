using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Libreria.Entidades
{
    public class Pedido
    {
        const int cantMaxProductos = 100;
        bool _estadoPedido;
        DateTime _fechaPedido;
        DateTime _fechaEntregaPedido;
        string _nombreCliente;
        ProductoPedido[] _productosPedido;
        public bool EstadoPedido
        {
            get
            {
                return _estadoPedido;
            }
            set
            {
                value = _estadoPedido;
            }
        }
        public DateTime FechaPedido
        {
            get
            {
                return _fechaPedido;
            }
            set
            {
                value = _fechaPedido;
            }
        }
        public DateTime FechaEntregaPedido
        {
            get
            {
                return _fechaEntregaPedido;
            }
            set
            {
                value = _fechaEntregaPedido;
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
        public ProductoPedido[] ProductosPedido
        {
            get
            {
                return _productosPedido;
            }
            set
            {
                value = _productosPedido;
            }
        }
    }
}
