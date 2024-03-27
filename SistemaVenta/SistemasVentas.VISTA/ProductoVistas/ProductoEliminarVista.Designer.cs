namespace SistemasVentas.VISTA.ProductoVistas
{
	partial class ProductoEliminarVista
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoEliminarVista));
			label2 = new Label();
			pictureBox1 = new PictureBox();
			button3 = new Button();
			button1 = new Button();
			textBox1 = new TextBox();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(57, 26);
			label2.Name = "label2";
			label2.Size = new Size(321, 25);
			label2.TabIndex = 49;
			label2.Text = "ELIMINAR PRODUCTO DEL SISTEMA";
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(159, 183);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(64, 63);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 48;
			pictureBox1.TabStop = false;
			// 
			// button3
			// 
			button3.Location = new Point(246, 98);
			button3.Name = "button3";
			button3.Size = new Size(114, 29);
			button3.TabIndex = 47;
			button3.Text = "SELECCIONAR";
			button3.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.DialogResult = DialogResult.OK;
			button1.Location = new Point(94, 148);
			button1.Name = "button1";
			button1.Size = new Size(195, 29);
			button1.TabIndex = 46;
			button1.Text = "ELIMINAR PRODUCTO";
			button1.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(26, 98);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(214, 27);
			textBox1.TabIndex = 45;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(26, 75);
			label1.Name = "label1";
			label1.Size = new Size(218, 20);
			label1.TabIndex = 44;
			label1.Text = "ID DEL PRODUCTO A ELIMINAR";
			// 
			// ProductoEliminarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(401, 267);
			Controls.Add(label2);
			Controls.Add(pictureBox1);
			Controls.Add(button3);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Name = "ProductoEliminarVista";
			Text = "ProductoEliminarVista";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label2;
		private PictureBox pictureBox1;
		private Button button3;
		private Button button1;
		private TextBox textBox1;
		private Label label1;
	}
}