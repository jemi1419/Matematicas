/*
 * Created by SharpDevelop.
 * User: CC2-PC44
 * Date: 31/10/2024
 * Time: 03:18 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto
{
	partial class ModayMediana
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModayMediana));
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(176, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(179, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Moda y Mediana";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(562, 148);
			this.label1.TabIndex = 2;
			this.label1.Text = resources.GetString("label1.Text");
			// 
			// ModayMediana
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(577, 394);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Name = "ModayMediana";
			this.Text = "ModayMediana";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
