using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Projet_Air_Atlantique.Controllers
{
    class AeroportController : INotifyPropertyChanged
    {

        private int IdAeroport;
        private string Nom;
        private string Ville;
        private string CodeAITA;

        public AeroportController() { }

        public AeroportController(int IdAeroport, string Nom, string Ville, string CodeAITA)
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

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
