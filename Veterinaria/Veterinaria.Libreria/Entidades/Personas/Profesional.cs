using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Libreria.Entidades
{
    class Profesional : Persona
    {
        public Profesional(string id, string nombre, string domicilio, string numeroTel, string email) : base(id, nombre, domicilio, numeroTel, email)
        {
            
        }
    }
}
