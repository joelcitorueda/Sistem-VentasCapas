namespace SistemaVenta.Vista.ProductoVistas
{
	partial class ProductoInsertarVista
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
			button1 = new Button();
			label1 = new Label();
			textBox1 = new TextBox();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			label7 = new Label();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			textBox4 = new TextBox();
			textBox5 = new TextBox();
			textBox6 = new TextBox();
			button2 = new Button();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(130, 427);
			button1.Name = "button1";
			button1.Size = new Size(127, 35);
			button1.TabIndex = 0;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(160, 21);
			label1.Name = "label1";
			label1.Size = new Size(204, 20);
			label1.TabIndex = 1;
			label1.Text = "INSERTAR DATOS PRODUCTO";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(201, 72);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(225, 27);
			textBox1.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(5, 75);
			label2.Name = "label2";
			label2.Size = new Size(139, 20);
			label2.TabIndex = 3;
			label2.Text = "ID TIPO PRODUCTO";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(65, 138);
			label3.Name = "label3";
			label3.Size = new Size(79, 20);
			label3.TabIndex = 4;
			label3.Text = "ID MARCA";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(74, 196);
			label4.Name = "label4";
			label4.Size = new Size(70, 20);
			label4.TabIndex = 5;
			label4.Text = "NOMBRE";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(5, 249);
			label5.Name = "label5";
			label5.Size = new Size(139, 20);
			label5.TabIndex = 6;
			label5.Text = "CODIGO DE BARRA";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(78, 298);
			label6.Name = "label6";
			label6.Size = new Size(66, 20);
			label6.TabIndex = 7;
			label6.Text = "UNIDAD";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(43, 346);
			label7.Name = "label7";
			label7.Size = new Size(101, 20);
			label7.TabIndex = 8;
			label7.Text = "DESCRIPCION";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(201, 135);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(225, 27);
			textBox2.TabIndex = 9;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(201, 193);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(225, 27);
			textBox3.TabIndex = 10;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(201, 246);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(225, 27);
			textBox4.TabIndex = 11;
			// 
			// textBox5
			// 
			textBox5.Location = new Point(201, 295);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(225, 27);
			textBox5.TabIndex = 12;
			// 
			// textBox6
			// 
			textBox6.Location = new Point(201, 343);
			textBox6.Name = "textBox6";
			textBox6.Size = new Size(225, 27);
			textBox6.TabIndex = 13;
			// 
			// button2
			// 
			button2.Location = new Point(321, 427);
			button2.Name = "button2";
			button2.Size = new Size(127, 35);
			button2.TabIndex = 14;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// ProductoInsertarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(556, 485);
			Controls.Add(button2);
			Controls.Add(textBox6);
			Controls.Add(textBox5);
			Controls.Add(textBox4);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Controls.Add(button1);
			Name = "ProductoInsertarVista";
			Text = "ProductoInsertarVista";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private Label label1;
		private TextBox textBox1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private TextBox textBox2;
		private TextBox textBox3;
		private TextBox textBox4;
		private TextBox textBox5;
		private TextBox textBox6;
		private Button button2;
	}
}