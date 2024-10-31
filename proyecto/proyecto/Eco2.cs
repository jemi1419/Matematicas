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
	/// Description of Eco2.
	/// </summary>
	public partial class Eco2 : Form
	{
		public Eco2()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			Eco3 Eco3 = new Eco3();
			Eco3.Show();
		}
		
		void PictureBox2Click(object sender, EventArgs e)
		{
			Eco4 Eco4 = new Eco4();
			Eco4.Show();
		}
		
		void PictureBox3Click(object sender, EventArgs e)
		{
			Eco5 Eco5 = new Eco5();
			Eco5.Show();
		}
		
		void PictureBox4Click(object sender, EventArgs e)
		{
			Eco6 Eco6 = new Eco6();
			Eco6.Show();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Eco7 Eco7 = new Eco7();
			Eco7.Show();
		}
	}
}
