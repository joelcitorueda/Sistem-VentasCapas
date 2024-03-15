namespace SistemaVenta.Vista.UsuarioRolVistas
{
	partial class UsuarioRolInsertarVista
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
			button2 = new Button();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(145, 334);
			button1.Name = "button1";
			button1.Size = new Size(100, 38);
			button1.TabIndex = 0;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(198, 35);
			label1.Name = "label1";
			label1.Size = new Size(234, 20);
			label1.TabIndex = 1;
			label1.Text = "INSERTE DATOS DE USUARIO ROL";
			label1.Click += label1_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(232, 126);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(217, 27);
			textBox1.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(110, 126);
			label2.Name = "label2";
			label2.Size = new Size(90, 20);
			label2.TabIndex = 3;
			label2.Text = "ID USUARIO";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(145, 183);
			label3.Name = "label3";
			label3.Size = new Size(55, 20);
			label3.TabIndex = 4;
			label3.Text = "ID ROL";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(68, 240);
			label4.Name = "label4";
			label4.Size = new Size(132, 20);
			label4.TabIndex = 5;
			label4.Text = "FECHA ASIGNADA";
			// 
			// button2
			// 
			button2.Location = new Point(306, 334);
			button2.Name = "button2";
			button2.Size = new Size(100, 38);
			button2.TabIndex = 6;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(232, 183);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(217, 27);
			textBox2.TabIndex = 7;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(232, 240);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(217, 27);
			textBox3.TabIndex = 8;
			// 
			// UsuarioRolInsertarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(554, 420);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(button2);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Controls.Add(button1);
			Name = "UsuarioRolInsertarVista";
			Text = "UsuarioRolInsertarVista";
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
		private Button button2;
		private TextBox textBox2;
		private TextBox textBox3;
	}
}