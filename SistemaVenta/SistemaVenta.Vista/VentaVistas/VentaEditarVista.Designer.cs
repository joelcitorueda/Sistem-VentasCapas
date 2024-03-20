namespace SistemaVenta.Vista.VentaVistas
{
	partial class VentaEditarVista
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
			button4 = new Button();
			button3 = new Button();
			button2 = new Button();
			textBox4 = new TextBox();
			textBox3 = new TextBox();
			textBox2 = new TextBox();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			textBox1 = new TextBox();
			label1 = new Label();
			button1 = new Button();
			SuspendLayout();
			// 
			// button4
			// 
			button4.Location = new Point(436, 142);
			button4.Name = "button4";
			button4.Size = new Size(125, 29);
			button4.TabIndex = 25;
			button4.Text = "SELECCIONAR";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button3
			// 
			button3.Location = new Point(436, 93);
			button3.Name = "button3";
			button3.Size = new Size(125, 29);
			button3.TabIndex = 24;
			button3.Text = "SELECCIONAR";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button2
			// 
			button2.Location = new Point(311, 311);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 23;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(161, 243);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(244, 27);
			textBox4.TabIndex = 22;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(161, 193);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(244, 27);
			textBox3.TabIndex = 21;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(161, 142);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(244, 27);
			textBox2.TabIndex = 20;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(79, 246);
			label5.Name = "label5";
			label5.Size = new Size(50, 20);
			label5.TabIndex = 19;
			label5.Text = "TOTAL";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(75, 196);
			label4.Name = "label4";
			label4.Size = new Size(54, 20);
			label4.TabIndex = 18;
			label4.Text = "FECHA";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(23, 145);
			label3.Name = "label3";
			label3.Size = new Size(106, 20);
			label3.TabIndex = 17;
			label3.Text = "ID VENDEDOR";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(46, 98);
			label2.Name = "label2";
			label2.Size = new Size(83, 20);
			label2.TabIndex = 16;
			label2.Text = "ID CLIENTE";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(161, 95);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(244, 27);
			textBox1.TabIndex = 15;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(183, 46);
			label1.Name = "label1";
			label1.Size = new Size(163, 20);
			label1.TabIndex = 14;
			label1.Text = "INSERTE DATOS VENTA";
			// 
			// button1
			// 
			button1.Location = new Point(173, 311);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 13;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// VentaEditarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(602, 366);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(textBox4);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Controls.Add(button1);
			Name = "VentaEditarVista";
			Text = "VentaEditarVista";
			Load += VentaEditarVista_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button4;
		private Button button3;
		private Button button2;
		private TextBox textBox4;
		private TextBox textBox3;
		private TextBox textBox2;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private TextBox textBox1;
		private Label label1;
		private Button button1;
	}
}