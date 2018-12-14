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

namespace Projet_Air_Atlantique.View
{
    /// <summary>
    /// Logique d'interaction pour ClientView.xaml
    /// </summary>
    public partial class ClientView : UserControl
    {
        Mod_Client mod_client = new Mod_Client();
        static List<ClientController> list_clients_controllers = new List<ClientController>();

        public ClientView()
        {
            InitializeComponent();
            List<ClientController> list_clients_controllers = new List<ClientController>();
            mod_client.SelectClientBinders(list_clients_controllers);
            this.listeClients.ItemsSource = list_clients_controllers;
        }

        private void ListeClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Ajout_client_click(object sender, RoutedEventArgs e)
        {
            string nom = nom_client.Text;
            string prenom = prenom_client.Text;
            int tel = Convert.ToInt32(tel_client.Text);
            string mail = mail_client.Text;
            DateTime date_naissance = dateN_client.DisplayDate;

            char genre = 'H' ;
            if (F.IsChecked == true)
            {
                genre = 'F';
            }

            ClientController clientController = new ClientController(0, nom, prenom, genre, date_naissance , 0, tel, mail);
            mod_client.AddClientBinders(clientController);
        }
    }
}
