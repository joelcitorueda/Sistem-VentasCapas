namespace SistemaVenta.Vista.RolVistas
{
	partial class RolInsertarVista
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
			button1 = new Button();
			textBox1 = new TextBox();
			label2 = new Label();
			button2 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(132, 22);
			label1.Name = "label1";
			label1.Size = new Size(137, 20);
			label1.TabIndex = 0;
			label1.Text = "INSERTE DATO ROL";
			// 
			// button1
			// 
			button1.Location = new Point(117, 160);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 1;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(143, 100);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(211, 27);
			textBox1.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(39, 103);
			label2.Name = "label2";
			label2.Size = new Size(70, 20);
			label2.TabIndex = 3;
			label2.Text = "NOMBRE";
			// 
			// button2
			// 
			button2.Location = new Point(260, 160);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 4;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// RolInsertarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(439, 242);
			Controls.Add(button2);
			Controls.Add(label2);
			Controls.Add(textBox1);
			Controls.Add(button1);
			Controls.Add(label1);
			Name = "RolInsertarVista";
			Text = "RolInsertarVista";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button button1;
		private TextBox textBox1;
		private Label label2;
		private Button button2;
	}
}