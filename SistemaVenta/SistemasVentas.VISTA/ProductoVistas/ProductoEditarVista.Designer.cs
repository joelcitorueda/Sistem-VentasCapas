namespace SistemasVentas.VISTA.ProductoVistas
{
    partial class ProductoEditarVista
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoEditarVista));
			textBox7 = new TextBox();
			textBox4 = new TextBox();
			textBox5 = new TextBox();
			textBox6 = new TextBox();
			textBox3 = new TextBox();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			button2 = new Button();
			button1 = new Button();
			button4 = new Button();
			button3 = new Button();
			pictureBox1 = new PictureBox();
			label8 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// textBox7
			// 
			textBox7.Location = new Point(74, 380);
			textBox7.Name = "textBox7";
			textBox7.Size = new Size(313, 27);
			textBox7.TabIndex = 55;
			textBox7.Text = "ESTADO";
			// 
			// textBox4
			// 
			textBox4.Location = new Point(74, 275);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(313, 27);
			textBox4.TabIndex = 54;
			textBox4.Text = "CODIGO DE BARRA";
			// 
			// textBox5
			// 
			textBox5.Location = new Point(74, 311);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(313, 27);
			textBox5.TabIndex = 53;
			textBox5.Text = "UNIDAD";
			// 
			// textBox6
			// 
			textBox6.Location = new Point(74, 347);
			textBox6.Name = "textBox6";
			textBox6.Size = new Size(313, 27);
			textBox6.TabIndex = 52;
			textBox6.Text = "DESCRIPCION";
			// 
			// textBox3
			// 
			textBox3.Location = new Point(74, 238);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(313, 27);
			textBox3.TabIndex = 48;
			textBox3.Text = "NOMBRE";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(74, 205);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(167, 27);
			textBox2.TabIndex = 47;
			textBox2.Text = "ID MARCA";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(74, 170);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(167, 27);
			textBox1.TabIndex = 46;
			textBox1.Text = "ID TIPO PRODUCTO";
			// 
			// button2
			// 
			button2.DialogResult = DialogResult.Cancel;
			button2.Location = new Point(238, 438);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 41;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.DialogResult = DialogResult.OK;
			button1.Location = new Point(120, 438);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 40;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button4
			// 
			button4.Location = new Point(247, 203);
			button4.Name = "button4";
			button4.Size = new Size(140, 29);
			button4.TabIndex = 57;
			button4.Text = "SELECCIONAR";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button3
			// 
			button3.Location = new Point(247, 168);
			button3.Name = "button3";
			button3.Size = new Size(140, 29);
			button3.TabIndex = 56;
			button3.Text = "SELECCIONAR";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(174, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(117, 114);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 59;
			pictureBox1.TabStop = false;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label8.Location = new Point(45, 129);
			label8.Name = "label8";
			label8.Size = new Size(189, 25);
			label8.TabIndex = 58;
			label8.Text = "EDITAR PRODUCTOS";
			// 
			// ProductoEditarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(444, 508);
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
			Name = "ProductoEditarVista";
			Text = "ProductoEditarVista";
			Load += ProductoEditarVista_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox7;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button2;
        private Button button1;
        private Button button4;
        private Button button3;
		private PictureBox pictureBox1;
		private Label label8;
	}
}