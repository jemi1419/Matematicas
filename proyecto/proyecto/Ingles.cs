/*
 * Created by SharpDevelop.
 * User: CC2_PC43
 * Date: 24/10/2024
 * Time: 04:23 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace proyecto
{
	/// <summary>
	/// Description of Ingles.
	/// </summary>
	public partial class Ingles : Form
	{
		//numero de verbos
			int n = 24;
			//verbos
			
			
			String[] verb_present = {"Accept", "Do","Answer", "Be", "Arrive", "Choose", "Ask", "Fall",
				"Belong", "Know", "Change", "Write", "Clean", "Swim", "Close", "Give",
				"Consider", "See", "Cook", "Wake", "Count","Drink", "Dance", 
				"Go", "Take", };
			String[] verb_tense = {"Accepted", "Did", "Answered", "Was/Were", "Arrived", "Chose", "Asked", "Fell", 
			"Belonged", "Knew", "Changed", "Wrote", "Cleaned", "Swam", "Closed", "Gave",
			"Considered", "Saw","Cooked", "Woke","Counted", "Drank", "Danced",
			"Went", "Took"};
			String[] verb_participle = {"Accepted", "Done", "Answered", "Been", "Arrived", "Choosen", "Asked", "Fallen",
					"Belonged", "Known", "Changed", "Written", "Cleaned", "Swum","Closed", "Given",
					"Considered", "Seen", "Cooked", "Woken", "Counted","Drunk", "Danced",
				"Gone", "Taken"};
			String[] verb_gerund = {"Accepting", "Doing", "Answering", "Being", "Arriving", "Choosing", "Asking", "Falling",
			"Belonging", "Knowing", "Changing", "Writing", "Cleaning", "Swimming", "Closing", "Giving", 
			"Considering", "Seeing","Cooking", "Waking", "Counting", "Drinking", "Dancing",
			"Going", "Taking"};
			//Declarar i aniadir oqziones a somvobos
			
		//Declarar i aniadir oqziones a somvobos
			private String[] verb_spanish = {
			"Aceptar", "Hacer", "Contestar", "Estar/Ser", "Llegar", "Elegir", "Preguntar", "Caer",
			"Pertenecer", "Conocer", "Cambiar", "Escribir", "Limpiar", "Nadar", "Cerrar", "Dar",
			"Considerar", "Ver", "Cocinar", "Despertar", "Contar", "Beber", "Bailar", 
			"Ir", "Tomar"};
		public Ingles()
		{
			
			 
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
			
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			string unos = "a";
			for (int i = 0; i<n; i++)
			{
				string comp = comboBox1.SelectedItem.ToString();
				if (verb_spanish[i]==comp)
				{
					unos = verb_present[i];
				}
			}
			SpeechSynthesizer uno = new SpeechSynthesizer();
			uno.SpeakAsync(unos);
			//obtener y saber cual es de "numero"
			
		}
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
			//obtener y saber cual es de "numero"
			for (int i = 0; i<n; i++)
			{
				string comp = comboBox1.SelectedItem.ToString();
				if (verb_spanish[i]==comp)
				{
					label5.Text = verb_present[i];
					label6.Text = verb_tense[i];
					label7.Text = verb_participle[i];
					label8.Text = verb_gerund[i];
				}
			}
			//para evitar que no ponga nada jijijiji, soy tan listo
			panel1.Visible = true;
		}
		
		void InglesLoad(object sender, EventArgs e)
		{
			comboBox1.Items.AddRange(verb_spanish);
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			string unos = "a";
			for (int i = 0; i<n; i++)
			{
				string comp = comboBox1.SelectedItem.ToString();
				if (verb_spanish[i]==comp)
				{
					unos = verb_tense[i];
				}
			}
			SpeechSynthesizer uno = new SpeechSynthesizer();
			uno.SpeakAsync(unos);
			//obtener y saber cual es de "numero"
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			string unos = "a";
			for (int i = 0; i<n; i++)
			{
				string comp = comboBox1.SelectedItem.ToString();
				if (verb_spanish[i]==comp)
				{
					unos = verb_participle[i];
				}
			}
			SpeechSynthesizer uno = new SpeechSynthesizer();
			uno.SpeakAsync(unos);
			//obtener y saber cual es de "numero"
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string unos = "a";
			for (int i = 0; i<n; i++)
			{
				string comp = comboBox1.SelectedItem.ToString();
				if (verb_spanish[i]==comp)
			{
				unos = verb_gerund[i];
			}
				
			}
			
			SpeechSynthesizer uno = new SpeechSynthesizer();
			//obtener y saber cual es de "numero"
			uno.SpeakAsync(unos);
		}
	}
}
