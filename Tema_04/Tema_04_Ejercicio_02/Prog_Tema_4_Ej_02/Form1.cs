using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_4_Ej_02_ // Hay que cambiar el nombre del namespace para usar las pruebas unitarias
{
    public partial class Prog_Tema_4_Ej_02 : Form
    {
        public Prog_Tema_4_Ej_02()
        {
            InitializeComponent();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
			bool numEsNum1 = int.TryParse(txtNumero1.Text, out int numero1);
			bool numEsNum2 = int.TryParse(txtNumero2.Text, out int numero2);
			
            if (numEsNum1 && numEsNum2)
                {
                // Una variable booleana recogerá el resultado de la función que evalúa si el primer número es divisible por el segundo
                bool esDivisible = ComprobarSiEsDivisible(numero1, numero2);

                // En la plantilla literal, que imprime el mensaje en el lable, se incluye la llamada a una función, a la que se 
                // le pasa por parámetro el resultado contenido en la variable booleana 'esDivisible'.
                // Esta función 'ValorNegacion()' devuelve un string que muestra por pantalla la palabra 'NO' o una cadena vacía, 
                // según sea el valor de la variable 'esDivisible'
                lblResultado.Text = $"El numero {numero1} {ValorNegacion(esDivisible)} es divisible\npor {numero2}";
                }

            else
                {
				lblResultado.Text = "Introduce números";
				}
        }

		// Función ComprobarSiEsDivisible devuelve true o false si 'numero1' es divisible por 'numero2'
        // En esta función se evalúa dicha circunstancia
		public bool ComprobarSiEsDivisible (int num1, int num2)
            {
            if (num1 % num2 == 0)
                return true;
            else
                return false;
            }

		// Función ValorNegacion() devuelve un string con el valor 'NO' o una cadena vacía, según sea el valor del parámetro pasado
		public string ValorNegacion(bool siEsDivisible)
            {
            if (siEsDivisible)
                return "";
            else
                return "NO";
            }
    }
}
