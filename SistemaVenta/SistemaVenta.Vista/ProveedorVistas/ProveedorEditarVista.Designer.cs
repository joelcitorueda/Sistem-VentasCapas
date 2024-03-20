namespace SistemaVenta.Vista.ProveedorVistas
{
	partial class ProveedorEditarVista
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			button2 = new Button();
			button1 = new Button();
			textBox3 = new TextBox();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			SuspendLayout();
			// 
			// button2
			// 
			button2.Location = new Point(309, 324);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 17;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.Location = new Point(135, 324);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 16;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(169, 243);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(263, 27);
			textBox3.TabIndex = 15;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(169, 187);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(263, 27);
			textBox2.TabIndex = 14;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(169, 124);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(263, 27);
			textBox1.TabIndex = 13;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(52, 246);
			label4.Name = "label4";
			label4.Size = new Size(85, 20);
			label4.TabIndex = 12;
			label4.Text = "DIRECCION";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(57, 187);
			label3.Name = "label3";
			label3.Size = new Size(80, 20);
			label3.TabIndex = 11;
			label3.Text = "TELEFONO";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(67, 127);
			label2.Name = "label2";
			label2.Size = new Size(70, 20);
			label2.TabIndex = 10;
			label2.Text = "NOMBRE";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(180, 49);
			label1.Name = "label1";
			label1.Size = new Size(198, 20);
			label1.TabIndex = 9;
			label1.Text = "Insertar Datos del Proveedor";
			// 
			// ProveedorEditarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(534, 408);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "ProveedorEditarVista";
			Text = "ProveedorEditarVista";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button2;
		private Button button1;
		private TextBox textBox3;
		private TextBox textBox2;
		private TextBox textBox1;
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
	}
}