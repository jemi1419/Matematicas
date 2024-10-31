/*
 * Created by SharpDevelop.
 * User: CC2_PC12
 * Date: 29/10/2024
 * Time: 08:01 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto
{
	partial class Fisica4
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
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(196, 35);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(328, 74);
			this.label1.TabIndex = 0;
			this.label1.Text = "Calculo de Velocidad";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(38, 254);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 35);
			this.label2.TabIndex = 1;
			this.label2.Text = "Distancia (d)";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(38, 415);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(110, 35);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tiempo (t)";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(196, 258);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(148, 26);
			this.textBox1.TabIndex = 3;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(196, 414);
			this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(148, 26);
			this.textBox2.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(411, 346);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 32);
			this.label4.TabIndex = 5;
			this.label4.Text = "V=";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(470, 346);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(150, 35);
			this.label5.TabIndex = 6;
			this.label5.Text = "_________________";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(336, 134);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(66, 37);
			this.label6.TabIndex = 7;
			this.label6.Text = "V=d/t";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(492, 440);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 35);
			this.button1.TabIndex = 8;
			this.button1.Text = "Calcular";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(54, 289);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(93, 35);
			this.label7.TabIndex = 9;
			this.label7.Text = "en metros";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(27, 526);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(99, 32);
			this.button2.TabIndex = 10;
			this.button2.Text = "<";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(54, 452);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 11;
			this.label8.Text = "Segundos";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(613, 350);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 12;
			this.label9.Text = "/s";
			// 
			// Fisica4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(738, 570);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Fisica4";
			this.Text = "Fisica4";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
