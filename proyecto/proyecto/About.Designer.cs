﻿/*
 * Created by SharpDevelop.
 * User: CC2_PC43
 * Date: 24/10/2024
 * Time: 04:14 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto
{
	partial class About
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(81, 49);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 35);
			this.label1.TabIndex = 0;
			this.label1.Text = "Version";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(202, 49);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 35);
			this.label2.TabIndex = 1;
			this.label2.Text = "1.0";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(13, 486);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 35);
			this.button1.TabIndex = 2;
			this.button1.Text = "<";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(81, 119);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(271, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Menu por: Leonardo Gordillo Aguilar";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(81, 409);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(329, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Ecosistemas por: Fátima Avril Tapia Alcantár";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(81, 286);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(321, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "Ingles por: Miguel Alejandro Gracía Mascote";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(81, 351);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(271, 23);
			this.label6.TabIndex = 6;
			this.label6.Text = "Fisica por: Leonardo Gordillo Aguilar";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(81, 229);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(380, 23);
			this.label7.TabIndex = 7;
			this.label7.Text = "Huamidades por: Dayana Carolina Zavala Gonzalez";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(81, 173);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(353, 23);
			this.label8.TabIndex = 8;
			this.label8.Text = "Matematicas por: Juan Emiliano Calderón Mora ";
			// 
			// About
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(494, 535);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "About";
			this.Text = "About";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
