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
// Para las pruebas unitarias hay que cambiar el nombre del namespace y que no coincida con el nombre de la clase
{
    public partial class Prog_Tema_4_Ej_01 : Form // No puede coincidir con el nombre del namespace
    {
        public Prog_Tema_4_Ej_01()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";

            bool numero1Num = int.TryParse(txtNumero1.Text, out int numero1);
            bool numero2Num = int.TryParse(txtNumero2.Text, out int numero2);

            if ((numero1Num == true) && (numero2Num == true))
            {
				int resultadoSuma = Suma(numero1, numero2); // la variable se declara dentro del bloque if pero se pasa a la función por parámetro
				MostrarResultadoSuma(resultadoSuma);
			}
            else
            {
				lblResultado.Text = "Introduce números.";
			}

        }

        public int Suma(int numero1, int numero2) // Esta función es la que se comprobará en la prueba unitaria
        { 
            return numero1 + numero2;
        }

        public void MostrarResultadoSuma(int resultado)
        {
            lblResultado.Text = $"El resultado es: {resultado}";
        }


    }
}
