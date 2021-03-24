using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carta.Libreria.Entidades
{
    public class Carta
    {
        private int idCarta;
        private string nombreCarta;
        private int numeroCarta;
        private string paloCarta;

        public int IdCarta
        {
            set
            {
                this.idCarta = value;
            }
            get
            {
                return idCarta;
            }
        }
        public string NombreCarta
        {
            set
            {
                this.nombreCarta = value;
            }
            get
            {
                return nombreCarta;
            }
        }
        public int NumeroCarta
        {
            set
            {
                this.numeroCarta = value;
            }
            get
            {
                return numeroCarta;
            }
        }
        public string PaloCarta
        {
            set
            {
                this.paloCarta = value;
            }
            get
            {
                return paloCarta;
            }
        }

    }
}
