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
    /// Lógica de interacción para RequirementsTable.xaml
    /// </summary>
    public partial class RequirementsTable : Page
    {

        private Dictionary<Requirement, List<ClientWeight>> clientsAndRequirements;

        public RequirementsTable(){}

        public RequirementsTable(Dictionary<Requirement, List<ClientWeight>> clientsAndRequirements)
        {
            this.clientsAndRequirements = clientsAndRequirements;
            DataGridTextColumn newColumn;
            InitializeComponent();
            foreach (Requirement requi in clientsAndRequirements.Keys)
            {
                GridViewColumn nwc = new GridViewColumn();
                nwc.Header = requi.NameRe;
                nwc.Width = 50;
                nwc.DisplayMemberBinding = new Binding("Prequisite");
                GridviewLista.Columns.Add(nwc);
            }

           
            



            /*
            int i = 0;
            foreach (KeyValuePair<Requirement, List<ClientWeight>> entry in clientsAndRequirements)
            {
                
                for (int j = 0; j < entry.Value.Count; j++)
                {
                    ListViewItem item = new ListViewItem();
                    item.DataContext = entry.Value[j].newClient.Prequisite;
                    //ClientsList.ItemsSource = entry.Value;
                    ClientsList.Items.Add(item);
                    /*
                    newRow = new DataGridRow();
                    newRow.Header = entry.Value[j].newClient.Nombre;
                    
                }
            }
             */

        }


    }
}
