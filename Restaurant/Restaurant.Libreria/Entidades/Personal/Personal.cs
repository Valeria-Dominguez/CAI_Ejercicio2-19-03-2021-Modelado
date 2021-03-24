using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Libreria.Entidades
{
    class Personal
    {
        private int idPersonal;
        private string nombrePersonal;
        private int dniPersonal;
        private string categoríaPersonal;
        private DateTime fechaIngPersonal;
        private string domicilioPersonal;
        private string emailPersonal;
        private int telPersonal; 

        public int IdPersonal
        {
            get
            {
                return idPersonal;
            }
            set
            {
                this.idPersonal = value;
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
        public int DniPersonal
        {
            get
            {
                return dniPersonal;
            }
            set
            {
                this.dniPersonal = value;
            }
        }
        public string CategoríaPersonal
        {
            get
            {
                return categoríaPersonal;
            }
            set
            {
                this.categoríaPersonal = value;
            }
        }
        public DateTime FechaIngPersonal
        {
            get
            {
                return fechaIngPersonal;
            }
            set
            {
                this.fechaIngPersonal = value;
            }
        }
        public string DomicilioPersonal
        {
            get
            {
                return domicilioPersonal;
            }
            set
            {
                this.domicilioPersonal = value;
            }
        }
        public string EmailPersonal
        {
            get
            {
                return emailPersonal;
            }
            set
            {
                this.emailPersonal = value;
            }
        }
        public int TelPersonal
        {
            get
            {
                return telPersonal;
            }
            set
            {
                this.telPersonal = value;
            }
        }

    }
}
