namespace SistemasVentas.VISTA.ProductoVistasProvee
{
	partial class ProductoComprarVistaProvee
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
			checkedListBox1 = new CheckedListBox();
			label1 = new Label();
			label2 = new Label();
			button1 = new Button();
			button2 = new Button();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// checkedListBox1
			// 
			checkedListBox1.FormattingEnabled = true;
			checkedListBox1.Items.AddRange(new object[] { "QR", "TRANSFERENCIA", "EFECTIVO" });
			checkedListBox1.Location = new Point(52, 153);
			checkedListBox1.Name = "checkedListBox1";
			checkedListBox1.Size = new Size(150, 70);
			checkedListBox1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(20, 118);
			label1.Name = "label1";
			label1.Size = new Size(292, 23);
			label1.TabIndex = 1;
			label1.Text = "QUE METODO DE PAGO OCUPARA?";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(20, 245);
			label2.Name = "label2";
			label2.Size = new Size(344, 23);
			label2.TabIndex = 2;
			label2.Text = "ESTA SEGURO DE REALIZAR LA COMPRA?";
			// 
			// button1
			// 
			button1.Location = new Point(61, 283);
			button1.Name = "button1";
			button1.Size = new Size(124, 29);
			button1.TabIndex = 3;
			button1.Text = "COMPRAR";
			button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			button2.Location = new Point(203, 283);
			button2.Name = "button2";
			button2.Size = new Size(124, 29);
			button2.TabIndex = 4;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.archivo_factura_dolar;
			pictureBox1.Location = new Point(130, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(89, 91);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 5;
			pictureBox1.TabStop = false;
			// 
			// ProductoComprarVistaProvee
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(390, 340);
			Controls.Add(pictureBox1);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(checkedListBox1);
			Name = "ProductoComprarVistaProvee";
			Text = "ProductoComprarVistaProvee";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private CheckedListBox checkedListBox1;
		private Label label1;
		private Label label2;
		private Button button1;
		private Button button2;
		private PictureBox pictureBox1;
	}
}