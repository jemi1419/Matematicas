/*
 * Created by SharpDevelop.
 * User: CC2-PC44
 * Date: 31/10/2024
 * Time: 03:02 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto
{
	/// <summary>
	/// Description of Matesp.
	/// </summary>
	public partial class Matesp : Form
	{
		public Matesp()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BtncClick(object sender, EventArgs e)
		{
			double u, d, t, p;
			u = double.Parse(txt1.Text);
			d = double.Parse(txt2.Text);
			t = double.Parse(txt3.Text);
			t = u+d+t;
			t = t/3;
			txtp.Text = t.ToString();
		}
	}
}
