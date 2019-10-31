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

namespace ProyectoNRP
{
    /// <summary>
    /// Lógica de interacción para ClientAdd.xaml
    /// </summary>
    public partial class ClientAdd : Page
    {
        public ObservableCollection<Cliente> ClientsL { get; set; }
        public ObservableCollection<Cliente> Clients = new ObservableCollection<Cliente>();
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
            ClientsL.Remove((Cliente)ClientsList.SelectedItem);
        }

        private void AddClient(object sender, RoutedEventArgs e)
        {
            ClientNombre = ClientName.Text;
            ClientPeso = Int32.Parse(ClientWeight.Text);
            Cliente nuevoCliente;
            if (ClientPeso <= 5 && ClientPeso >= 1)
            {
                nuevoCliente = new Cliente(ClientNombre, ClientPeso);
                ClientsL.Add(nuevoCliente);
                ProyectoNRP.BDDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter = new ProyectoNRP.BDDataSetTableAdapters.ClientesTableAdapter();
                clientesTableAdapter.Insert(ClientNombre, ClientPeso);
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
