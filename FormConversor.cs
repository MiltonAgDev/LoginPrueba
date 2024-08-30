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
    public partial class FormConversor : Form
    {
        public FormConversor()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Lb_Kg, Lt_Onzas, Kg_Gramos;
            int TipoA;
            string tipoAlimentoTexto;
            int Convert;

            Lb_Kg = 0.45;
            Lt_Onzas = 33.8;
            Kg_Gramos = 1000;
            // Obtener el valor del tipo de alimento desde el TextBox
            tipoAlimentoTexto = txtTipoA.Text;
            
            // Intentar parsear el valor ingresado a un entero
            if (int.TryParse(tipoAlimentoTexto, out TipoA))
            {
                // Validar que el tipo de alimento esté dentro del rango permitido
                if (TipoA >= 1 && TipoA <= 6)
                {
                    double peso = double.Parse(txtPeso.Text);
                    

                    // Realizar la conversión dependiendo del tipo de alimento
                    if (TipoA >= 1 && TipoA <= 2)
                    {
                        Convert = peso * Lb_Kg; // Convertir Libras a Kilogramos
                    }
                    else if (TipoA >= 3 && TipoA <= 4)
                    {
                        Convert = peso * Lt_Onzas; // Convertir Litros a Onzas
                    }
                    else if (TipoA >= 5 && TipoA <= 6)
                    {
                        Convert = peso * Kg_Gramos; // Convertir Kilogramos a Gramos
                    }

                    // Mostrar el resultado en un label
                    txtPeso.Text = Convert;
                }
                else
                {
                    MessageBox.Show("Ingrese un código tipo de alimento válido (1-6).");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un número válido en el campo de tipo de alimento.");
            }

        }
    }
}
