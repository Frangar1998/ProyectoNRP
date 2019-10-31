using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ProgramUserInterface
{
    /// <summary>
    /// Lógica de interacción para ClientAdd.xaml
    /// </summary>
    public partial class ClientAdd : Page
    {
        public ObservableCollection<Client> ClientsL { get; set; }
        public ObservableCollection<Client> Clients = new ObservableCollection<Client>();
        string ClientNombre;
        int ClientPeso;
        public ClientAdd()
        {
            InitializeComponent();
            ClientsList.ItemsSource = Clients;
            ClientsL = Clients;
        }

        private void DeleteClient(object sender, RoutedEventArgs e)
        {
            ClientsL.Remove((Client)ClientsList.SelectedItem);
        }

        private void AddClient(object sender, RoutedEventArgs e)
        {
            ClientNombre = ClientName.Text;
            ClientPeso = Int32.Parse(ClientWeight.Text);
            Client nuevoCliente;
            if (ClientPeso <=5 && ClientPeso >=1)
            {
                nuevoCliente = new Client(ClientNombre, ClientPeso);
                ClientsL.Add(nuevoCliente);
            }
        }

        private void ShowMe(object sender, RoutedEventArgs e)
        {
            MyPopup.IsOpen = true;
        }
        private void HideClick(object sender, RoutedEventArgs e)
        {
            MyPopup.IsOpen = false;
        }
        private void GoToRequisitesAdd(object sender, RoutedEventArgs e)
        {
            RequisiteAdd requisites = new RequisiteAdd(ClientsL);
            this.NavigationService.Navigate(requisites);
        }

    }

   
    public class Client
    {

  
        public String Nombre { get; set; }
        public int Peso { get; set; }
        public int Prequisite { get; set; }
        public Client() { }
        public Client(string clientNombre, int clientPeso)
        {
            this.Nombre = clientNombre;
            this.Peso = clientPeso;
            Prequisite = 0;
        }
      

    }
}
