using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Air_Atlantique.DAO_Model
{
    class Flotte
    {
        private int IdFlotte;
        private string Type;

        public Flotte() { }

        public Flotte(int IdFlotte, string Type)
        {
            this.IdFlotte = IdFlotte;
            this.Type = Type;
        }

        public int IdFlotteProperty
        {
            get { return IdFlotte; }
        }

        public string TypeProperty
        {
            get { return Type; }
            set { Type = value; }
        }
    }
}
