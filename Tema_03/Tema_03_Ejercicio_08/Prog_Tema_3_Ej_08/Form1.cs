using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog_Tema_3_Ej_08
{
    public partial class Prog_Tema_3_Ej_08 : Form
    {
        public Prog_Tema_3_Ej_08()
        {
            InitializeComponent();
        }

        // NOTA: este programa contiene un Easter Egg (no todo el mundo lo comprenderá... sólo los de cierta edad :) ).
        // Fuera del evento click del botón se declaran e inicializan las dos variables que se utilizan en el Eeaster Egg
        // Se ha utilizado únicamente los conceptos explicados hasta este tema (quedando fuera: módulos, arrays y POO... lo que lo ha hecho un poco difícil)

		int easterEgg = 0;
		string textoEasterEgg = "";

        // Esta otra variable entero hará de contador de las líneas de texto introducidas en el label (sólo caben 11).
        int lineas = 0;
		private void btnAccion_Click(object sender, EventArgs e)
            {

			// Declaración e inicialización de la variable que recogerá el contenido del TextBox
			string textoNuevo = txtIntroducir.Text;

            // Si la variable lineas ha alcanzado el valor 11 (límite de líneas de texto que caben) entonces se le 
            // asigna un valor 0 y se limpia el label con los mensajes a modo de reinicialización
            if (lineas == 11)
                {
                lineas = 0;
                lblResultado.Text = string.Empty;
                }

			// Se evalúa que la longitud de la cadena introducida en el TextBox sea igual a 0 y no se haya iniciado el Easter Egg
			// si lo es, se añade el texto con el operador += a la variable textoNuevo.

			if ((!(textoNuevo.Length == 0)) && (easterEgg < 1))
                {
                if (lblResultado.Text.Length <= 0)
                    {
                    lblResultado.Text += $"- {textoNuevo}";
                    lineas++;
                    }
				// Si la cadena que hay en el TextBox es la cadena inicial "(su mensaje)" se borra el label y se comienza el contador de líneas
				else if ((lblResultado.Text == "(su mensaje)"))
                    {
                    lblResultado.Text = "";
                    lblResultado.Text += $"- {textoNuevo}";
					lineas = 1;
					}
                // El else interviene en el resto de supuestos en que ya hay alguna línea introducida
                // La nueva línea introducida incorporará un salto de línea para que aparezca debajo de la anterior
                else
                    {
                    lblResultado.Text += $"\n- {textoNuevo}";
					lineas++;
					}
				txtIntroducir.Text = "";
                txtIntroducir.Focus();
                }
            else
                {
				txtIntroducir.Text = "";
				txtIntroducir.Focus();
                }

            // Easter egg

            // No se entra en cada bloque if si no se cumplen varias condiciones
            // La cadena introducida debe corresponder con una de las predeterminadas para iniciar/continuar el diálogo de la canción
            // El valor de la variable easterEgg indica en qué fase del diálogo de la canción nos encontramos

            // Dentro de cada bloque if se añade el texto nuevo a la contestación con sus saltos de línea
            // Se incrementa la variable lineas en 2, salvo la primera vez que se establece en 2 ya que se borra todo el texto precedente

            // La variable easterEgg se incrementa en 1 salvo en el último bloque if que vuelve a tomar el valor 0 para poder reiniciar el Easter Egg

                if ((easterEgg == 0) && ((textoNuevo == "Hola Don Pepito") || (textoNuevo == "Hola, Don Pepito")))
                    {
                    lblResultado.Text = "";
				    textoEasterEgg = $"- ¡{textoNuevo}!\n- Hola, Don José";
                    lblResultado.Text += textoEasterEgg;
                    lineas = 2;
                    easterEgg++;
				    btnBorrar.Text = "Salir";
				    txtIntroducir.Focus();
                    }

				    if ((easterEgg == 1) && ((textoNuevo == "Pasó usted por mi casa") || (textoNuevo == "Pasó usted por mi casa?")
                    || (textoNuevo == "¿Pasó usted por mi casa?") || (textoNuevo == "Paso usted por mi casa")) ||
				    (textoNuevo == "Pasó usted ya por casa") || (textoNuevo == "Pasó usted ya por casa?")
				    || (textoNuevo == "¿Pasó usted ya por casa?") || (textoNuevo == "Paso usted ya por casa"))
                    {
                    textoEasterEgg = $"\n- {textoNuevo}\n- Por su casa yo pasé.";
				    lblResultado.Text += textoEasterEgg;
				    lineas += 2;
				    easterEgg++;
                    txtIntroducir.Focus();
                    }

			    if ((easterEgg == 2) && ((textoNuevo == "Vio usted a mi abuela") || (textoNuevo == "Vio usted a mi abuela?")
                    || (textoNuevo == "¿Vio usted a mi abuela?")))
                    {
				    textoEasterEgg = $"\n- {textoNuevo}\n- ¡A su abuela yo la vi!";
				    lblResultado.Text += textoEasterEgg;
				    lineas += 2;
				    easterEgg++;
                    txtIntroducir.Focus();
                    }

			    if ((easterEgg == 3) && ((textoNuevo == "Adiós Don Pepito") || (textoNuevo == "Adiós, Don Pepito")))
                    {
				    textoEasterEgg = $"\n- ¡{textoNuevo}!\n- ¡Adiós, Don José!";
				    lblResultado.Text += textoEasterEgg;
				    lineas += 2;
				    easterEgg = 0;
				    btnBorrar.Text = "Borrar";
				    txtIntroducir.Focus();
                    }

			}

		private void btnBorrar_Click(object sender, EventArgs e)
			{
            // El botón borrar restablece la variable easterEgg saliendo del Easter Egg
            // La variable lineas la establece en 1 ya que muestra el mensaje: "(su mensaje)" y así entrar en el bloque if 
            // correspondiente del evento click del botón Acción

            lblResultado.Text = "(su mensaje)";
            txtIntroducir.Focus();
			lineas = 1;
			easterEgg = 0;

            // En función de si se está dentro del Easter Egg o no, cambia el título del botón Borrar/Salir
			    if (easterEgg == 0)
                    btnBorrar.Text = "Borrar";
                else
                {
                    btnBorrar.Text = "Salir";
                }
			}
		}
}
