/*
 * Created by SharpDevelop.
 * User: CC2-PC44
 * Date: 31/10/2024
 * Time: 02:29 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto
{
	partial class Matesc
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txta = new System.Windows.Forms.TextBox();
			this.txtp = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"ALCALA LARA EDGAR",
									"ALCANTAR GONZALEZ MARTHA MELISA",
									"ALMANZA LOPEZ DAVID",
									"ALVAREZ CEJA JORGE LUIS",
									"BALLESTEROS DIAZ RAMSES",
									"BARRIENTOS VITAL ANGEL DAVID",
									"CALDERON MORA JUAN EMILIANO",
									"CAMARENA RAMIREZ JOSE MIGUEL",
									"CASTAÑEDA MARTINEZ JUAN ANTONIO",
									"CHAVEZ SAMANO CRISTOPHER ALEJANDRO",
									"DIEGO CHACON DULCE MARIA",
									"FERREYRA GUZMAN AMERICA JANETH",
									"FUENTES PEREZ DIEGO JAVIER",
									"GARCIA ALLYSEN",
									"GARCIA MARTINEZ JOSE JULIAN",
									"GARCIA MASCOTE MIGUEL ALEJANDRO",
									"GONZALEZ DIAZ JUAN RAFAEL",
									"GONZALEZ GONZALEZ JUAN PABLO",
									"GONZALEZ ZAVALA MARIANA MARGARITA",
									"GORDILLO AGUILAR LEONARDO",
									"GORDILLO BAUTISTA ANGEL ISAAC",
									"GUTIERREZ MARTINEZ YUREM",
									"GUZMAN MARTINEZ FRANCISCO EMILIANO",
									"JUAREZ CUEVAS KAROL",
									"LOPEZ GARCIA YAEL",
									"LOPEZ YAÑEZ CINTIA GUADALUPE",
									"MARTINEZ GUZMAN HUGO ANTONIO",
									"MASCOTE REYES EMMANUEL",
									"MORALES ALARCON JESSICA SARAI",
									"MORENO DOMINGUEZ VICTOR HUGO",
									"NIETO OROZCO DANA CAMILA",
									"NUÑEZ HERRERA MIGUEL ANGEL",
									"OROZCO PEREZ VICTOR MANUEL",
									"PEREZ MENDEZ MIGUEL ALEJANDRO",
									"PEREZ VAZQUEZ KEVIN DANIEL",
									"PIEDRA GARCIA ISRAEL",
									"QUINTINO GUZMAN ARIANA",
									"RAMIREZ LOPEZ GERARDO ISAAC",
									"RAYMUNDO RODRIGUEZ JIMENA",
									"ROCHA GARNICA JOCELIN",
									"ROMERO AVILA MICHELLE",
									"RUIZ DAMIAN YADHIRA",
									"RUIZ JIMENEZ ALAN JOSUE",
									"SANCHEZ RODRIGUEZ GERARDO",
									"SOLIS MOJICA JUAN DAVID",
									"TAPIA ALCANTAR FATIMA AVRIL",
									"TENORIO IZQUIERDO VICTOR ANTHUAN",
									"VILLAGOMEZ ESPINOZA JOSHUA CESAR",
									"ZAVALA GARCIA JOSE DE JESUS",
									"ZAVALA GONZALEZ DAYANA CAROLINA",
									"ZAVALA PEREDO OBED ASAEL",
									"GONZALEZ VAZQUEZ ALAN ALEXIS",
									"SALON"});
			this.comboBox1.Location = new System.Drawing.Point(68, 33);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(206, 21);
			this.comboBox1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 240);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Promedio";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(301, 240);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Cantidad aprobados";
			// 
			// txta
			// 
			this.txta.Location = new System.Drawing.Point(433, 237);
			this.txta.Name = "txta";
			this.txta.Size = new System.Drawing.Size(100, 20);
			this.txta.TabIndex = 3;
			// 
			// txtp
			// 
			this.txtp.Location = new System.Drawing.Point(97, 237);
			this.txtp.Name = "txtp";
			this.txtp.Size = new System.Drawing.Size(100, 20);
			this.txtp.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(413, 31);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(93, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Mostrar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(38, 339);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(113, 31);
			this.button2.TabIndex = 6;
			this.button2.Text = "<";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// Matesc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(565, 409);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtp);
			this.Controls.Add(this.txta);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Name = "Matesc";
			this.Text = "Matesc";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txtp;
		private System.Windows.Forms.TextBox txta;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}
