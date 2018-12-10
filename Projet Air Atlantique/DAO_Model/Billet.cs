using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Air_Atlantique
{
    class Billet
    {

        private int IdBillet;
        private double Prix;

        public double PrixProperty
        {
            get { return Prix; }
            set { Prix = value; }
        }

    }
}
