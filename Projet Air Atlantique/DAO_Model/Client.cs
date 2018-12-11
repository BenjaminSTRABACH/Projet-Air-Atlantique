using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Air_Atlantique.Models.DAO
{
    class Client
    {
        private int IdClient;
        private string Nom;
        private string Prenom;
        private char Genre;
        private DateTime DateNaissance;
        private int PointsFidelite;
        private int Tel;
        private string Mail;

        public Client() { }

        public Client(int IdClient, string Nom, string Prenom, char Genre, DateTime DateNaissance, int PointsFidelite, int Tel, string Mail)
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

        public char GenreProperty
        {
            get { return Genre; }
            set { Genre = value; }
        }

        public DateTime DateNaissanceProperty
        {
            get { return DateNaissance; }
            set { DateNaissance = value; }
        }

        public int PointsFideliteProperty
        {
            get { return PointsFidelite; }
            set { PointsFidelite = value; }
        }

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

    }
}
