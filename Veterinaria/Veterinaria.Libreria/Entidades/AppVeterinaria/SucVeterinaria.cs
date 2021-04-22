using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Libreria.Entidades
{
    public class SucVeterinaria
    {
        string _nombre;
        string _domicilio;
        string _telefono;
        string _encargado;
        List<Cliente> _clientes;

        public SucVeterinaria(string nombre, string domicilio, string telefono, string encargado)
        {
            this._nombre = nombre;
            this._domicilio = domicilio;
            this._telefono = telefono;
            this._encargado = encargado;
            this._clientes = new List<Cliente>();
        }

        public void AgregarCliente(string idCliente, string nombre, string domicilio, string numeroTel, string email)
        {
            Cliente cliente = new Cliente(idCliente, nombre, domicilio, numeroTel, email);
            GuardarCliente(cliente);
            
        }

        void GuardarCliente(Cliente cliente)
        {
            this._clientes.Add(cliente);
        }

        public string BuscarHistoria (string idPaciente)
        {
            string valor = "";
            if (_clientes.Count == 0)
            {
                valor = "No hay pacientes ingresados\n";
            }
            else
            {
                PacienteYCliente pacienteYCliente = null;
                pacienteYCliente = BuscarIdPacienteDevuelvePacienteyCliente(idPaciente);
                if (pacienteYCliente == null)
                {
                    valor = "El paciente no existe";
                }
                else
                {
                    valor = pacienteYCliente.Paciente.ListarHistoria();
                }

            }
            return valor;
        }

        public void AgregarPaciente(string idCliente, string idPaciente, string nombre, string fechaNacimiento, int peso)
        {
            Paciente paciente = new Paciente(idPaciente, nombre, fechaNacimiento, peso);

            Cliente cliente = null;
            cliente = BuscarIdClienteDevuelveCliente(idCliente);
            if (cliente != null)
            {
                cliente.GuardarPaciente(paciente);
            }
        }

        public string EliminarPaciente(string idPaciente)
        {
            string valor = "";
            PacienteYCliente pacienteYCliente = null;
            pacienteYCliente = BuscarIdPacienteDevuelvePacienteyCliente(idPaciente);

            if (pacienteYCliente ==null)
            {
                valor = "El paciente no existe\n";
            }
            else
            {
                pacienteYCliente.Cliente.EliminarPaciente(pacienteYCliente.Paciente);
                valor = "Paciente eliminado\n";
            }
            return valor;
        }
        
        public string ListarClientes()
        {
            string valor = "";
            if (_clientes.Count==0)
            {
                valor = "No hay clientes ingresados\n";
            }
            else
            {
                foreach (Cliente cliente in this._clientes)
                {
                    valor = valor + cliente.ListarCliente();
                }
            }
            return valor;
        }

        public void AgregarVisita(string idPaciente, string fechaVisita, string motivoConsulta, string diagnostico, string prescripciones, string observaciones, string nombreProfesional)
        {
            Visita visita = new Visita(fechaVisita, motivoConsulta, diagnostico, prescripciones, observaciones, nombreProfesional);

            PacienteYCliente pacienteYCliente = null;
            pacienteYCliente = BuscarIdPacienteDevuelvePacienteyCliente(idPaciente);
            if (pacienteYCliente != null)
            {
                pacienteYCliente.Paciente.GuardarVisita(visita);
            }
        }

        public Cliente BuscarIdClienteDevuelveCliente(string idCliente)
        {
            Cliente valor = null;
            foreach (Cliente cliente in this._clientes)
            {
                if (cliente.IdCliente == idCliente)
                {
                    valor = cliente;
                }
            }
            return valor;
        }

        public bool BuscarIdClienteDevuelveBool(string idCliente)
        {
            bool valor = false;
            foreach (Cliente cliente in this._clientes)
            {
                if (cliente.IdCliente == idCliente)
                {
                    valor = true;
                }
            }
            return valor;
        }

        public bool BuscarIdPacienteTodosClientesDevuelveBool(string idPaciente)
        {
            bool valor = false;
            foreach (Cliente cliente in this._clientes)
            {
                bool existepaciente = cliente.BuscarIdPacienteEnClienteDevuelveBool(idPaciente);
                if(existepaciente == true)
                {
                    valor = existepaciente;
                }
            }
            return valor;            
        }
        
        public PacienteYCliente BuscarIdPacienteDevuelvePacienteyCliente (string idPaciente)
        {
            Paciente pacienteEncontrado = null;
            Cliente clienteEncontrado = null;
            foreach (Cliente cliente in this._clientes)
            {
                Paciente paciente = cliente.BuscarIdPacienteEnClienteDevuelvePaciente(idPaciente);
                if (paciente != null)
                {
                    pacienteEncontrado = paciente;
                    clienteEncontrado = cliente;
                }
            }
            PacienteYCliente valor = null;
            if (pacienteEncontrado!=null && clienteEncontrado!=null)
            {
                valor = new PacienteYCliente();
                valor.Paciente = pacienteEncontrado;
                valor.Cliente = clienteEncontrado;
            }
            return valor;
        }

        public bool GetSinPacientesIngresados()
        {
            bool valor = true;
            foreach (Cliente cliente in this._clientes)
            {
                if (cliente.Mascotas.Count != 0)
                {
                    valor = false;
                }
            }
            return valor;
        }

    }
}
