﻿/*
 * Created by SharpDevelop.
 * User: CC2_PC12
 * Date: 29/10/2024
 * Time: 08:01 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto
{
	/// <summary>
	/// Description of Fisica4.
	/// </summary>
	public partial class Fisica4 : Form
	{
		public Fisica4()
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
			double d, t, v;
			d = double.Parse(textBox1.Text);
			t = double.Parse(textBox2.Text);
			v=d/t;
			label5.Text=v.ToString();
			
				
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
