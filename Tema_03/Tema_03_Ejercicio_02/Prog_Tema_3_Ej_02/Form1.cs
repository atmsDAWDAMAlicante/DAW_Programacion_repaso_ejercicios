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
            bool num1esnum = int.TryParse(txtNumero1.Text, out int num1);
            bool num2esnum = int.TryParse(txtNumero2.Text, out int num2);

            if (num1esnum && num2esnum)
            {
                if (num1 == num2)
                {
                    lblResultado.Text = $"{num1} y {num2}\nson iguales";
                } 
                else
                {
                    lblResultado.Text = $"{num1} y {num2}\nNO son iguales";
                }
            } else
            {
                lblResultado.Text = "Introduce números";
            }
        }
    }
}
