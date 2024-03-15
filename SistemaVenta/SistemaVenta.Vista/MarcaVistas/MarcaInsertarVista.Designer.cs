namespace SistemaVenta.Vista.MarcaVistas
{
	partial class MarcaInsertarVista
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
			textBox1 = new TextBox();
			label1 = new Label();
			label2 = new Label();
			button2 = new Button();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(159, 182);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 0;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(159, 113);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(227, 27);
			textBox1.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(138, 33);
			label1.Name = "label1";
			label1.Size = new Size(179, 20);
			label1.TabIndex = 2;
			label1.Text = "INSERTAR DATOS MARCA";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(50, 116);
			label2.Name = "label2";
			label2.Size = new Size(70, 20);
			label2.TabIndex = 3;
			label2.Text = "NOMBRE";
			// 
			// button2
			// 
			button2.Location = new Point(273, 182);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 4;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// MarcaInsertarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(528, 280);
			Controls.Add(button2);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBox1);
			Controls.Add(button1);
			Name = "MarcaInsertarVista";
			Text = "MarcaInsertarVista";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private TextBox textBox1;
		private Label label1;
		private Label label2;
		private Button button2;
	}
}