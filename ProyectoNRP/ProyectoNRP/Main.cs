using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNRP
{
    class Main
    {
        List<Cliente> clientes = new List<Cliente>();
        List<Requisito> requisitos = new List<Requisito>();
        

        public List<Requisito> algoritmo(int limiteEsfuerzo, List<Requisito> requisitos)
        {
            //SortedDictionary<int, List<Requisito>> solucion = new SortedDictionary<int, List<Requisito>>();
            List<Requisito> sprint = new List<Requisito>();
            int esfuerzo = 0;
            requisitos.Sort();
            foreach (Requisito requisito in requisitos)
            {
                if((esfuerzo+requisito.getEsfuerzo()) <= limiteEsfuerzo)
                {
                    sprint.Add(requisito);
                    esfuerzo += requisito.getEsfuerzo();
                }
                /*if(esfuerzo == limiteEsfuerzo || (esfuerzo + requisito.getEsfuerzo()) > limiteEsfuerzo)
                {
                    solucion.Add(esfuerzo, sprint);
                    esfuerzo = 0;
                    sprint.Clear();
                }*/
            }
            //return solucion;
            return sprint;
        }

        public void añadirCliente(string nombre, int peso)
        {
            BDDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter = new BDDataSetTableAdapters.ClientesTableAdapter();
            clientesTableAdapter.Insert(nombre, peso);
        }

        public void añadirRequisito(string nombre, int esfuerzo, SortedDictionary<Cliente, int> valoraciones)
        {
            BDDataSetTableAdapters.RequisitosTableAdapter requisitosTableAdapter = new BDDataSetTableAdapters.RequisitosTableAdapter();
            requisitosTableAdapter.Insert(nombre, esfuerzo);
        }

        public void eliminarCliente(int id)
        {
            BDDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter = new BDDataSetTableAdapters.ClientesTableAdapter();
            clientesTableAdapter.Delete(id);
        }

    }
}
