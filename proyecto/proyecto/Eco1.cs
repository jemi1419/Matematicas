/*
 * Created by SharpDevelop.
 * User: tapia
 * Date: 30/10/2024
 * Time: 04:08 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto
{
	/// <summary>
	/// Description of Eco1.
	/// </summary>
	public partial class Eco1 : Form
	{
		public Eco1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Eco2 Eco2 = new Eco2();
			Eco2.Show();
		}
	}
}
