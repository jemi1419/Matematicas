/*
 * Created by SharpDevelop.
 * User: tapia
 * Date: 30/10/2024
 * Time: 04:24 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto
{
	partial class Eco3
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eco3));
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(59, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(189, 23);
			this.label2.TabIndex = 9;
			this.label2.Text = "DESIERTO POLAR:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(59, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(205, 107);
			this.label1.TabIndex = 10;
			this.label1.Text = "Los desiertos polares son áreas con precipitaciones anuales inferiores a 250 mm y" +
			" una temperatura media en el mes más cálido del año de inferior a 10 °C.";
			// 
			// Eco3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(313, 237);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Name = "Eco3";
			this.Text = "Eco3";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}
