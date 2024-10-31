/*
 * Created by SharpDevelop.
 * User: CC2-PC44
 * Date: 31/10/2024
 * Time: 03:02 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto
{
	partial class Matesp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Matesp));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnc = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.Parcial1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.txt3 = new System.Windows.Forms.TextBox();
			this.txtp = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(154, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(246, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Promedio";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(541, 90);
			this.label2.TabIndex = 1;
			this.label2.Text = resources.GetString("label2.Text");
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(16, 215);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(247, 183);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// btnc
			// 
			this.btnc.Location = new System.Drawing.Point(519, 356);
			this.btnc.Name = "btnc";
			this.btnc.Size = new System.Drawing.Size(126, 32);
			this.btnc.TabIndex = 3;
			this.btnc.Text = "Calcular";
			this.btnc.UseVisualStyleBackColor = true;
			this.btnc.Click += new System.EventHandler(this.BtncClick);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(16, 424);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(113, 31);
			this.button2.TabIndex = 7;
			this.button2.Text = "<";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// Parcial1
			// 
			this.Parcial1.Location = new System.Drawing.Point(328, 191);
			this.Parcial1.Name = "Parcial1";
			this.Parcial1.Size = new System.Drawing.Size(55, 33);
			this.Parcial1.TabIndex = 8;
			this.Parcial1.Text = "Parcial1";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(412, 191);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 33);
			this.label3.TabIndex = 9;
			this.label3.Text = "Parcial2";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(502, 191);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 33);
			this.label4.TabIndex = 10;
			this.label4.Text = "Parcial3";
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(326, 226);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(56, 20);
			this.txt1.TabIndex = 11;
			// 
			// txt2
			// 
			this.txt2.Location = new System.Drawing.Point(412, 226);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(56, 20);
			this.txt2.TabIndex = 12;
			// 
			// txt3
			// 
			this.txt3.Location = new System.Drawing.Point(501, 226);
			this.txt3.Name = "txt3";
			this.txt3.Size = new System.Drawing.Size(56, 20);
			this.txt3.TabIndex = 13;
			// 
			// txtp
			// 
			this.txtp.Location = new System.Drawing.Point(381, 363);
			this.txtp.Name = "txtp";
			this.txtp.Size = new System.Drawing.Size(86, 20);
			this.txtp.TabIndex = 14;
			// 
			// Matesp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(713, 467);
			this.Controls.Add(this.txtp);
			this.Controls.Add(this.txt3);
			this.Controls.Add(this.txt2);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Parcial1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnc);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Matesp";
			this.Text = "Matesp";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox txtp;
		private System.Windows.Forms.TextBox txt3;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label Parcial1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnc;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
