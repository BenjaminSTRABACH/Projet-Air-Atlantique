using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Air_Atlantique.Models.DAO
{
    class Passager
    {
        private int IdPassager;
        private string Nom;
        private string Prenom;
        private bool Genre;
        private DateTime DateNaissance;
        private int PointsFidelite;
        private int Tel;
        private string Mail;

        public int GetIdPassager()
        {
            return this.IdPassager;
        }

        public string GetNom()
        {
            return this.Nom;
        }

        public string GetPrenom()
        {
            return this.Prenom;
        }

        public bool GetGenre()
        {
            return this.Genre;
        }

        public DateTime GetDateNaissance()
        {
            return this.DateNaissance;
        }

        public int GetPointsFidelite()
        {
            return this.PointsFidelite;
        }

        public int GetTel()
        {
            return this.Tel;
        }

        public string GetMail()
        {
            return this.Mail;
        }

    }
}
