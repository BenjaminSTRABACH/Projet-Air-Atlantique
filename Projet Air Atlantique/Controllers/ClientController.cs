using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Air_Atlantique.Controllers
{
    class ClientController : INotifyPropertyChanged
    {
        private int IdClient;
        private string Nom;
        private string Prenom;
        private bool Genre;
        private DateTime DateNaissance;
        private int PointsFidelite;
        private int Tel;
        private string Mail;

        public ClientController() { }

        public ClientController(int IdClient, string Nom, string Prenom, bool Genre, DateTime DateNaissance, int PointsFidelite, int Tel, string Mail)
        {
            this.IdClient = IdClient;
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Genre = Genre;
            this.DateNaissance = DateNaissance;
            this.PointsFidelite = PointsFidelite;
            this.Tel = Tel;
            this.Mail = Mail;
        }

        public int IdClientProperty
        {
            get { return IdClient; }
            set { IdClient = value; }
        }

        public string NomProperty
        {
            get { return Nom; }
            set { Nom = value; }
        }

        public string PrenomProperty
        {
            get { return Prenom; }
            set { Prenom = value; }
        }

        public bool GenreProperty
        {
            get { return Genre; }
            set { Genre = value; }
        }

        public DateTime DateNaissanceProperty
        {
            get { return DateNaissance; }
            set { DateNaissance = value; }
        }

        public int GetPointsFideliteProperty()
        { return PointsFidelite; }

        public void SetPointsFideliteProperty(int value)
        { PointsFidelite = value; }

        public int TelProperty
        {
            get { return Tel; }
            set { Tel = value; }
        }

        public string MailProperty
        {
            get { return Mail; }
            set { Mail = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
