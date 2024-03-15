namespace SistemaVenta.Vista.IngresoVistas
{
	partial class IngresoInsertarVista
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
			label1 = new Label();
			textBox1 = new TextBox();
			button1 = new Button();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			button2 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(140, 36);
			label1.Name = "label1";
			label1.Size = new Size(216, 20);
			label1.TabIndex = 0;
			label1.Text = "INGRESAR DATOS DE INGRESO";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(174, 113);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(242, 27);
			textBox1.TabIndex = 1;
			// 
			// button1
			// 
			button1.Location = new Point(164, 337);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 2;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(24, 116);
			label2.Name = "label2";
			label2.Size = new Size(112, 20);
			label2.TabIndex = 3;
			label2.Text = "ID PROVEEDOR";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(17, 177);
			label3.Name = "label3";
			label3.Size = new Size(119, 20);
			label3.TabIndex = 4;
			label3.Text = "FECHA INGRESO";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(86, 249);
			label4.Name = "label4";
			label4.Size = new Size(50, 20);
			label4.TabIndex = 5;
			label4.Text = "TOTAL";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(174, 177);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(242, 27);
			textBox2.TabIndex = 6;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(174, 249);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(242, 27);
			textBox3.TabIndex = 7;
			// 
			// button2
			// 
			button2.Location = new Point(301, 337);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 8;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// IngresoInsertarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(494, 450);
			Controls.Add(button2);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Name = "IngresoInsertarVista";
			Text = "IngresoInsertarVista";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox textBox1;
		private Button button1;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox textBox2;
		private TextBox textBox3;
		private Button button2;
	}
}