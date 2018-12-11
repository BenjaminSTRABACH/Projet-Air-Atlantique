using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Air_Atlantique.Controllers
{
    class MotorisationController : INotifyPropertyChanged
    {
        private int IdMotorisation;
        private string Libelle;

        public MotorisationController() { }

        public MotorisationController(int IdMotorisation, string Libelle)
        {
            this.IdMotorisation = IdMotorisation;
            this.Libelle = Libelle;
        }

        public int IdMotorisationProperty
        {
            get { return IdMotorisation; }
        }

        public string LibelleProperty
        {
            get { return Libelle; }
            set { Libelle = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
