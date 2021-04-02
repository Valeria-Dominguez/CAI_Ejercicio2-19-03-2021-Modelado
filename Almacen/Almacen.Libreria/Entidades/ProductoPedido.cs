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
                _idProducto = value;
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
                _nombreProducto = value;
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
                _cantProducto = value;
            }
        }

        public ProductoPedido (int idProducto, string nombreProducto, int cantProducto)
        {
            IdProducto = idProducto;
            NombreProducto = nombreProducto;
            CantProducto = cantProducto;
        }
    }
}
