﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Air_Atlantique.Controllers
{
    class BilletController : INotifyPropertyChanged
    {
        private int IdBillet;
        private double Prix;

        public BilletController() { }

        public BilletController(int IdBillet, double Prix)
        {
            this.IdBillet = IdBillet;
            this.Prix = Prix;
        }

        public int IdBilletProperty
        {
            get { return IdBillet; }
        }


        public double PrixProperty
        {
            get { return Prix; }
            set { Prix = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
