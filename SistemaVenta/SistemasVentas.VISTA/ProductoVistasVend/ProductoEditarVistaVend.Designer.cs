namespace SistemasVentas.VISTA.ProductoVistasVend
{
	partial class ProductoEditarVistaVend
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoEditarVistaVend));
			pictureBox1 = new PictureBox();
			label8 = new Label();
			button4 = new Button();
			button3 = new Button();
			textBox7 = new TextBox();
			textBox4 = new TextBox();
			textBox5 = new TextBox();
			textBox6 = new TextBox();
			textBox3 = new TextBox();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			button2 = new Button();
			button1 = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(160, 22);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(117, 114);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 72;
			pictureBox1.TabStop = false;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label8.Location = new Point(31, 139);
			label8.Name = "label8";
			label8.Size = new Size(189, 25);
			label8.TabIndex = 71;
			label8.Text = "EDITAR PRODUCTOS";
			// 
			// button4
			// 
			button4.Location = new Point(233, 213);
			button4.Name = "button4";
			button4.Size = new Size(140, 29);
			button4.TabIndex = 70;
			button4.Text = "SELECCIONAR";
			button4.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Location = new Point(233, 178);
			button3.Name = "button3";
			button3.Size = new Size(140, 29);
			button3.TabIndex = 69;
			button3.Text = "SELECCIONAR";
			button3.UseVisualStyleBackColor = true;
			// 
			// textBox7
			// 
			textBox7.Location = new Point(60, 390);
			textBox7.Name = "textBox7";
			textBox7.Size = new Size(313, 27);
			textBox7.TabIndex = 68;
			textBox7.Text = "ESTADO";
			// 
			// textBox4
			// 
			textBox4.Location = new Point(60, 285);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(313, 27);
			textBox4.TabIndex = 67;
			textBox4.Text = "CODIGO DE BARRA";
			// 
			// textBox5
			// 
			textBox5.Location = new Point(60, 321);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(313, 27);
			textBox5.TabIndex = 66;
			textBox5.Text = "UNIDAD";
			// 
			// textBox6
			// 
			textBox6.Location = new Point(60, 357);
			textBox6.Name = "textBox6";
			textBox6.Size = new Size(313, 27);
			textBox6.TabIndex = 65;
			textBox6.Text = "DESCRIPCION";
			// 
			// textBox3
			// 
			textBox3.Location = new Point(60, 248);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(313, 27);
			textBox3.TabIndex = 64;
			textBox3.Text = "NOMBRE";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(60, 215);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(167, 27);
			textBox2.TabIndex = 63;
			textBox2.Text = "ID MARCA";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(60, 180);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(167, 27);
			textBox1.TabIndex = 62;
			textBox1.Text = "ID TIPO PRODUCTO";
			// 
			// button2
			// 
			button2.DialogResult = DialogResult.Cancel;
			button2.Location = new Point(224, 448);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 61;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.DialogResult = DialogResult.OK;
			button1.Location = new Point(106, 448);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 60;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			// 
			// ProductoEditarVistaVend
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(440, 507);
			Controls.Add(pictureBox1);
			Controls.Add(label8);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(textBox7);
			Controls.Add(textBox4);
			Controls.Add(textBox5);
			Controls.Add(textBox6);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(button2);
			Controls.Add(button1);
			Name = "ProductoEditarVistaVend";
			Text = "ProductoEditarVistaVend";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Label label8;
		private Button button4;
		private Button button3;
		private TextBox textBox7;
		private TextBox textBox4;
		private TextBox textBox5;
		private TextBox textBox6;
		private TextBox textBox3;
		private TextBox textBox2;
		private TextBox textBox1;
		private Button button2;
		private Button button1;
	}
}