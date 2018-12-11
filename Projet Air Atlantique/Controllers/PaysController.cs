using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Air_Atlantique.Controllers
{
    class PaysController : INotifyPropertyChanged
    {
        private int IdPays;
        private string Libelle;

        public PaysController() { }

        public PaysController(int IdPays, string Libelle)
        {
            this.IdPays = IdPays;
            this.Libelle = Libelle;
        }

        public int IdPaysProperty
        {
            get { return IdPays; }
            set { IdPays = value; }
        }

        public string LibelleProperty
        {
            get { return Libelle; }
            set { Libelle = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
