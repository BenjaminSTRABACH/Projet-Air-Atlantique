using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Air_Atlantique
{
    class Billet
    {

        private int idBillet;
        private double prix;
        private int Passager_idPassager;
        private int AeroportDepart_idAeroport;
        private int AeroportArrivee_idAeroport1;


        public int GetidBillet()
        {
            return this.idBillet;
        }

        public void SetidBillet(int idBillet)
        {
            this.idBillet = idBillet;
        }

        public double Getprix()
        {
            return this.prix;
        }

        public void Setprix(double prix)
        {
            this.prix = prix;
        }

        public int GetPassager_idPassager()
        {
            return this.Passager_idPassager;
        }
            
        public void SetPassager_idPassager(int Passager_idPassager)
        {
            this.Passager_idPassager = Passager_idPassager;
        }

        public int GetAeroportDepart_idAeroport()
        {
            return this.AeroportDepart_idAeroport;
        }

        public void SetAeroportDepart_idAeroport(int AeroportDepart_idAeroport)
        {
            this.AeroportDepart_idAeroport = AeroportDepart_idAeroport;
        }

        public int GetAeroportArrivee_idAeroport1()
        {
            return this.AeroportArrivee_idAeroport1;
        }

        public void SetAeroportArrivee_idAeroport1(int AeroportArrivee_idAeroport1)
        {
            this.AeroportArrivee_idAeroport1 = AeroportArrivee_idAeroport1;
        }
    }
}
