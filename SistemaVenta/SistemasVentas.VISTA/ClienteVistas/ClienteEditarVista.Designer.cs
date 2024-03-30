namespace SistemasVentas.VISTA.ClienteVistas
{
    partial class ClienteEditarVista
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteEditarVista));
			button2 = new Button();
			button1 = new Button();
			textBox3 = new TextBox();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			button3 = new Button();
			pictureBox1 = new PictureBox();
			label4 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// button2
			// 
			button2.DialogResult = DialogResult.Cancel;
			button2.Location = new Point(257, 376);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 31;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.DialogResult = DialogResult.OK;
			button1.Location = new Point(135, 376);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 30;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(71, 317);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(334, 27);
			textBox3.TabIndex = 29;
			textBox3.Text = "CODIGO CLIENTE";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(71, 261);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(334, 27);
			textBox2.TabIndex = 28;
			textBox2.Text = "TIPO CLIENTE";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(71, 202);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(208, 27);
			textBox1.TabIndex = 27;
			textBox1.Text = "ID PERSONA";
			// 
			// button3
			// 
			button3.Location = new Point(291, 202);
			button3.Name = "button3";
			button3.Size = new Size(114, 29);
			button3.TabIndex = 34;
			button3.Text = "SELECCIONAR";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(150, 22);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(129, 118);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 36;
			pictureBox1.TabStop = false;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(25, 161);
			label4.Name = "label4";
			label4.Size = new Size(127, 20);
			label4.TabIndex = 35;
			label4.Text = "EDITAR PERSONA";
			// 
			// ClienteEditarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(433, 428);
			Controls.Add(pictureBox1);
			Controls.Add(label4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Name = "ClienteEditarVista";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ClienteEditarVista";
			Load += ClienteEditarVista_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button3;
		private PictureBox pictureBox1;
		private Label label4;
	}
}