using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arboles_binarios_busqueda
{
    public partial class Form1 : Form
    {
        BinaryTree tree = new BinaryTree();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValue.Text, out int value))
            {
                tree.Insert(value);
                lblResult.Text = $"Valor {value} insertado en el árbol.";
            }
            else
            {
                lblResult.Text = "Ingresa un valor válido.";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValue.Text, out int value))
            {
                if (tree.Delete(value))
                {
                    lblResult.Text = $"Valor {value} eliminado del árbol.";
                }
                else
                {
                    lblResult.Text = $"El valor {value} no se encontró en el árbol.";
                }
            }
            else
            {
                lblResult.Text = "Ingresa un valor válido.";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtValue.Text, out int value))
            {
                if (tree.Search(value))
                {
                    lblResult.Text = $"El valor {value} se encuentra en el árbol.";
                }
                else
                {
                    lblResult.Text = $"El valor {value} no se encontró en el árbol.";
                }
            }
            else
            {
                lblResult.Text = "Ingresa un valor válido.";
            }
        }
    }

    internal class BinaryTree
    {
        internal bool Delete(int value)
        {
            throw new NotImplementedException();
        }

        internal void Insert(int value)
        {
            throw new NotImplementedException();
        }

        internal bool Search(int value)
        {
            throw new NotImplementedException();
        }
    }
}
