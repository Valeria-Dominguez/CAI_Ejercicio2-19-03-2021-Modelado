using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Libreria.Entidades
{
    public class Pedido
    {
        const int cantMaxProductos = 3;
        bool _pedidoEntregado;
        int _idPEdido;
        string _fechaPedido;
        string _fechaEntregaPedido;
        ProductoPedido[] _productosPedido;
        public bool PedidoEntregado
        {
            get
            {
                return _pedidoEntregado ;
            }
            set
            {
                _pedidoEntregado = value;
            }
        }
        public int IdPedido
        {
            get
            {
                return _idPEdido;
            }
            set
            {
                _idPEdido = value;
            }
        }
        public string FechaPedido
        {
            get
            {
                return _fechaPedido;
            }
            set
            {
                _fechaPedido = value;
            }
        }
        public string FechaEntregaPedido
        {
            get
            {
                return _fechaEntregaPedido;
            }
            set
            {
                _fechaEntregaPedido = value;
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
                _productosPedido = value;
            }
        }

        public Pedido (int idPedido, string fechaPedido, string fechaEntregaPedido)
        {
            IdPedido = idPedido;
            FechaPedido = fechaPedido;
            FechaEntregaPedido = fechaEntregaPedido;
            PedidoEntregado = false;
            ProductosPedido = new ProductoPedido[cantMaxProductos];
            for (int cont = 0; cont <= this.ProductosPedido.GetUpperBound(0); cont++)
            {
                ProductosPedido[cont] = new ProductoPedido(0, "", 0);
            }
        }
    }
}
