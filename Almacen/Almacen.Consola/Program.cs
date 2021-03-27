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
            Cliente unCliente = new Cliente();
            unCliente.NombreCliente = "Pedro Garcia";
            Pedido unPedido = new Pedido();
        }
    }
}
