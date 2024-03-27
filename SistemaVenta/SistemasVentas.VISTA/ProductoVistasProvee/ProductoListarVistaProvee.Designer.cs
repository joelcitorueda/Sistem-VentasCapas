namespace SistemasVentas.VISTA.ProductoVistasProvee
{
	partial class ProductoListarVistaProvee
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoListarVistaProvee));
			label1 = new Label();
			dataGridView1 = new DataGridView();
			button1 = new Button();
			button2 = new Button();
			textBox1 = new TextBox();
			pictureBox1 = new PictureBox();
			label2 = new Label();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(84, 68);
			label1.Name = "label1";
			label1.Size = new Size(228, 25);
			label1.TabIndex = 14;
			label1.Text = "LISTADO DE PRODUCTOS\r\n";
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(95, 144);
			dataGridView1.Margin = new Padding(3, 4, 3, 4);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(664, 316);
			dataGridView1.TabIndex = 13;
			// 
			// button1
			// 
			button1.Location = new Point(21, 22);
			button1.Name = "button1";
			button1.Size = new Size(143, 29);
			button1.TabIndex = 15;
			button1.Text = "CERRAR SECION";
			button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Location = new Point(555, 501);
			button2.Name = "button2";
			button2.Size = new Size(127, 29);
			button2.TabIndex = 16;
			button2.Text = "COMPRAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(252, 503);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(282, 27);
			textBox1.TabIndex = 17;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(318, 32);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(90, 87);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 43;
			pictureBox1.TabStop = false;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(252, 480);
			label2.Name = "label2";
			label2.Size = new Size(267, 20);
			label2.TabIndex = 44;
			label2.Text = "NOMBRE DEL PRODUCTO A BUSCAR";
			// 
			// ProductoListarVistaProvee
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(826, 572);
			Controls.Add(label2);
			Controls.Add(pictureBox1);
			Controls.Add(textBox1);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label1);
			Controls.Add(dataGridView1);
			Name = "ProductoListarVistaProvee";
			Text = "ProductoListarVistaProvee";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private DataGridView dataGridView1;
		private Button button1;
		private Button button2;
		private TextBox textBox1;
		private PictureBox pictureBox1;
		private Label label2;
	}
}