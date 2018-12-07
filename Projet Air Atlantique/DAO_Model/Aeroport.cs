using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Air_Atlantique
{
    class Aeroport
    {
        private int IdAeroport;
        private string Nom;
        private string Ville;
        private string CodeAITA;
        private int Pays_idPays;

        public int GetIdAeroport()
        {
            return this.IdAeroport;
        }

        public void SetIdAeroport(int IdAeroport)
        {
            this.IdAeroport = IdAeroport;
        }

        public string GetNom()
        {
            return this.Nom;
        }

        public void SetNom(string Nom)
        {
            this.Nom = Nom;
        }

        public string GetVille()
        {
            return this.Ville;
        }

        public void SetVille(string Ville)
        {
            this.Ville = Ville;
        }

        public string GetCodeAITA()
        {
            return this.CodeAITA;
        }

        public void SetCodeAITA(string CodeAITA)
        {
            this.CodeAITA = CodeAITA;
        }

        public int GetPays_idPayst()
        {
            return this.Pays_idPays;
        }

        public void SetPays_idPays(int Pays_idPays)
        {
            this.Pays_idPays = Pays_idPays;
        }
    }
}
