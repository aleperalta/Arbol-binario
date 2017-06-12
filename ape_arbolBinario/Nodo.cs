using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ape_arbolBinario
{
    class Nodo
    {
        public int dato;
        public Nodo izq, der;

        public Nodo(int dato)
        {
            this.dato = dato;
            izq = null;
            der = null;
        }

        public override string ToString()
        {
            return dato.ToString();
        }
    }
}
