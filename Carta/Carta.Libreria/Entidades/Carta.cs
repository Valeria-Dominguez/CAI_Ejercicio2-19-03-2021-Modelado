using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carta.Libreria.Entidades
{
    public class Carta
    {
        int _idCarta;
        int _numeroCarta;
        string _paloCarta;

        public int IdCarta
        {
            set
            {
                _idCarta = value;
            }
            get
            {
                return _idCarta;
            }
        }        
        public int NumeroCarta
        {
            set
            {
                _numeroCarta = value;
            }
            get
            {
                return _numeroCarta;
            }
        }
        public string PaloCarta
        {
            set
            {
                _paloCarta = value;
            }
            get
            {
                return _paloCarta;
            }
        }

        public Carta (int idCarta, int numeroCarta, string paloCarta)
        {
            IdCarta = idCarta;
            NumeroCarta = numeroCarta;
            PaloCarta = paloCarta;
        }
    }
}
