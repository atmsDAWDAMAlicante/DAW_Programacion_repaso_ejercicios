using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_4_Ej_07
{
    public partial class Prog_Tema_4_Ej_07 : Form
    {
        public Prog_Tema_4_Ej_07()
        {
            InitializeComponent();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            bool num1esnum = int.TryParse(txtNumero1.Text, out int numero1);
            bool num2esnum = int.TryParse(txtNumero2.Text, out int numero2);

            if (num1esnum && num2esnum)
            {
                Calcular();
            }

            else
            {
                lblResultado.Text = "Introduce números";
            }

        }

        public void Calcular()
        {
            // operaciones
        }
    }
}
