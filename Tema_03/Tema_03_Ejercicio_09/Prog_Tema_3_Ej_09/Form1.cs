using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_09
{
    public partial class Prog_Tema_3_Ej_09 : Form
    {
        public Prog_Tema_3_Ej_09()
        {
            InitializeComponent();
        }

        private void btnSuCambio_Click(object sender, EventArgs e)
        {
            int unidades = 0;
            string tipoMoneda = "billete/s";
            lblResultado.Text = "";
            bool numesnum = int.TryParse(txtCantidad.Text, out int cantidad);
            if (numesnum)
            {
                if (cantidad > 0)
                {
                    // Billetes de 10.000 pesetas
                    while (cantidad >= 10000)
                    {
                         unidades++;
                         cantidad -= 10000;
                    }

                    if (unidades > 0)
                    {
                        lblResultado.Text += $"{unidades} {tipoMoneda} de 10.000 ptas\n";
                    }

                    unidades = 0;

                    // Billetes de 5.000 pesetas
                    while (cantidad >= 5000)
                    {
                        unidades++;
                        cantidad -= 5000;
                    }

                    if (unidades > 0)
                    {
                        lblResultado.Text += $"{unidades} {tipoMoneda} de 5.000 ptas\n";
                    }

                    unidades = 0;

                    // Billetes de 2.000 pesetas
                    while (cantidad >= 2000)
                    {
                        unidades++;
                        cantidad -= 2000;
                    }

                    if (unidades > 0)
                    {
                        lblResultado.Text += $"{unidades} {tipoMoneda} de 2.000 ptas\n";
                    }

                    unidades = 0;

                    // Billetes de 1.000 pesetas
                    while (cantidad >= 1000)
                    {
                        unidades++;
                        cantidad -= 1000;
                    }

                    if (unidades > 0)
                    {
                        lblResultado.Text += $"{unidades} {tipoMoneda} de 1.000 ptas\n";
                    }

                    unidades = 0;
                    tipoMoneda = "moneda/s";

                    // Monedas de 500 pesetas
                    while (cantidad >= 500)
                    {
                        unidades++;
                        cantidad -= 500;
                    }

                    if (unidades > 0)
                    {
                        lblResultado.Text += $"{unidades} {tipoMoneda} de 500 ptas\n";
                    }

                    unidades = 0;

                    // Monedas de 200 pesetas
                    while (cantidad >= 200)
                    {
                        unidades++;
                        cantidad -= 200;
                    }

                    if (unidades > 0)
                    {
                        lblResultado.Text += $"{unidades} {tipoMoneda} de 200 ptas\n";
                    }

                    unidades = 0;

                    // Monedas de 100 pesetas
                    while (cantidad >= 100)
                    {
                        unidades++;
                        cantidad -= 100;
                    }

                    if (unidades > 0)
                    {
                        lblResultado.Text += $"{unidades} {tipoMoneda} de 100 ptas\n";
                    }

                    unidades = 0;

                    // Monedas de 50 pesetas
                    while (cantidad >= 50)
                    {
                        unidades++;
                        cantidad -= 50;
                    }

                    if (unidades > 0)
                    {
                        lblResultado.Text += $"{unidades} {tipoMoneda} de 50 ptas\n";
                    }

                    unidades = 0;

                    // Monedas de 25 pesetas
                    while (cantidad >= 25)
                    {
                        unidades++;
                        cantidad -= 25;
                    }

                    if (unidades > 0)
                    {
                        lblResultado.Text += $"{unidades} {tipoMoneda} de 25 ptas\n";
                    }

                    unidades = 0;

                    // Monedas de 10 pesetas
                    while (cantidad >= 10)
                    {
                        unidades++;
                        cantidad -= 10;
                    }

                    if (unidades > 0)
                    {
                        lblResultado.Text += $"{unidades} {tipoMoneda} de 10 ptas\n";
                    }

                    unidades = 0;

                    // Monedas de 5 pesetas
                    while (cantidad >= 5)
                    {
                        unidades++;
                        cantidad -= 5;
                    }

                    if (unidades > 0)
                    {
                        lblResultado.Text += $"{unidades} {tipoMoneda} de 5 ptas\n";
                    }

                    unidades = 0;

                    // Monedas de 2 pesetas
                    while (cantidad >= 2)
                    {
                        unidades++;
                        cantidad -= 2;
                    }

                    if (unidades > 0)
                    {
                        lblResultado.Text += $"{unidades} {tipoMoneda} de 2 ptas\n";
                    }

                    unidades = 0;

                    // Monedas de 1 pesetas
                    while (cantidad >= 1)
                    {
                        unidades++;
                        cantidad -= 1;
                    }

                    if (unidades > 0)
                    {
                        lblResultado.Text += $"{unidades} {tipoMoneda} de 1 ptas\n";
                    }



                }
                else
                {
                    lblResultado.Text = "Introduzca una cantidad positiva";
                }




            }


            else
            {
                lblResultado.Text = "Introduzca números";
            }
        }
    }
}
