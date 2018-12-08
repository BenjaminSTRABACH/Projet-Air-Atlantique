using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Air_Atlantique
{
    class Avion
    {
        private int IdAvion;
        private int Vol_idVol;
        private int TypeAvion_IdTypeAvion;
        private string Configuration;
        private string TypePneu;
        private bool Location;
        private DateTime HeuresVol;

        public int GetidAvion()
        {
            return this.IdAvion;
        }

        public void SetIdAvion(int IdAvion)
        {
            this.IdAvion = IdAvion;
        }

        public int GetVol_idVol()
        {
            return this.Vol_idVol;
        }

        public void SetVol_idVol(int Vol_idVol)
        {
            this.Vol_idVol = Vol_idVol;
        }

        public int GetTypeAvion_IdTypeAvion()
        {
            return this.TypeAvion_IdTypeAvion;
        }

        public void SetTypeAvion_IdTypeAvion(int TypeAvion_IdTypeAvion)
        {
            this.TypeAvion_IdTypeAvion = TypeAvion_IdTypeAvion;
        }

        public string GetConfiguration()
        {
            return this.Configuration;
        }

        public void SetConfiguration(string Configuration)
        {
            this.Configuration = Configuration;
        }

        public string GetTypePneu()
        {
            return this.TypePneu;
        }

        public void SetTypePneu(string TypePneu)
        {
            this.TypePneu = TypePneu;
        }

        public bool Getlocation()
        {
            return this.Location;
        }

        public void SetLocation(int Location)
        {
            this.Location = Location;
        }

        public DateTime GetHeuresVol()
        {
            return this.HeuresVol;
        }

        public void SetHeuresVol(DateTime HeuresVol)
        {
            this.HeuresVol = HeuresVol;
        }

    }
}
