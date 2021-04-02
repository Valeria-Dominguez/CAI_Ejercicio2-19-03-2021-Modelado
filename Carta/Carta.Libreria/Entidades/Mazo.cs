using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carta.Libreria.Entidades
{
    public class Mazo
    {        
        int _cantCartasMazo;
        Carta[] _cartas;
        int _posicionLibreCartas;

        public int CantCartasMazo
        {
            get
            {
                return _cantCartasMazo;
            }
            set
            {
                _cantCartasMazo = value;
            }
        }
        public Carta [] Cartas
        {
            get
            {
                return _cartas;
            }
            set
            {
                _cartas = value;
            }
        }

        public Mazo(int cantCartasMazo)
        {
            CantCartasMazo = cantCartasMazo;
            Cartas = new Carta[CantCartasMazo];
            for (int cont = 0; cont <= this.Cartas.GetUpperBound(0); cont++)
            {
                Cartas[cont] = new Carta(0,0,"");
            }
        }

        public void AgregarCarta (int idCarta, int numeroCarta, string paloCarta)
        {
            this.Cartas[this._posicionLibreCartas] = new Carta(idCarta, numeroCarta, paloCarta);
            this._posicionLibreCartas++;
            
        }

    }
}
