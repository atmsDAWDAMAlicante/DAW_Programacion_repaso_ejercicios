using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_4_Ej_04_
{
    public partial class Prog_Tema_4_Ej_04 : Form
    {
        public Prog_Tema_4_Ej_04()
        {
            InitializeComponent();
        }
        // El valor absoluto de un número es el mismo número con signo positivo

        private void btnAccion_Click(object sender, EventArgs e)
        {
            // El evento click del botón envía el valor del TextBox a la función Convertir() cuyo resultado se guarda 
            // en un string que se imprimirá por pantalla
            string resultado = Convertir(txtNumeroReal.Text);
            lblResultado.Text = resultado;
        }

        public string Convertir(string datoIntroducido)
        {
            // Primero se intenta la conversión en entero del valor pasado por parámetro
			bool numeroEsNumero = int.TryParse(datoIntroducido, out int numero);


            // El primer bloque condicional evalúa la conversión a entero del valor pasado por parámetro           
            if (numeroEsNumero)
                {
                // Si el número se pudo convertir en un entero, se evalúa si es menor que 0, en cuyo caso se multiplica * -1
				if (numero < 0)
					{
					numero *= -1;
					}
                // En este caso se devuelve una plantilla literal con el número resultante
                return $"{numero}";
				}
            else // si no se pudo convertir a entero, se devuelve un string que informa que deben introducirse números
                {
                return "Introduce números.";
                }
        }
    }
}
