using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendedorForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Vendedor> vendedores = new List<Vendedor>();

        private void btnCrearVendedor_Click(object sender, EventArgs e)
        {
            CrearVendedor("Jorge","Lopez","1234");
            CrearVendedor("Mirta", "Garcia", "5678");
            dataGridView1.DataSource = vendedores;
        }

        private void CrearVendedor(string nombre, string apellido, string legajo) {

            Vendedor vendedor = new Vendedor(nombre, apellido, legajo);
            vendedores.Add(vendedor);
            MessageBox.Show(vendedor.Nombre + ". Comision de: " + Vendedor.Comision);
        
        
        }

        private void btnCambiarComision_Click(object sender, EventArgs e)
        {
            Vendedor.Comision = 15;
        }

        private void btnCrearVendedor2_Click(object sender, EventArgs e)
        {
            CrearVendedor("Raul", "Gonzales", "999");
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = vendedores;
            MessageBox.Show("Comision de los vendores es de " + Vendedor.Comision);

        }
    }
}
