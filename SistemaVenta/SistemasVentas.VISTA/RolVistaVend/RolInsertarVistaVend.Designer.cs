namespace SistemasVentas.VISTA.RolVistaVend
{
	partial class RolInsertarVistaVend
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
			pictureBox1 = new PictureBox();
			label6 = new Label();
			button2 = new Button();
			button1 = new Button();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			label3 = new Label();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.icons8_archivo_501;
			pictureBox1.Location = new Point(185, 62);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(129, 118);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 117;
			pictureBox1.TabStop = false;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.White;
			label6.Location = new Point(157, 18);
			label6.Name = "label6";
			label6.Size = new Size(179, 28);
			label6.TabIndex = 116;
			label6.Text = "INSERTAR ROL";
			// 
			// button2
			// 
			button2.DialogResult = DialogResult.Cancel;
			button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			button2.Location = new Point(275, 429);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 115;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.DialogResult = DialogResult.OK;
			button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			button1.Location = new Point(157, 429);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 114;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox2.Location = new Point(95, 347);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(334, 27);
			textBox2.TabIndex = 113;
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox1.Location = new Point(95, 249);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(334, 27);
			textBox1.TabIndex = 112;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label3.ForeColor = Color.White;
			label3.Location = new Point(45, 324);
			label3.Name = "label3";
			label3.Size = new Size(66, 20);
			label3.TabIndex = 111;
			label3.Text = "ESTADO";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label1.ForeColor = Color.White;
			label1.Location = new Point(45, 226);
			label1.Name = "label1";
			label1.Size = new Size(74, 20);
			label1.TabIndex = 110;
			label1.Text = "NOMBRE";
			// 
			// RolInsertarVistaVend
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSlateBlue;
			ClientSize = new Size(523, 504);
			Controls.Add(pictureBox1);
			Controls.Add(label6);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label3);
			Controls.Add(label1);
			Name = "RolInsertarVistaVend";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "RolInsertarVistaVend";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Label label6;
		private Button button2;
		private Button button1;
		private TextBox textBox2;
		private TextBox textBox1;
		private Label label3;
		private Label label1;
	}
}