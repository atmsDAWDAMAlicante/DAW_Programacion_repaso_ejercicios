using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_01
{
    public partial class Prog_Tema_3_Ej_01 : Form
    {
        public Prog_Tema_3_Ej_01()
        {
            InitializeComponent();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            bool datoesnum = int.TryParse(txtDato.Text, out int dato);

            if (datoesnum )
            {

                if (dato == 2)
                {
                    lblResultado.Text = $"El número\nintroducido\nes el {dato}";
                } else
                {
                    lblResultado.Text = "El número\nintroducido\nNO es el 2";
                }

            } else
            {
                lblResultado.Text = "Introduce números";
            }
        }
    }
}
