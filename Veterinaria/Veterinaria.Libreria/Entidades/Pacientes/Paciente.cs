using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.Libreria.Entidades
{
    public class Paciente
    {
        string _idPaciente;
        string _nombre;
        string _fechaNacimiento;
        int _peso;
        List<Visita> _visitas;

        public string IdPaciente { get => _idPaciente; }
        public string Nombre { get => _nombre; }

        internal Paciente(string idPaciente, string nombre, string fechaNacimiento, int peso)
        {
            this._idPaciente = idPaciente;
            this._nombre = nombre;
            this._fechaNacimiento = fechaNacimiento;
            this._peso = peso;
            this._visitas = new List<Visita>();
        }

        public string ListarHistoria()
        {
            string descripcion = "ID: " + _idPaciente
                + "\nNombre: " + _nombre
                + "\nFecha de nacimiento: " + _fechaNacimiento
                + "\n";

            string valor = "";
            if (this._visitas.Count==0)
            {
                valor = "No hay visitas ingresadas\n";
            }
            else
            {
                valor = "Historial de visistas: \n";
                foreach (Visita visita in this._visitas)
                {
                    valor = valor + visita.ListarVisita() + "\n\n";
                }
            }
            valor = descripcion + valor;
            return valor;
        }

        public void GuardarVisita(Visita visita)
        {
            this._visitas.Add(visita);
        }

    }
}
