using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploLogin
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user, pass;
            user =
            txtUsuario.Text.TrimEnd();
            pass = txtPass.Text.TrimEnd();
            if (user == "USUARIO" && pass
            == "123")
            {
                MessageBox.Show("Bienvenido!");
                this.Hide();
                FormPedidos fp = new
                FormPedidos();
                fp.Show();
            }
            else
            {
                MessageBox.Show("Datos Incorrectos. Intente Nuevamente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Text = "";
                txtPass.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
