using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Libreria.Entidades
{
    public class Cliente
    {
        const int cantMaxPedidos = 3;
        int _idCliente;
        string _nombreCliente;
        string _domicilioCliente;
        int _telCliente;
        Pedido[] _pedidos;

        public int IdCliente
        {
            get
            {
                return _idCliente;
            }
            set
            {
                _idCliente = value;
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
                _nombreCliente = value;
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
                _domicilioCliente = value;
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
                _telCliente = value;
            }
        }
        public Pedido[] Pedidos
        {
            get
            {
                return _pedidos;
            }
            set
            {
                _pedidos = value;
            }
        }

        public Cliente (int idCliente, string nombreCliente, string domicilioCliente, int telCliente)
        {
            IdCliente = idCliente;
            NombreCliente = nombreCliente;
            DomicilioCLiente = domicilioCliente;
            TelCliente = telCliente;
            Pedidos = new Pedido[cantMaxPedidos];
            for(int cont = 0; cont <= this.Pedidos.GetUpperBound(0); cont++)
            {
                Pedidos[cont] = new Pedido(0, "", "");
            }
        }

        public void CambiarEstadoPedido(int posicionPedido)
        {
            if (this.Pedidos[posicionPedido].PedidoEntregado == false)
            {
                this.Pedidos[posicionPedido].PedidoEntregado = true;
                Console.WriteLine("La entrega del pedido ha sido registrada\n");
            }
            else
            {
                Console.WriteLine("La entrega del pedido ya fue registrada anteriormente\n");
            }
        }
    }
}
