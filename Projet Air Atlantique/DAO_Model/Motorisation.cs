using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Air_Atlantique.DAO_Model
{
    class Motorisation
    {
        private int IdMotorisation;
        private string Libelle;

        public Motorisation() { }

        public Motorisation(int IdMotorisation, string Libelle)
        {
            this.IdMotorisation = IdMotorisation;
            this.Libelle = Libelle;
        }

        public int IdMotorisationProperty
        {
            get { return IdMotorisation; }
        }

        public string LibelleProperty
        {
            get { return Libelle; }
            set { Libelle = value; }
        }
    }
}
