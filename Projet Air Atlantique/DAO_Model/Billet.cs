using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Air_Atlantique.Models.DAO
{
    class Billet
    {

        private int IdBillet;
        private double Prix;

        public Billet() { }

        public Billet(int IdBillet, double Prix)
        {
            this.IdBillet = IdBillet;
            this.Prix = Prix;
        }

        public int IdBilletProperty
        {
            get { return IdBillet; }
        }

        public double PrixProperty
        {
            get { return Prix; }
            set { Prix = value; }
        }

    }
}
