using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNRP
{
    class Requisito : IComparer<Requisito>
    {
        private string nombre;
        private int esfuerzo;
        private int valoracion;
        private int ratio;

        public Requisito(string nombre, int esfuerzo, SortedDictionary<Cliente, int> valoraciones)
        {
            this.nombre = nombre;
            this.esfuerzo = esfuerzo;
            valoracion = 0;
            foreach (KeyValuePair<Cliente, int> cliente in valoraciones)
            {
                valoracion += cliente.Key.getPeso() * cliente.Value;
            }
            this.ratio = valoracion / esfuerzo;
        }

        public int getEsfuerzo()
        {
            return this.esfuerzo;
        }

        public int getValoracion()
        {
            return this.valoracion;
        }

        public int getRatio()
        {
            return this.ratio;
        }

        public int Compare(Requisito r1, Requisito r2)
        {
            if (r1.ratio < r2.ratio)
                return 1;
            if (r1.ratio > r2.ratio)
                return -1;
            else
                return 0;
        }
    }
}
