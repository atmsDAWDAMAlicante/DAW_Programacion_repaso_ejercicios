using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnAccion_Click(object sender, EventArgs e)
        {
            bool num1esnum = int.TryParse(txtNumero1.Text, out int numero1);
            bool num2esnum = int.TryParse(txtNumero2.Text, out int numero2);

            if (num1esnum && num2esnum)
            {
                if (numero1 < numero2)
                {
                    lblResultado.Text = $"{numero2} es\nmayor que {numero1}";
                }
                else if (numero2 < numero1)
                {
                    lblResultado.Text = $"{numero1} es\nmayor que {numero2}";
                }
                else
                {
                    lblResultado.Text = $"{numero1} y {numero2}\nson iguales";
                }
            }
            else
            {
                lblResultado.Text = "Introduce números";
            }


        }
    }
}
