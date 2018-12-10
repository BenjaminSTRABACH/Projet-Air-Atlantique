using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Air_Atlantique.Models.DAO
{
    class Aeroport
    {
        private int IdAeroport;
        private string Nom;
        private string Ville;
        private string CodeAITA;

        public Aeroport() { }

        public Aeroport(int IdAeroport, string Nom, string Ville, string CodeAITA)
        {
            this.IdAeroport = IdAeroport;
            this.Nom = Nom;
            this.Ville = Ville;
            this.CodeAITA = CodeAITA;
        }

        public string NomProperty
        {
            get { return Nom; }
            set { Nom = value; }
        }

        public string VilleProperty
        {
            get { return Ville; }
            set { Ville = value; }
        }

        public string CodeAITAProperty
        {
            get { return CodeAITA; }
            set { CodeAITA = value; }
        }
    }
}
