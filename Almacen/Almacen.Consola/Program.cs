using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Almacen.Libreria.Entidades;

namespace Almacen.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente unCliente = new Cliente(1, "Pedro García", "Calle 1 1234", 1512345678);
            unCliente.Pedidos[0]= new Pedido(1, "31/03/2021", "02/02/2021");            
            unCliente.Pedidos[0].ProductosPedido[0] = new ProductoPedido(1, "Mayonesa Natura 250 gms.", 1);
            unCliente.CambiarEstadoPedido(0);
            unCliente.CambiarEstadoPedido(0);
            Console.ReadKey();

        }
    }
}
