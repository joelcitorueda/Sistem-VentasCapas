namespace SistemasVentas.VISTA.ProveedorVistas
{
    partial class ProveedorInsertarVista
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
			textBox3 = new TextBox();
			label7 = new Label();
			button2 = new Button();
			button1 = new Button();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			textBox4 = new TextBox();
			pictureBox1 = new PictureBox();
			label6 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// textBox3
			// 
			textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox3.Location = new Point(84, 423);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(334, 27);
			textBox3.TabIndex = 54;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label7.ForeColor = Color.White;
			label7.Location = new Point(47, 400);
			label7.Name = "label7";
			label7.Size = new Size(89, 20);
			label7.TabIndex = 52;
			label7.Text = "DIRECCION";
			// 
			// button2
			// 
			button2.DialogResult = DialogResult.Cancel;
			button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			button2.Location = new Point(275, 559);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 51;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.DialogResult = DialogResult.OK;
			button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			button1.Location = new Point(153, 559);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 50;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox2
			// 
			textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox2.Location = new Point(84, 349);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(334, 27);
			textBox2.TabIndex = 49;
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox1.Location = new Point(84, 277);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(334, 27);
			textBox1.TabIndex = 48;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label3.ForeColor = Color.White;
			label3.Location = new Point(47, 469);
			label3.Name = "label3";
			label3.Size = new Size(66, 20);
			label3.TabIndex = 47;
			label3.Text = "ESTADO";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label2.ForeColor = Color.White;
			label2.Location = new Point(47, 326);
			label2.Name = "label2";
			label2.Size = new Size(84, 20);
			label2.TabIndex = 46;
			label2.Text = "TELEFONO";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label1.ForeColor = Color.White;
			label1.Location = new Point(47, 254);
			label1.Name = "label1";
			label1.Size = new Size(74, 20);
			label1.TabIndex = 45;
			label1.Text = "NOMBRE";
			// 
			// textBox4
			// 
			textBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox4.Location = new Point(84, 492);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(334, 27);
			textBox4.TabIndex = 55;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.icons8_proveedor_50__1_;
			pictureBox1.Location = new Point(175, 94);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(129, 118);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 95;
			pictureBox1.TabStop = false;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.White;
			label6.Location = new Point(111, 32);
			label6.Name = "label6";
			label6.Size = new Size(272, 28);
			label6.TabIndex = 94;
			label6.Text = "INSERTAR PROVEEDOR";
			// 
			// ProveedorInsertarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSlateBlue;
			ClientSize = new Size(501, 632);
			Controls.Add(pictureBox1);
			Controls.Add(label6);
			Controls.Add(textBox4);
			Controls.Add(textBox3);
			Controls.Add(label7);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "ProveedorInsertarVista";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ProveedorInsertarVista";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox3;
        private Label label7;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox4;
		private PictureBox pictureBox1;
		private Label label6;
	}
}