namespace SistemaVenta.Vista.ClienteVistas
{
	partial class ClienteEditarVista
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
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			button3 = new Button();
			SuspendLayout();
			// 
			// button2
			// 
			button2.Location = new Point(274, 265);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 18;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.Location = new Point(103, 265);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 17;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(212, 178);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(218, 27);
			textBox3.TabIndex = 16;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(212, 120);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(218, 27);
			textBox2.TabIndex = 15;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(212, 64);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(218, 27);
			textBox1.TabIndex = 14;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(91, 217);
			label5.Name = "label5";
			label5.Size = new Size(0, 20);
			label5.TabIndex = 13;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(43, 181);
			label4.Name = "label4";
			label4.Size = new Size(124, 20);
			label4.TabIndex = 12;
			label4.Text = "CODIGO CLIENTE";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(68, 123);
			label3.Name = "label3";
			label3.Size = new Size(99, 20);
			label3.TabIndex = 11;
			label3.Text = "TIPO CLIENTE";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(74, 67);
			label2.Name = "label2";
			label2.Size = new Size(93, 20);
			label2.TabIndex = 10;
			label2.Text = "ID PERSONA";
			// 
			// button3
			// 
			button3.Location = new Point(468, 64);
			button3.Name = "button3";
			button3.Size = new Size(118, 29);
			button3.TabIndex = 19;
			button3.Text = "SELECCIONAR";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// ClienteEditarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(614, 334);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Name = "ClienteEditarVista";
			Text = "ClienteEditarVista";
			Load += ClienteEditarVista_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button2;
		private Button button1;
		private TextBox textBox3;
		private TextBox textBox2;
		private TextBox textBox1;
		private Label label5;
		private Label label4;
		private Label label3;
		private Label label2;
		private Button button3;
	}
}