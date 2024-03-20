namespace SistemaVenta.Vista.RolVistas
{
	partial class RolEditarVista
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
			label2 = new Label();
			textBox1 = new TextBox();
			button1 = new Button();
			label1 = new Label();
			SuspendLayout();
			// 
			// button2
			// 
			button2.Location = new Point(253, 174);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 9;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(32, 117);
			label2.Name = "label2";
			label2.Size = new Size(70, 20);
			label2.TabIndex = 8;
			label2.Text = "NOMBRE";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(136, 114);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(211, 27);
			textBox1.TabIndex = 7;
			// 
			// button1
			// 
			button1.Location = new Point(110, 174);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 6;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(125, 36);
			label1.Name = "label1";
			label1.Size = new Size(137, 20);
			label1.TabIndex = 5;
			label1.Text = "INSERTE DATO ROL";
			// 
			// RolEditarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(445, 259);
			Controls.Add(button2);
			Controls.Add(label2);
			Controls.Add(textBox1);
			Controls.Add(button1);
			Controls.Add(label1);
			Name = "RolEditarVista";
			Text = "RolEditarVista";
			Load += RolEditarVista_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button2;
		private Label label2;
		private TextBox textBox1;
		private Button button1;
		private Label label1;
	}
}