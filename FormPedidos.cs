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
    public partial class FormPedidos : Form
    {
        public FormPedidos()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            double total = 0.0;
            //Calculamos si selecciono el envio normal
            if (radNormal.Checked == true && radCasa.Checked == true)
                total = 5 + 5;
            else
            if (radNormal.Checked == true && radGratis.Checked == true)
                total = 5;
            //Calculamos si selecciono el envio express
            if (radExpress.Checked == true && radCasa.Checked == true)
                total = 10 + 5;
            else
            if (radExpress.Checked == true && radGratis.Checked == true)
                total = 10;
            //Calculamos si selecciono el envio premiun
            if (radPremiun.Checked == true && radCasa.Checked == true)
                total = 20 + 5;
            else
            if (radPremiun.Checked == true && radGratis.Checked == true)
                total = 20;
            MessageBox.Show("El costo total es de:" + total.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
