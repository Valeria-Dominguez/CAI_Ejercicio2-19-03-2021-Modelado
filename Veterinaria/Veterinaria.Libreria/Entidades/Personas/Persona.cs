using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Libreria.Entidades
{
    public class Persona
    {
        string _id;
        string _nombre;
        string _domicilio;
        string _numeroTel;
        string _email;

        public string Id { get => _id; }

        public Persona(string id, string nombre, string domicilio, string numeroTel, string email)
        {
            _id = id;
            _nombre = nombre;
            _domicilio = domicilio;
            _email = email;
            _numeroTel = numeroTel;
        }
        public string ListarPersona()
        {
            string valor = "";
            valor = $"Id: {_id}\n Nombre: {_nombre}\n Domicilio: {_domicilio}\n Teléfono: {_numeroTel}\n Email: {_email}\n\n";
            return valor.ToString();
        }
    }
}
