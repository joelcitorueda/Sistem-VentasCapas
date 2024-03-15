namespace SistemaVenta.Vista.UsuarioVistas
{
	partial class UsuarioInsertarVista
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
			button2 = new Button();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			textBox4 = new TextBox();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(130, 331);
			button1.Name = "button1";
			button1.Size = new Size(119, 34);
			button1.TabIndex = 0;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(168, 29);
			label1.Name = "label1";
			label1.Size = new Size(180, 20);
			label1.TabIndex = 1;
			label1.Text = "INSERTE DATOS USUARIO";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(227, 100);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(229, 27);
			textBox1.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(93, 103);
			label2.Name = "label2";
			label2.Size = new Size(93, 20);
			label2.TabIndex = 3;
			label2.Text = "ID PERSONA";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(27, 156);
			label3.Name = "label3";
			label3.Size = new Size(159, 20);
			label3.TabIndex = 4;
			label3.Text = "NOMBRE DE USUARIO";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(82, 210);
			label4.Name = "label4";
			label4.Size = new Size(104, 20);
			label4.TabIndex = 5;
			label4.Text = "CONTRASEÑA";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(132, 264);
			label5.Name = "label5";
			label5.Size = new Size(54, 20);
			label5.TabIndex = 6;
			label5.Text = "FECHA";
			// 
			// button2
			// 
			button2.Location = new Point(337, 331);
			button2.Name = "button2";
			button2.Size = new Size(119, 34);
			button2.TabIndex = 7;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(227, 153);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(229, 27);
			textBox2.TabIndex = 8;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(227, 207);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(229, 27);
			textBox3.TabIndex = 9;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(227, 261);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(229, 27);
			textBox4.TabIndex = 10;
			// 
			// UsuarioInsertarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(527, 409);
			Controls.Add(textBox4);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(button2);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Controls.Add(button1);
			Name = "UsuarioInsertarVista";
			Text = "UsuarioInsertarVista";
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
		private Button button2;
		private TextBox textBox2;
		private TextBox textBox3;
		private TextBox textBox4;
	}
}