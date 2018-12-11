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
using Projet_Air_Atlantique.View;

namespace Projet_Air_Atlantique
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Vols_Click(object sender, RoutedEventArgs e)
        {
            View.Children.Clear();
            VolView view = new VolView();
            View.Children.Add(view);
        }

        private void Clients_Click(object sender, RoutedEventArgs e)
        {
            View.Children.Clear();
            ClientView view = new ClientView();
            View.Children.Add(view);
        }
    }
}
