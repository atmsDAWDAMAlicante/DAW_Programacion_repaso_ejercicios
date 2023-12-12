using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_07
{
    public partial class Prog_Tema_3_Ej_07 : Form
    {
        public Prog_Tema_3_Ej_07()
        {
            InitializeComponent();
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            bool numesnum = int.TryParse(txtNumero.Text, out int numero);
            if (numesnum)
            {
                switch (numero)
                {
                    case 0:
                        lblResultado.Text = $"Se ha apretado {numero}";
                        break;

                    case 1:
                        lblResultado.Text = $"Se ha apretado {numero}";
                        break;

                    case 2:
                        lblResultado.Text = $"Se ha apretado {numero}";
                        break;

                    case 3:
                        lblResultado.Text = $"Se ha apretado {numero}";
                        break;

                    case 4:
                        lblResultado.Text = $"Se ha apretado {numero}";
                        break;

                    case 5:
                        lblResultado.Text = $"Se ha apretado {numero}";
                        break;

                    case 6:
                        lblResultado.Text = $"Se ha apretado {numero}";
                        break;

                    case 7:
                        lblResultado.Text = $"Se ha apretado {numero}";
                        break;

                    case 8:
                        lblResultado.Text = $"Se ha apretado {numero}";
                        break;

                    case 9:
                        lblResultado.Text = $"Se ha apretado {numero}";
                        break;

                    default:
                        lblResultado.Text = "¿Qué has apretado?";
                        break;

                }
            } 
            else
            {
                lblResultado.Text = "Introduce números";
            }
        }
    }
}
