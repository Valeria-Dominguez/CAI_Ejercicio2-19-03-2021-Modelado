using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deportista.Libreria.Entidades
{
    public class Deportist
    {
        string _nombreDeportista;
        Rutina[] _rutinaSemanal;
        Estadistica[] _estadisticas;
        int _posicionLibreRutina;
        const int _cantMaxRutinas = 3;
        const int _cantMaxEstadisticas = 3;      
        
        public string NombreDeportista
        {
            get
            {
                return _nombreDeportista;
            }
            set
            {
                _nombreDeportista = value;
            }
        }
        public Rutina [] RutinaSemanal
        {
            get
            {
                return _rutinaSemanal;
            }
            set
            {
                _rutinaSemanal = value;
            }
        }
        public Estadistica[] Estadisticas
        {
            get
            {
                return _estadisticas;
            }
            set
            {
                _estadisticas = value;
            }
        }
        public int CantMaxRutinas
        {
            get
            {
                return _cantMaxRutinas;
            }
        }
        public int CantMaxEstadisticas
        {
            get
            {
                return _cantMaxEstadisticas;
            }
        }
        public int PosicionLibreRutina
        {
            get
            {
                return _posicionLibreRutina;
            }
            set
            {
                _posicionLibreRutina = value;
            }
        }

        public Deportist (string nombreDeportista)
        {
            NombreDeportista = nombreDeportista;
            RutinaSemanal = new Rutina[CantMaxRutinas];
            Estadisticas = new Estadistica[CantMaxEstadisticas];
            for (int cont =0; cont <= this.RutinaSemanal.GetUpperBound(0); cont++)
            {
                RutinaSemanal[cont] = new Rutina("", "", 0, 0);
            }
            for (int cont = 0; cont <= this.Estadisticas.GetUpperBound(0); cont++)
            {
                Estadisticas[cont] = new Estadistica(0, 0, 0, 0);
            }
        }

        public void BuscarRutina(string nombreRutina)
        {
            int posicion = 0;
            while (this.RutinaSemanal[posicion].NombreRutina != nombreRutina && posicion < this.RutinaSemanal.GetUpperBound(0))
            {
                posicion++;
            }
            if (this.RutinaSemanal[posicion].NombreRutina == nombreRutina)
            {
                Console.WriteLine("La rutina " + nombreRutina + " ya ha sido ingresada anteriormente:\n"
                + "Nombre rutina: " + this.RutinaSemanal[PosicionLibreRutina - 1].NombreRutina + "\n"
                + "Descripción: " + this.RutinaSemanal[PosicionLibreRutina - 1].DescripRutina + "\n"
                + this.RutinaSemanal[PosicionLibreRutina - 1].RepeticionesRutina + " repeticiones\n"
                + "Duración rutina: " + this.RutinaSemanal[PosicionLibreRutina - 1].DuracionRutinaMinutos + " minutos\n")
                ;
            }
            else
            {
                Console.WriteLine("La rutina " + nombreRutina + " no existe");
            }
        }
        public void AgregarRutina (string nombreRut, string descripRut, int repeticionesRut, int duracionRutMinutos)
        {
            this.RutinaSemanal[PosicionLibreRutina] = new Rutina(nombreRut, descripRut, repeticionesRut, duracionRutMinutos);
            this.PosicionLibreRutina++;
            Console.WriteLine( "Rutina agregada con éxito\n"
                + "Nombre rutina: " + this.RutinaSemanal[PosicionLibreRutina-1].NombreRutina + "\n"
                + "Descripción: " + this.RutinaSemanal[PosicionLibreRutina - 1].DescripRutina + "\n"
                + this.RutinaSemanal[PosicionLibreRutina - 1].RepeticionesRutina + " repeticiones\n"
                + "Duración rutina: " + this.RutinaSemanal[PosicionLibreRutina - 1].DuracionRutinaMinutos + " minutos\n")
                ;
        }
    }
}
