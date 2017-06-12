using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ape_arbolBinario
{
    public partial class frmPrincipal : Form
    {
        BTree arbol = new BTree();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtAgregar.Text == "")
                MessageBox.Show("Agrega el número");
            else
                arbol.agregar(new Nodo(Convert.ToInt16(txtAgregar.Text)));

            txtAgregar.Text = "";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ////////////////////  INORDER  ////////////////////
            txtResporte.Text = arbol.inOrder();
        }

        private void btnPreOrder_Click(object sender, EventArgs e)
        {
            ////////////////////  PREORDER  ////////////////////
            txtResporte.Text = arbol.PreOrder();
        }

        private void btnPostOrder_Click(object sender, EventArgs e)
        {
            ////////////////////  POSTORDER  ////////////////////
            txtResporte.Text = arbol.PostOrder();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (arbol.buscar(Convert.ToInt16(txtBuscar.Text)) == null)
                MessageBox.Show("No existe el número");
            else
                txtResporte.Text = arbol.buscar(Convert.ToInt16(txtBuscar.Text)).ToString();
        }
    }
}
