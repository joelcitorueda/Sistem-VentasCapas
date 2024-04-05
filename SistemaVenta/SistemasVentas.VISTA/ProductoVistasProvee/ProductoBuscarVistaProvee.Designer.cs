namespace SistemasVentas.VISTA.ProductoVistasProvee
{
	partial class ProductoBuscarVistaProvee
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
			label8 = new Label();
			button3 = new Button();
			textBox4 = new TextBox();
			textBox6 = new TextBox();
			textBox1 = new TextBox();
			button1 = new Button();
			textBox2 = new TextBox();
			button4 = new Button();
			textBox3 = new TextBox();
			listView1 = new ListView();
			PRODUCTO = new ColumnHeader();
			CANTIDAD = new ColumnHeader();
			PRECIO = new ColumnHeader();
			TOTAL = new ColumnHeader();
			DESCRIPCION = new ColumnHeader();
			textBox5 = new TextBox();
			textBox7 = new TextBox();
			button2 = new Button();
			button5 = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.icons8_productos_64;
			pictureBox1.Location = new Point(313, 68);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(319, 268);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 65;
			pictureBox1.TabStop = false;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label8.ForeColor = Color.White;
			label8.Location = new Point(253, 9);
			label8.Name = "label8";
			label8.Size = new Size(435, 42);
			label8.TabIndex = 64;
			label8.Text = "COMPRA DE PRODUCTOS";
			// 
			// button3
			// 
			button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			button3.Location = new Point(711, 369);
			button3.Name = "button3";
			button3.Size = new Size(143, 29);
			button3.TabIndex = 62;
			button3.Text = "SELECCIONAR";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// textBox4
			// 
			textBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox4.Location = new Point(506, 430);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(348, 27);
			textBox4.TabIndex = 60;
			textBox4.Text = "PRECIO UNITARIO";
			// 
			// textBox6
			// 
			textBox6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox6.Location = new Point(506, 644);
			textBox6.Name = "textBox6";
			textBox6.Size = new Size(357, 27);
			textBox6.TabIndex = 58;
			textBox6.Text = "DESCRIPCION";
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox1.Location = new Point(57, 371);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(199, 27);
			textBox1.TabIndex = 55;
			textBox1.Text = "CLIENTE";
			// 
			// button1
			// 
			button1.DialogResult = DialogResult.OK;
			button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			button1.Image = Properties.Resources.icons8_comprar_271;
			button1.ImageAlign = ContentAlignment.MiddleRight;
			button1.Location = new Point(506, 693);
			button1.Name = "button1";
			button1.Size = new Size(243, 29);
			button1.TabIndex = 53;
			button1.Text = "AGREGAR AL CARRITO";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox2
			// 
			textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox2.Location = new Point(506, 369);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(199, 27);
			textBox2.TabIndex = 66;
			textBox2.Text = "PRODUCTO";
			// 
			// button4
			// 
			button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			button4.Location = new Point(271, 369);
			button4.Name = "button4";
			button4.Size = new Size(143, 29);
			button4.TabIndex = 68;
			button4.Text = "SELECCIONAR";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// textBox3
			// 
			textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox3.Location = new Point(57, 430);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(357, 27);
			textBox3.TabIndex = 67;
			textBox3.Text = "CANTIDAD";
			// 
			// listView1
			// 
			listView1.Columns.AddRange(new ColumnHeader[] { PRODUCTO, CANTIDAD, PRECIO, TOTAL, DESCRIPCION });
			listView1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			listView1.Location = new Point(57, 486);
			listView1.Name = "listView1";
			listView1.Size = new Size(648, 137);
			listView1.TabIndex = 69;
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.View = View.Details;
			// 
			// PRODUCTO
			// 
			PRODUCTO.Text = "PRODUCTO";
			PRODUCTO.Width = 130;
			// 
			// CANTIDAD
			// 
			CANTIDAD.Tag = "textBox4";
			CANTIDAD.Text = "CANTIDAD";
			CANTIDAD.TextAlign = HorizontalAlignment.Center;
			CANTIDAD.Width = 130;
			// 
			// PRECIO
			// 
			PRECIO.Text = "PRECIO";
			PRECIO.TextAlign = HorizontalAlignment.Center;
			PRECIO.Width = 130;
			// 
			// TOTAL
			// 
			TOTAL.Text = "TOTAL";
			TOTAL.TextAlign = HorizontalAlignment.Center;
			TOTAL.Width = 80;
			// 
			// DESCRIPCION
			// 
			DESCRIPCION.Text = "DESCRIPCION";
			DESCRIPCION.TextAlign = HorizontalAlignment.Center;
			DESCRIPCION.Width = 180;
			// 
			// textBox5
			// 
			textBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox5.Location = new Point(57, 644);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(357, 27);
			textBox5.TabIndex = 70;
			textBox5.Text = "TOTAL";
			// 
			// textBox7
			// 
			textBox7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox7.Location = new Point(57, 695);
			textBox7.Name = "textBox7";
			textBox7.Size = new Size(357, 27);
			textBox7.TabIndex = 71;
			textBox7.Text = "FORMA DE PAGO";
			// 
			// button2
			// 
			button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			button2.Image = Properties.Resources.icons8_visible_27;
			button2.ImageAlign = ContentAlignment.MiddleRight;
			button2.Location = new Point(711, 495);
			button2.Name = "button2";
			button2.Size = new Size(143, 38);
			button2.TabIndex = 72;
			button2.Text = "MOSTRAR";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button5
			// 
			button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button5.Image = Properties.Resources.icons8_cancelar_27;
			button5.ImageAlign = ContentAlignment.MiddleRight;
			button5.Location = new Point(24, 17);
			button5.Name = "button5";
			button5.Size = new Size(145, 34);
			button5.TabIndex = 73;
			button5.Text = "CANCELAR";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// ProductoBuscarVistaProvee
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSlateBlue;
			ClientSize = new Size(946, 764);
			Controls.Add(button5);
			Controls.Add(button2);
			Controls.Add(textBox7);
			Controls.Add(textBox5);
			Controls.Add(listView1);
			Controls.Add(button4);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(pictureBox1);
			Controls.Add(label8);
			Controls.Add(button3);
			Controls.Add(textBox4);
			Controls.Add(textBox6);
			Controls.Add(textBox1);
			Controls.Add(button1);
			Name = "ProductoBuscarVistaProvee";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ProductoBuscarVistaProvee";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Label label8;
		private Button button3;
		private TextBox textBox4;
		private TextBox textBox6;
		private TextBox textBox1;
		private Button button1;
		private TextBox textBox2;
		private Button button4;
		private TextBox textBox3;
		private ListView listView1;
		private ColumnHeader PRODUCTO;
		private ColumnHeader CANTIDAD;
		private ColumnHeader PRECIO;
		private TextBox textBox5;
		private TextBox textBox7;
		private Button button2;
		private ColumnHeader TOTAL;
		private ColumnHeader DESCRIPCION;
		private Button button5;
	}
}