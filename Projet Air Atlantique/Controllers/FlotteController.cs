using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Air_Atlantique.Controllers
{
    class FlotteController : INotifyPropertyChanged
    {
        private int IdFlotte;
        private string Type;

        public FlotteController() { }

        public FlotteController(int IdFlotte, string Type)
        {
            this.IdFlotte = IdFlotte;
            this.Type = Type;
        }

        public int IIdFlotteProperty
        {
            get { return IdFlotte; }
        }
        
        public string TypeProperty
        {
            get { return Type; }
            set { Type = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
