﻿/*
 * Created by SharpDevelop.
 * User: CC2_PC43
 * Date: 24/10/2024
 * Time: 04:22 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto
{
	/// <summary>
	/// Description of Mates.
	/// </summary>
	public partial class Mates : Form
	{
		public Mates()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void BtncClick(object sender, EventArgs e)
		{
			Matesc Matesc=new Matesc();
			Matesc.Show();
		}
		void BtnpClick(object sender, EventArgs e)
		{
			Matesp Matesp=new Matesp();
			Matesp.Show();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
						
		}
	}
}
