using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_4_Ej_08_
{
    public partial class Prog_Tema_4_Ej_08 : Form
    {
        public Prog_Tema_4_Ej_08()
        {
            InitializeComponent();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            double num1 = 0, num2 = 0, num3 = 0;
            ValidarCampos1(ref num1, ref num2, ref num3);
        }


        public void ValidarCampos1(ref double num1, ref double num2, ref double num3)
        {
            bool num1esnum = double.TryParse(txtNum1.Text, out num1);
            bool num2esnum = double.TryParse(txtNum2.Text, out num2);
            bool num3esnum = double.TryParse(txtNum3.Text, out num3);

            if (num1esnum && num2esnum && num3esnum)
            {
                ValidarCampos2(ref num1, ref num2, ref num3);
            }
            else 
            {
                lblResultado.Text = "Introduce números";
            }
        }

        public void ValidarCampos2(ref double num1, ref double num2, ref double num3)
        {
            if ((num1 >= 0 && num1 < 11) && (num2 >= 0 && num2 < 11) && (num3 >= 0 && num3 < 11))
            {
                CalcularLaMedia(ref num1, ref num2, ref num3);
            }
            else 
            {
				lblResultado.Text = "Introduce un valor\nentre 0 y 10";
            }
        }

        public void CalcularLaMedia(ref double num1, ref double num2, ref double num3)
        {
            double media = (( num1 + num2 + num3 ) / 3 );
            // lblResultado.Text = "La nota media\nes " + Math.Round(media, 2).ToString("#.##");
            lblResultado.Text = $"{media:F2}";
        }
    }

}
