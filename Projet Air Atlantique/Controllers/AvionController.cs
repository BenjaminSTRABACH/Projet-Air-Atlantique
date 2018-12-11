using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Air_Atlantique.Controllers
{
    class AvionController : INotifyPropertyChanged
    {
        private int IdAvion;
        private string Configuration;
        private string TypePneu;
        private bool Location;
        private DateTime HeuresVol;

        public AvionController() { }

        public AvionController(int IdAvion, string Configuration, string TypePneu, bool Location, DateTime HeuresVol)
        {
            this.IdAvion = IdAvion;
            this.Configuration = Configuration;
            this.TypePneu = TypePneu;
            this.Location = Location;
            this.HeuresVol = HeuresVol;
        }

        public int IdAvionProperty
        {
            get { return IdAvion; }
        }

        public string ConfigurationProperty
        {
            get { return Configuration; }
            set { Configuration = value; }
        }

        public string TypePneuProperty
        {
            get { return TypePneu; }
            set { TypePneu = value; }
        }

        public bool LocationProperty
        {
            get { return Location; }
            set { Location = value; }
        }

        public DateTime HeuresVolProperty
        {
            get { return HeuresVol; }
            set { HeuresVol = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
