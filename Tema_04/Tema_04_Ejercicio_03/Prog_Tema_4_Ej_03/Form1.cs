using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_4_Ej_03
{
    public partial class Prog_Tema_4_Ej_03 : Form
    {
        public Prog_Tema_4_Ej_03()
        {
            InitializeComponent();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            bool numero1num = int.TryParse(txtNumero1.Text, out int numero1);
            bool numero2num = int.TryParse(txtNumero2.Text, out int numero2);
            if (numero1num && numero2num)
            {
                Intercambio(numero1, numero2);
            } else
            {
                lblNumeroA.Text = "Introduce números";
            }
        }

        public void Intercambio(int numero1, int numero2)
        {
            lblNumeroA.Text = $"{numero2}";
            lblNumeroB.Text = $"{numero1}";
        }
    }
}
