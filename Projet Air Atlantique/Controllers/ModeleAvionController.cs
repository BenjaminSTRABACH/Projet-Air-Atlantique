using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Air_Atlantique.Controllers
{
    class ModeleAvionController : INotifyPropertyChanged
    {
        private int IdModeleAvion;
        private string Libelle;

        public ModeleAvionController() { }

        public ModeleAvionController(int IdModeleAvion, string Libelle)
        {
            this.IdModeleAvion = IdModeleAvion;
            this.Libelle = Libelle;
        }

        public string LibelleProperty
        {
            get { return Libelle; }
            set { Libelle = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
