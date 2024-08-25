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
            // Declaración e inicialización de las variables que se utilizarán
            int unidades = 0;

            // Esta variable cambiará su valor a "moneda/s" durante la ejecución del programa
            string tipoMoneda = "billete/s";

            lblResultado.Text = "";


			// Con este método se evalúa si lo introducido es un número y lo convierte en un entero; y si no lo es devuelve un mensaje
			// No se utiliza try-catch
			bool numesnum = int.TryParse(txtCantidad.Text, out int cantidad);


            if (numesnum)
            {
                // Si la cantidad introducida es un número mayor que 0 se comienza a evaluar cuántos billetes o monedas de cada tipo corresponden
                if (cantidad > 0)
                {

					// Billetes de 10.000 pesetas

                    // Las unidades de cada billete o moneda se obtienen de dividir la cantidad introducida en el TextBox por el valor del billete o moneda
					unidades = cantidad / 10000;

                    // Si hay alguna unidad entonces se concatena el resultado al mensaje a imprimir en el label
                    if (unidades > 0)
                    {
                        lblResultado.Text += $"{unidades} {tipoMoneda} de 10.000 ptas\n";
                    }

                    // Al final se actualiza la cantidad, con una cantidad resultante de disminuir los billetes o monedas ya computados
                    cantidad -= (unidades * 10000);

                    // Se sigue del mismo modo para todos los valores admitidos



					// Billetes de 5.000 pesetas

					unidades = cantidad / 5000;

					if (unidades > 0)
                    {
                        lblResultado.Text += $"{unidades} {tipoMoneda} de 5.000 ptas\n";
                    }

					cantidad -= (unidades * 5000);



					// Billetes de 2.000 pesetas

					unidades = cantidad / 2000;

					if (unidades > 0)
                    {
                        lblResultado.Text += $"{unidades} {tipoMoneda} de 2.000 ptas\n";
                    }

					cantidad -= (unidades * 2000);



					// Billetes de 1.000 pesetas

					unidades = cantidad / 1000;

					if (unidades > 0)
                    {
                        lblResultado.Text += $"{unidades} {tipoMoneda} de 1.000 ptas\n";
                    }

					cantidad -= (unidades * 1000);



                    // A partir de aquí la variable string, que identifica al tipo de moneda, cambia de "billete/s" a "moneda/s"
					tipoMoneda = "moneda/s";



					// Monedas de 500 pesetas

					unidades = cantidad / 500;

					if (unidades > 0)
                    {
                        lblResultado.Text += $"{unidades} {tipoMoneda} de 500 ptas\n";
                    }

					cantidad -= (unidades * 500);



					// Monedas de 200 pesetas

					unidades = cantidad / 200;

					if (unidades > 0)
                    {
                        lblResultado.Text += $"{unidades} {tipoMoneda} de 200 ptas\n";
                    }

					cantidad -= (unidades * 200);



					// Monedas de 100 pesetas

					unidades = cantidad / 100;

					if (unidades > 0)
                    {
                        lblResultado.Text += $"{unidades} {tipoMoneda} de 100 ptas\n";
                    }

					cantidad -= (unidades * 100);



					// Monedas de 50 pesetas

					unidades = cantidad / 50;

					if (unidades > 0)
                    {
                        lblResultado.Text += $"{unidades} {tipoMoneda} de 50 ptas\n";
                    }

					cantidad -= (unidades * 50);

					// Monedas de 25 pesetas

					unidades = cantidad / 25;

					if (unidades > 0)
                    {
                        lblResultado.Text += $"{unidades} {tipoMoneda} de 25 ptas\n";
                    }

					cantidad -= (unidades * 25);

					// Monedas de 10 pesetas

					unidades = cantidad / 10;

					if (unidades > 0)
                    {
                        lblResultado.Text += $"{unidades} {tipoMoneda} de 10 ptas\n";
                    }

					cantidad -= (unidades * 10);

					// Monedas de 5 pesetas

					unidades = cantidad / 5;

					if (unidades > 0)
                    {
                        lblResultado.Text += $"{unidades} {tipoMoneda} de 5 ptas\n";
                    }

					cantidad -= (unidades * 5);

					// Monedas de 2 pesetas

					unidades = cantidad / 2;

					if (unidades > 0)
                    {
                        lblResultado.Text += $"{unidades} {tipoMoneda} de 2 ptas\n";
                    }

					cantidad -= (unidades * 2);

                    // Monedas de 1 peseta

                    unidades = cantidad; 

                    if (unidades > 0)
                    {
                        lblResultado.Text += $"{unidades} {tipoMoneda} de 1 pta\n";
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
