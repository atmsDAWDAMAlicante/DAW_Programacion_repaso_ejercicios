using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_4_Ej_01
{
    public partial class Prog_Tema_4_Ej_01 : Form
    {
        public Prog_Tema_4_Ej_01()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
                // Llamada a la función suma sin parámetros
                Suma();
        }

        public void Suma()
        {

            int numero1, numero2;
            bool numero1Num = int.TryParse(txtNumero1.Text, out numero1);
            bool numero2Num = int.TryParse(txtNumero2.Text, out numero2);

            if ((numero1Num == false) || (numero2Num == false))
            {
               lblResultado.Text = "Introduce un número";
            } else
            {
                lblResultado.Text = (numero1 + numero2).ToString();
            }



        }


    }
}
