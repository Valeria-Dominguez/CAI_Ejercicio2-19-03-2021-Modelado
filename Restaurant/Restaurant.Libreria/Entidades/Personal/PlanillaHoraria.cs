using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Libreria.Entidades
{
    class PlanillaHoraria
    {
        private string diaDeLaSemana;
        private DateTime horaIngreso;
        private DateTime horaEgreso;
        private string nombrePersonal;

        public string DiaDeLaSemana
        {
            get
            {
                return diaDeLaSemana;
            }
            set
            {
                this.diaDeLaSemana = value;
            }
        }
        public DateTime HoraIngreso
        {
            get
            {
                return horaIngreso;
            }
            set
            {
                this.horaIngreso = value;
            }
        }
        public DateTime HoraEgreso
        {
            get
            {
                return horaEgreso;
            }
            set
            {
                this.horaEgreso = value;
            }
        }
        public string NombrePersonal
        {
            get
            {
                return nombrePersonal;
            }
            set
            {
                this.nombrePersonal = value;
            }
        }
    }
}
