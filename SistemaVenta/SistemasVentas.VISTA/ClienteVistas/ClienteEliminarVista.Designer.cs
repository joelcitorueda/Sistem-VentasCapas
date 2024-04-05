namespace SistemasVentas.VISTA.ClienteVistas
{
	partial class ClienteEliminarVista
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteEliminarVista));
			pictureBox1 = new PictureBox();
			button3 = new Button();
			button1 = new Button();
			textBox1 = new TextBox();
			label1 = new Label();
			label2 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(169, 213);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(64, 63);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 42;
			pictureBox1.TabStop = false;
			// 
			// button3
			// 
			button3.Location = new Point(256, 128);
			button3.Name = "button3";
			button3.Size = new Size(114, 29);
			button3.TabIndex = 41;
			button3.Text = "SELECCIONAR";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button1
			// 
			button1.DialogResult = DialogResult.OK;
			button1.Location = new Point(104, 178);
			button1.Name = "button1";
			button1.Size = new Size(195, 29);
			button1.TabIndex = 39;
			button1.Text = "ELIMINAR CLIENTE";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(36, 128);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(214, 27);
			textBox1.TabIndex = 36;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(36, 105);
			label1.Name = "label1";
			label1.Size = new Size(197, 20);
			label1.TabIndex = 35;
			label1.Text = "ID DEL CLIENTE A ELIMINAR";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(67, 56);
			label2.Name = "label2";
			label2.Size = new Size(294, 25);
			label2.TabIndex = 43;
			label2.Text = "ELIMINAR CLIENTE DEL SISTEMA";
			// 
			// ClienteEliminarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(405, 306);
			Controls.Add(label2);
			Controls.Add(pictureBox1);
			Controls.Add(button3);
			Controls.Add(button1);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Name = "ClienteEliminarVista";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ClienteEliminarVista";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Button button3;
		private Button button1;
		private TextBox textBox1;
		private Label label1;
		private Label label2;
	}
}