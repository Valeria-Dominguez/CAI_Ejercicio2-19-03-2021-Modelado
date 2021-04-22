﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria.Libreria.Entidades;
using Veterinaria.Libreria.Validaciones;
using Veterinaria.Libreria.Exceptions;

namespace Veterinaria.Consola
{
    static class Program
    {
        static SucVeterinaria unaSucVeterinaria;
        static void Main(string[] args)
        {            
            unaSucVeterinaria = new SucVeterinaria("Suc.Nombre","Domicilio", "Telefono", "Nombre Encargado");
            MenuPcipal();

            void MenuPcipal()
            {
                string option = "";
                const string opAltasBajas = "1";
                const string opAgregarVisita = "2";
                const string opListarHistoria = "3";
                const string opListarClientes = "4";
                const string opSalir = "5";
                do
                {
                    option = Validaciones.ValidarStrNoVac("Ingrese una opción\n" 
                        + opAltasBajas + ".Altas/Bajas\n"
                        + opAgregarVisita + ".Agregar visita\n"
                        + opListarHistoria + ".Listar historia clínica paciente\n"
                        + opListarClientes + ".Listar clientes\n"
                        + opSalir + ".Salir\n"
                        );
                    switch(option)
                    {
                        case opAltasBajas:
                            MenuAltasBajas();
                            break;
                        case opAgregarVisita:
                            AgregarVisita(unaSucVeterinaria);
                            break;
                        case opListarHistoria:
                            ListarHistoria(unaSucVeterinaria);
                            break;
                        case opListarClientes:
                            Console.WriteLine(unaSucVeterinaria.ListarClientes());
                            break;
                        case opSalir:
                            break;
                        default:
                            Console.WriteLine("Debe ingresar una opción válida\n");
                            break;
                    }
                }
                while (option != opSalir);
            }
        }
        static void MenuAltasBajas()
        {
            string option = "";
            const string opAltaCliente = "1";
            const string opAltaPaciente = "2";
            const string opBajaPaciente = "3";
            option = Validaciones.ValidarStrNoVac("Ingrese una opción\n"
                    + opAltaCliente + ".Alta cliente\n"
                    + opAltaPaciente + ".Alta paciente\n"
                    + opBajaPaciente + ".Baja paciente\n"
                    );
            switch (option)
            {
                case opAltaCliente:
                    DarAltaCliente(unaSucVeterinaria);
                    break;
                case opAltaPaciente:
                    DarAltaPaciente(unaSucVeterinaria);
                    break;
                case opBajaPaciente:
                    DarBajaPaciente(unaSucVeterinaria);
                    break;
                default:
                    break;
            }
        }
        static void AgregarVisita(SucVeterinaria sucVeterinaria)
        {
            if (sucVeterinaria.GetSinPacientesIngresados() == true)
            {
                Console.WriteLine("No hay pacientes ingresados\n");
            }
            else
            {
                string idPaciente;
                idPaciente = Validaciones.ValidarStrNoVac("Ingrese código de paciente\n");
                if (sucVeterinaria.BuscarIdPacienteTodosClientesDevuelveBool(idPaciente) == false)
                {
                    Console.WriteLine("El paciente no existe\n");
                }
                else
                {
                    string fechaVisita;
                    string motivoConsulta;
                    string diagnostico;
                    string prescripciones;
                    string observaciones;
                    string nombreProfesional;
                    fechaVisita = Validaciones.ValidarStrNoVac("Ingrese fecha de visita\n");
                    motivoConsulta = Validaciones.ValidarStrNoVac("Ingrese motivo consulta\n");
                    diagnostico = Validaciones.ValidarStrNoVac("Ingrese diagnóstico\n");
                    prescripciones = Validaciones.ValidarStrNoVac("Ingrese prescripciones\n");
                    observaciones = Validaciones.ValidarStrNoVac("Ingrese observaciones\n");
                    nombreProfesional = Validaciones.ValidarStrNoVac("Ingrese nombre del profesional\n");
                    sucVeterinaria.AgregarVisita(idPaciente, fechaVisita, motivoConsulta, diagnostico, prescripciones, observaciones, nombreProfesional);
                    Console.WriteLine("Visita agregada");
                }
            }            
        }

        static void ListarHistoria(SucVeterinaria sucVeterinaria)
        {
            if (sucVeterinaria.GetSinPacientesIngresados()==true)
            {
                Console.WriteLine("No hay pacientes ingresados\n");
            }
            else
            {
                string idPaciente;
                idPaciente = Validaciones.ValidarStrNoVac("Ingrese código de paciente\n");
                Console.WriteLine(sucVeterinaria.BuscarHistoria(idPaciente));
            }          
        }
        static void DarAltaCliente(SucVeterinaria sucVeterinaria)
        {
            string idCliente;
            idCliente = Validaciones.ValidarStrNoVac("Ingrese código de cliente\n");            
            bool clienteEncontrado;
            clienteEncontrado = sucVeterinaria.BuscarIdClienteDevuelveBool(idCliente);
            if (clienteEncontrado!=false)
            {
                Console.WriteLine("El cliente ya existe\n");
            }
            else
            {
                string nombre;
                string domicilio;
                string numeroTel;
                string email;
                nombre = Validaciones.ValidarStrNoVac("Ingrese nombre del cliente\n");
                domicilio = Validaciones.ValidarStrNoVac("Ingrese domicilio del cliente\n");
                numeroTel = Validaciones.ValidarStrNoVac("Ingrese numero de teléfono del cliente\n");
                email = Validaciones.ValidarStrNoVac("Ingrese email del cliente\n");
                sucVeterinaria.AgregarCliente(idCliente, nombre, domicilio, numeroTel, email);
                Console.WriteLine("Alta exitosa\n");
            }           

        }
        static void DarAltaPaciente(SucVeterinaria sucVeterinaria)
        {
            string idCliente;
            idCliente = Validaciones.ValidarStrNoVac("Ingrese código de cliente\n");
            bool clienteEncontrado;
            clienteEncontrado = sucVeterinaria.BuscarIdClienteDevuelveBool(idCliente);
            if (clienteEncontrado == false)
            {
                Console.WriteLine("El cliente no existe\n");
            }
            else
            {
                string idPaciente;
                idPaciente = Validaciones.ValidarStrNoVac("Ingrese código de paciente\n");
                bool pacienteEncontrado;
                pacienteEncontrado = sucVeterinaria.BuscarIdPacienteTodosClientesDevuelveBool(idPaciente);
                if (pacienteEncontrado != false)
                {
                    Console.WriteLine("El paciente ya existe\n");
                }
                else
                {
                    string nombre;
                    string fechaNacimiento;
                    int peso;
                    nombre = Validaciones.ValidarStrNoVac("Ingrese nombre del paciente\n");
                    fechaNacimiento = Validaciones.ValidarStrNoVac("Ingrese fecha de nacimineto del paciente\n");
                    peso = (int)Validaciones.ValidarUint("Ingrese peso del paciente\n");
                    sucVeterinaria.AgregarPaciente(idCliente, idPaciente, nombre, fechaNacimiento, peso);
                    Console.WriteLine("Alta exitosa\n");
                }
            }
        }
        static void DarBajaPaciente(SucVeterinaria sucVeterinaria)
        {
            string idPaciente;
            idPaciente = Validaciones.ValidarStrNoVac("Ingrese código de paciente\n");
            Console.WriteLine(sucVeterinaria.EliminarPaciente(idPaciente));
        }
    }
}
