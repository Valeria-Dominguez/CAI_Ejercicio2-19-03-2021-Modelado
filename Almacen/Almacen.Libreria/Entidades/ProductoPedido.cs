using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.Libreria.Entidades
{
    public class ProductoPedido
    {
        int _idProducto;
        string _nombreProducto;
        int _cantProducto;
        
        public int IdProducto
        {
            get
            {
                return _idProducto;
            }
            set
            {
                value = _idProducto;
            }
        }
        public string NombreProducto
        {
            get
            {
                return _nombreProducto;
            }
            set
            {
                value = _nombreProducto;
            }
        }
        public int CantProducto
        {
            get
            {
                return _cantProducto;
            }
            set
            {
                value = _cantProducto;
            }
        }
    }
}
