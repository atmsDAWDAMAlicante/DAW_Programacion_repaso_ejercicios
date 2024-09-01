using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Prog_Tema_3_Ej_30
	{
	public partial class Prog_Tema_3_Ej_30 : Form
		{
		// Declaración e inicialización de una variable global entera 'intento'
		public int intento = 3;
		public Prog_Tema_3_Ej_30()
			{
			InitializeComponent();
			}

		private void btnAcceder_Click(object sender, EventArgs e)
			{
			// Una variable global 'intento' indica qué intento es aquel en que se está al hacer click en el botón
			string usuario = txtUsuario.Text;
			string password = txtPassword.Text;

			// 1º se evalúa que si lo introducido se corresponde con la combinación correcta, en cuyo caso muestra los mensajes correspondientes
			// y reestablece la variable 'intento' al valor 3
			if ((usuario=="root") && (password== "1234"))
				{
				lblSubtitulo.Text = "Bienvenido al Sistema";
				btnAcceder.Text = "Salir?";
				intento = 3;
				}
			// En caso contrario, en el supuesto de introducir una combinación incorrecta,
			// se decrementa la variable 'intento' y se evalúa si es mayor que 0.
			else
				{
				intento--;
				//  Si 'intento' es mayor que 0 se imprime el mensaje correspondiente
				if ((intento > 0) && (intento <=2))
					{
					lblSubtitulo.Text = $"Tienes {intento} intentos: ";
					btnAcceder.Text = "Acceder";
					}
				// Si la variable 'intento' llega a tomar el valor 0, se modifica el mensaje por pantalla y se reestablece a 3
				else
					{
					btnAcceder.Text = "Reintentar?";
					lblSubtitulo.Text = $"Superado el nº de intentos.";
					intento = 3;
					}
				}
			}
		}
	}
