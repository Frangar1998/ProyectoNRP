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
    /// Lógica de interacción para RequisiteAdd.xaml
    /// </summary>
    public partial class RequisiteAdd : Page
    {
        public ObservableCollection<Cliente> ClientsL { get; set; }
        public ObservableCollection<Requirement> RequirementsL { get; set; }
        public ObservableCollection<Requirement> Requirements = new ObservableCollection<Requirement>();

        public Dictionary<Requirement, List<ClientWeight>> ClientsAndRequirements;
        public List<ClientWeight> clientesRequisitos = new List<ClientWeight>();


        string RequirementNombre;
        int requirementEsfuerzo;
        public RequisiteAdd(ObservableCollection<Cliente> clientsL)
        {

            InitializeComponent();
            ClientsAndRequirements = new Dictionary<Requirement, List<ClientWeight>>();
            ClientsL = clientsL;
            ClientsList.ItemsSource = ClientsL;
            RequirementsList.ItemsSource = Requirements;
            RequirementsL = Requirements;
        }


        private void GoToMatrix(object sender, RoutedEventArgs e)
        {
            RequirementsTable requisites = new RequirementsTable(ClientsAndRequirements);
            this.NavigationService.Navigate(requisites);
        }

        private void DeleteRequirement(object sender, RoutedEventArgs e)
        {
            RequirementsL.Remove((Requirement)RequirementsList.SelectedItem);
        }

        private void AddRequirement(object sender, RoutedEventArgs e)
        {

            RequirementNombre = RequirementName.Text;
            requirementEsfuerzo = Int32.Parse(RequirementEffort.Text);
            Requirement nuevoRequisito;
            ClientWeight nuevoClienteRequisito;

            if (requirementEsfuerzo <= 5 && requirementEsfuerzo >= 1)
            {
                nuevoRequisito = new Requirement(RequirementNombre, requirementEsfuerzo);

                foreach (Cliente cadaCliente in ClientsL)
                {
                    //nuevoClienteRequisito = new ClientWeight(cadaCliente, cadaCliente.Prequisite);
                    //clientesRequisitos.Add(nuevoClienteRequisito);
                }
                ClientsAndRequirements.Add(nuevoRequisito, clientesRequisitos);
                clientesRequisitos.Clear();
                RequirementsL.Add(nuevoRequisito);
            }
        }
    }

    public class Requirement
    {
        public String NameRe { get; set; }
        public int Effort { get; set; }
        public Requirement(string requirementNombre, int requirementEsfuerzo)
        {
            this.NameRe = requirementNombre;
            this.Effort = requirementEsfuerzo;
        }
    }

    public class ClientWeight
    {
        public Cliente newClient;
        public double RequirementWeight;

        public ClientWeight(Cliente cadaCliente, double value)
        {
            this.newClient = cadaCliente;
            this.RequirementWeight = value;
        }
    }
}
