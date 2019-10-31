using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoNRP
{
    public class Cliente
    {
        private string nombre;
        private int peso;
        
        public Cliente(string nombre, int peso)
        {
            this.nombre = nombre;
            this.peso = peso;
        }

        public int getPeso()
        {
            return this.peso;
        }

        public string getNombre()
        {
            return this.nombre;
        }

    }
}
