using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_4_Ej_01_ 
// para las pruebas unitarias hay que cambiar el nombre del namespace para que no coincida con el de la clase
{
    public partial class Prog_Tema_4_Ej_01 : Form
    {
        public Prog_Tema_4_Ej_01()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            // Adaptación para las pruebas unitarias
            int resultadoSuma;

            // Manejo del posible error al introducir caracteres no numéricos sin
            // utilizar excepciones
            bool numero1Num = int.TryParse(txtNumero1.Text, out int numero1);
            bool numero2Num = int.TryParse(txtNumero2.Text, out int numero2);

            if ((numero1Num == false) || (numero2Num == false))
            {
                lblResultado.Text = "Introduce un número";
            }
            else
            {
                // Esta función es la que se evaluará en la prueba unitaria
                resultadoSuma = Suma(numero1, numero2);
                MuestraResultadoSuma(resultadoSuma);
            }

        }

        public int Suma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public void MuestraResultadoSuma(int resultado)
        {
            lblResultado.Text = resultado.ToString();
        }


    }
}
