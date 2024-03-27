namespace SistemasVentas.VISTA.ClienteVistaVend
{
	partial class ClienteInsertarVistaVend
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteInsertarVistaVend));
			pictureBox1 = new PictureBox();
			button3 = new Button();
			button2 = new Button();
			button1 = new Button();
			textBox3 = new TextBox();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(130, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(129, 118);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 42;
			pictureBox1.TabStop = false;
			// 
			// button3
			// 
			button3.Location = new Point(265, 204);
			button3.Name = "button3";
			button3.Size = new Size(114, 29);
			button3.TabIndex = 41;
			button3.Text = "SELECCIONAR";
			button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.DialogResult = DialogResult.Cancel;
			button2.Location = new Point(213, 365);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 40;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.DialogResult = DialogResult.OK;
			button1.Location = new Point(87, 365);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 39;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(45, 311);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(334, 27);
			textBox3.TabIndex = 38;
			textBox3.Text = "CODIGO CLIENTE";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(45, 256);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(334, 27);
			textBox2.TabIndex = 37;
			textBox2.Text = "TIPO CLIENTE";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(45, 204);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(214, 27);
			textBox1.TabIndex = 36;
			textBox1.Text = "ID PERSONA";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(21, 149);
			label1.Name = "label1";
			label1.Size = new Size(134, 20);
			label1.TabIndex = 35;
			label1.Text = "AGREGAR CLIENTE";
			// 
			// ClienteInsertarVistaVend
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(417, 433);
			Controls.Add(pictureBox1);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Name = "ClienteInsertarVistaVend";
			Text = "ClienteInsertarVistaVend";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Button button3;
		private Button button2;
		private Button button1;
		private TextBox textBox3;
		private TextBox textBox2;
		private TextBox textBox1;
		private Label label1;
	}
}