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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoBuscarVistaProvee));
			pictureBox1 = new PictureBox();
			label8 = new Label();
			button3 = new Button();
			textBox4 = new TextBox();
			textBox6 = new TextBox();
			textBox1 = new TextBox();
			button2 = new Button();
			button1 = new Button();
			textBox2 = new TextBox();
			button4 = new Button();
			textBox3 = new TextBox();
			listView1 = new ListView();
			NRO = new ColumnHeader();
			DETALLE = new ColumnHeader();
			CANTIDAD = new ColumnHeader();
			PRECIO = new ColumnHeader();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(185, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(117, 114);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 65;
			pictureBox1.TabStop = false;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label8.Location = new Point(25, 151);
			label8.Name = "label8";
			label8.Size = new Size(231, 25);
			label8.TabIndex = 64;
			label8.Text = "COMPRA DE PRODUCTOS";
			// 
			// button3
			// 
			button3.Location = new Point(254, 239);
			button3.Name = "button3";
			button3.Size = new Size(143, 29);
			button3.TabIndex = 62;
			button3.Text = "SELECCIONAR";
			button3.UseVisualStyleBackColor = true;
			// 
			// textBox4
			// 
			textBox4.Location = new Point(84, 285);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(313, 27);
			textBox4.TabIndex = 60;
			textBox4.Text = "CANTIDAD";
			// 
			// textBox6
			// 
			textBox6.Location = new Point(84, 482);
			textBox6.Name = "textBox6";
			textBox6.Size = new Size(313, 27);
			textBox6.TabIndex = 58;
			textBox6.Text = "DESCRIPCION";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(84, 239);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(155, 27);
			textBox1.TabIndex = 55;
			textBox1.Text = "PRODUCTO";
			// 
			// button2
			// 
			button2.DialogResult = DialogResult.Cancel;
			button2.Location = new Point(285, 529);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 54;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.DialogResult = DialogResult.OK;
			button1.Location = new Point(101, 529);
			button1.Name = "button1";
			button1.Size = new Size(178, 29);
			button1.TabIndex = 53;
			button1.Text = "AGREGAR AL CARRITO";
			button1.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(84, 436);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(313, 27);
			textBox2.TabIndex = 66;
			textBox2.Text = "TOTAL";
			// 
			// button4
			// 
			button4.Location = new Point(254, 204);
			button4.Name = "button4";
			button4.Size = new Size(143, 29);
			button4.TabIndex = 68;
			button4.Text = "SELECCIONAR";
			button4.UseVisualStyleBackColor = true;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(84, 204);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(155, 27);
			textBox3.TabIndex = 67;
			textBox3.Text = "CLIENTE";
			// 
			// listView1
			// 
			listView1.Columns.AddRange(new ColumnHeader[] { NRO, DETALLE, CANTIDAD, PRECIO });
			listView1.Location = new Point(84, 329);
			listView1.Name = "listView1";
			listView1.Size = new Size(336, 90);
			listView1.TabIndex = 69;
			listView1.UseCompatibleStateImageBehavior = false;
			listView1.View = View.Details;
			// 
			// NRO
			// 
			NRO.Text = "NRO";
			// 
			// DETALLE
			// 
			DETALLE.Text = "        DETALLE";
			DETALLE.Width = 130;
			// 
			// CANTIDAD
			// 
			CANTIDAD.Text = "CANTIDAD";
			CANTIDAD.Width = 70;
			// 
			// PRECIO
			// 
			PRECIO.Text = "PRECIO";
			PRECIO.Width = 70;
			// 
			// ProductoBuscarVistaProvee
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(478, 584);
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
			Controls.Add(button2);
			Controls.Add(button1);
			Name = "ProductoBuscarVistaProvee";
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
		private Button button2;
		private Button button1;
		private TextBox textBox2;
		private Button button4;
		private TextBox textBox3;
		private ListView listView1;
		private ColumnHeader NRO;
		private ColumnHeader DETALLE;
		private ColumnHeader CANTIDAD;
		private ColumnHeader PRECIO;
	}
}