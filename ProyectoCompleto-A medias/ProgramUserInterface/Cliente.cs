using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramUserInterface
{
    public class Cliente
    {
        public String Nombre { get; set; }
        public int Peso { get; set; }
        public Cliente() { }
        public Cliente(string clientNombre, int clientPeso)
        {
            this.Nombre = clientNombre;
            this.Peso = clientPeso;
        }
    }
}
