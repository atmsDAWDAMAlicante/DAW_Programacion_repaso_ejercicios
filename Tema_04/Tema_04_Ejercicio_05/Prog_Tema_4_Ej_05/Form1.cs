using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_4_Ej_05_
{
    public partial class Prog_Tema_4_Ej_05 : Form
    {
        public Prog_Tema_4_Ej_05()
        {
            InitializeComponent();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            string resultado = Comparar(txtNumero1.Text, txtNumero2.Text);
            lblResultado.Text = resultado;
        }

        public string Comparar(string numero1, string numero2)
        {

			bool numero1EsNum = int.TryParse(numero1, out int num1);
			bool numero2EsNum = int.TryParse(numero2, out int num2);

            // Los dos bloques if anidados evalúan:
            // que lo introducido sean números
            // cuál es el mayor, o si son iguales
            // y devuelve un string acorde en cada caso
			if (numero1EsNum && numero2EsNum)
				{
				if (num1 > num2)
                    {
                    return num1.ToString();
                    }
                else if (num1 < num2)
                    {
                    return $"{num2}";
                    }
                else
                    {
                    return "¡Dos iguales para hoy!";
                    }
				}
			else
				{
				return "Introduce números.";
				}
        }
    }
}
