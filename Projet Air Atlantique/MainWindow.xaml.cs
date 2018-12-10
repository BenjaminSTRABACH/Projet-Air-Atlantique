using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Projet_Air_Atlantique.Models.DAL;
using Projet_Air_Atlantique.Controllers;

namespace Projet_Air_Atlantique
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Mod_Vol mod_vol = new Mod_Vol();
        static List<VolController> list_vols_controllers = new List<VolController>();

        public MainWindow()
        {
            InitializeComponent();
            mod_vol.SelectVolBinders(list_vols_controllers);
            this.listeVols.ItemsSource = list_vols_controllers;
        }

        private void ListeVols_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
