using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_01
{
    public partial class Prog_Tema_3_Ej_01 : Form
    {
        public Prog_Tema_3_Ej_01()
        {
            InitializeComponent();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            // Con este método se evalúa si lo introducido es un número y lo convierte en un entero, o no lo es y devuelve un mensaje
            // No se utiliza try-catch
            bool datoesnum = int.TryParse(txtDato.Text, out int dato);

            // Bloque condicional if para evaluar si el número introducido (variable dato) es un 2
            // Los resultados se imprimen utilizando plantillas (templates) literales
            if (datoesnum )
            {

                if (dato == 2)
                {
                    lblResultado.Text = $"El número introducido\nSÍ es el {dato}";
                } else
                {
                    lblResultado.Text = "El número introducido\nNO es el 2";
                }

            } else
            {
                lblResultado.Text = "Introduce números";
            }
        }
    }
}
