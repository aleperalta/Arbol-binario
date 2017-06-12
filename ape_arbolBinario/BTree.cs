using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ape_arbolBinario
{
    class BTree
    {
        Nodo raiz;

        public BTree()
        {
            raiz = null;
        }

        ////////////////////  AGREGAR  ////////////////////
        public void agregar(Nodo nuevo)
        {
            if (raiz == null)
                raiz = nuevo;
            else
                agregar(nuevo, raiz);
        }

        private void agregar(Nodo nuevo, Nodo padre)
        {
            if (nuevo.dato < padre.dato)
                if (padre.izq == null)
                    padre.izq = nuevo;
                else
                    agregar(nuevo, padre.izq);
            else
                if (padre.der == null)
                    padre.der = nuevo;
                else
                    agregar(nuevo, padre.der);

        }

        ////////////////////  BUSCAR  ////////////////////
        public Nodo buscar(int numABuscar)
        {
            if (raiz == null)
                return null;
            else if (Convert.ToInt16(raiz.dato) == numABuscar)
                return raiz;
            else
                return buscar(numABuscar, raiz);
        }

        private Nodo buscar(int numABuscar, Nodo padre)
        {

            if (padre.der == null && padre.izq == null && padre.dato != numABuscar)
                return null;
            else
            {
                if (numABuscar == Convert.ToInt16(padre.dato))
                    return padre;
                else if (numABuscar < Convert.ToInt16(padre.dato))
                    if (Convert.ToInt16(padre.izq.dato) == numABuscar)
                        return padre.izq;
                    else
                        return buscar(numABuscar, padre.izq);
                else
                    if (Convert.ToInt16(padre.der.dato) == numABuscar)
                        return padre.der;
                    else
                        return buscar(numABuscar, padre.der);
            }
        }

        ////////////////////  INORDER  ////////////////////
        public string inOrder()
        {
            if (raiz == null)
                return "";
            else
                return inOrder(raiz);
        }

        private string inOrder(Nodo R)
        {
            string inor = "";

            if (R.izq != null)
                inor += inOrder(R.izq);

            inor += R.ToString() + " ";

            if (R.der != null)
                inor += inOrder(R.der);

            return inor;
        }

        ////////////////////  PREORDER  ////////////////////
        public string PreOrder()
        {
            if (raiz == null)
                return "";
            else
                return PreOrder(raiz);
        }

        private string PreOrder(Nodo R)
        {
            string preor = "";

            preor += R.ToString() + " ";

            if (R.izq != null)
                preor += PreOrder(R.izq);

            if (R.der != null)
                preor += PreOrder(R.der);

            return preor;
        }

        ////////////////////  POSTORDER  ////////////////////
        public string PostOrder()
        {
            if (raiz == null)
                return "";
            else
                return PostOrder(raiz);
        }

        private string PostOrder(Nodo R)
        {
            string postor = "";

            if (R.izq != null)
                postor += PostOrder(R.izq);

            if (R.der != null)
                postor += PostOrder(R.der);

            postor += R.ToString() + " ";

            return postor;
        }
    }
}
