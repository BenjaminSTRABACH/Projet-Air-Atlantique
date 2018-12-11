using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Air_Atlantique.DAO_Model
{
    class ModeleAvion
    {
        private int IdModeleAvion;
        private string Libelle;

        public ModeleAvion() { }

        public ModeleAvion(int IdModeleAvion, string Libelle) {
            this.IdModeleAvion = IdModeleAvion;
            this.Libelle = Libelle;
        }

        public int IdModeleAvionProperty
        {
            get { return IdModeleAvion; }
        }

        public string LibelleProperty
        {
            get { return Libelle; }
            set { Libelle = value; }
        }
    }
}
