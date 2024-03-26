namespace SistemaVenta.Vista.ClienteVistas
{
	partial class ClienteInsertarVista
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
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(256, 52);
			label1.Name = "label1";
			label1.Size = new Size(141, 20);
			label1.TabIndex = 0;
			label1.Text = "INSERTAR CLIENTES";
			label1.Click += label1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(88, 127);
			label2.Name = "label2";
			label2.Size = new Size(93, 20);
			label2.TabIndex = 1;
			label2.Text = "ID PERSONA";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(82, 183);
			label3.Name = "label3";
			label3.Size = new Size(99, 20);
			label3.TabIndex = 2;
			label3.Text = "TIPO CLIENTE";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(57, 241);
			label4.Name = "label4";
			label4.Size = new Size(124, 20);
			label4.TabIndex = 3;
			label4.Text = "CODIGO CLIENTE";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(105, 277);
			label5.Name = "label5";
			label5.Size = new Size(0, 20);
			label5.TabIndex = 4;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(226, 124);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(218, 27);
			textBox1.TabIndex = 5;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(226, 180);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(218, 27);
			textBox2.TabIndex = 6;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(226, 238);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(218, 27);
			textBox3.TabIndex = 7;
			// 
			// button1
			// 
			button1.DialogResult = DialogResult.OK;
			button1.Location = new Point(204, 313);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 8;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(366, 313);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 9;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Location = new Point(485, 127);
			button3.Name = "button3";
			button3.Size = new Size(118, 29);
			button3.TabIndex = 10;
			button3.Text = "SELECCIONAR";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// ClienteInsertarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(677, 450);
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
			Controls.Add(label1);
			Name = "ClienteInsertarVista";
			Text = "ClienteInsertarVista";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private Button button1;
		private Button button2;
		private Button button3;
	}
}