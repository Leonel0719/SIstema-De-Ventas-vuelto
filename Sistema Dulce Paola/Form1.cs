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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string Usuario = txtUsuario.Text;
            string Contraseña = txtContraseña.Text;

            if(Usuario == "Dulce Paola" && Contraseña == "AdminDulcePaola")
            {
                this.DialogResult = DialogResult.OK;

                MessageBox.Show("Acceso Concedido, Bienvenida/o");

                Form2 ir = new Form2();
                ir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error,Contraseña o Usuario Incorrecto");

                txtUsuario.Text = "";
                txtContraseña.Text = "";
            }
        }
    }
}
