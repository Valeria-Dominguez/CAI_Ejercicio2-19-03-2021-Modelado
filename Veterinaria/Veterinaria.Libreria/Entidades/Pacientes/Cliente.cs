using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Libreria.Entidades
{
    public class Cliente
    {
        string _idCliente;
        string _nombre;
        string _domicilio;
        string _numeroTel;
        string _email;
        List<Paciente> _mascotas;

        internal string IdCliente { get => _idCliente; }
        internal List<Paciente> Mascotas { get => _mascotas; }

        internal Cliente (string idCliente, string nombre, string domicilio, string numeroTel, string email)
        {
            this._idCliente = idCliente;
            this._nombre = nombre;
            this._domicilio = domicilio;
            this._numeroTel = numeroTel;
            this._email = email;
            this._mascotas = new List<Paciente>();
        }

        public void GuardarPaciente(Paciente paciente)
        {
            this._mascotas.Add(paciente);
        }

        internal void EliminarPaciente (Paciente paciente)
        {
            this._mascotas.Remove(paciente);
        }
        
        internal string ListarCliente()
        {
            string valor = "";
            valor = $"Nombre: {_nombre}\n Domicilio: {_domicilio}\n Teléfono: {_numeroTel}\n Email: {_email}\n Mascotas:\n ";

            string mascotas = "";
            if (this._mascotas.Count==0)
            {
                mascotas = "No hay mascotas ingresadas\n";
            }
            else
            {
                mascotas = ListarMascotas();
            }
            
            valor = valor + mascotas;
            return valor.ToString();
        }

        private string ListarMascotas()
        {
            string valor = "";
            foreach(Paciente mascota in this._mascotas)
            {
                valor = valor + $"{mascota.Nombre}\n";
            }
            return valor;
        }

        public Paciente BuscarIdPacienteEnClienteDevuelvePaciente(string idPaciente)
        {
            Paciente valor = null;
            foreach (Paciente paciente in this._mascotas)
            {
                if (paciente.IdPaciente == idPaciente)
                {
                    valor = paciente;
                }
            }
            return valor;
        }

        public bool BuscarIdPacienteEnClienteDevuelveBool(string idPaciente)
        {
            bool valor = false;
            foreach (Paciente paciente in this._mascotas)
            {
                if (paciente.IdPaciente==idPaciente)
                {
                    valor = true;
                }
            }
            return valor;
        }
    }
}
