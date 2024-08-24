using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_02
{
    public partial class Prog_Tema_3_Ej_02 : Form
    {
        public Prog_Tema_3_Ej_02()
        {
            InitializeComponent();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
			// int.TryParse evalúan para cada TextBox si lo introducido es un número
            // Si lo es lo convierte en un entero
            // Las variables num1esnum y num2esnum recogen un valor booleano en función de si tiene éxito la conversión a entero
			// No se utiliza try-catch
			bool num1esnum = int.TryParse(txtNumero1.Text, out int num1);
            bool num2esnum = int.TryParse(txtNumero2.Text, out int num2);

			// Bloque condicional if que evalúa si ha tenido éxito la conversión a entero de lo introducido en los TextBox
			if (num1esnum && num2esnum)
            {
				// Bloque condicional if para evaluar si los números son iguales
				// Los resultados se imprimen utilizando plantillas (templates) literales
				if (num1 == num2)
                {
                    lblResultado.Text = $"{num1} y {num2}: ¡Dos iguales para hoy!";
                } 
                else
                {
                    lblResultado.Text = $"{num1} y {num2} NO son iguales";
                }
            } else
            {
                lblResultado.Text = "Introduce números";
            }
        }
    }
}
