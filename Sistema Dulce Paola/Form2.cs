using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Dulce_Paola
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double CostoProducto;
            double Cantidad;
            double DineroCliente;
            double VueltoCLiente;


            CostoProducto = Convert.ToDouble(txtCostoProducto.Text);
            Cantidad = Convert.ToDouble(txtCantidad.Text);
            DineroCliente = Convert.ToDouble(txtDineroCliente.Text);
            VueltoCLiente = DineroCliente - (CostoProducto * Cantidad);
            txtVuelto.Text = "$" + Convert.ToDouble(VueltoCLiente);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCostoProducto.Clear();
            txtCantidad.Clear();
            txtDineroCliente.Clear();
            txtVuelto.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hasta Luego =)");
            Form1 ir = new Form1();
            ir.Show();
            this.Hide();
        }
    }
}
