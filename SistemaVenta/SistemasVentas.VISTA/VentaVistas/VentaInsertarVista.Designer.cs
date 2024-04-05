namespace SistemasVentas.VISTA.VentaVistas
{
    partial class VentaInsertarVista
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
			dateTimePicker1 = new DateTimePicker();
			textBox3 = new TextBox();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			button2 = new Button();
			button1 = new Button();
			label5 = new Label();
			textBox4 = new TextBox();
			button4 = new Button();
			button3 = new Button();
			pictureBox1 = new PictureBox();
			label6 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			dateTimePicker1.Location = new Point(112, 477);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(313, 27);
			dateTimePicker1.TabIndex = 52;
			// 
			// textBox3
			// 
			textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox3.Location = new Point(112, 555);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(313, 27);
			textBox3.TabIndex = 51;
			// 
			// textBox2
			// 
			textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox2.Location = new Point(112, 405);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(190, 27);
			textBox2.TabIndex = 50;
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox1.Location = new Point(112, 328);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(190, 27);
			textBox1.TabIndex = 49;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label4.ForeColor = Color.White;
			label4.Location = new Point(67, 454);
			label4.Name = "label4";
			label4.Size = new Size(56, 20);
			label4.TabIndex = 48;
			label4.Text = "FECHA";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label3.ForeColor = Color.White;
			label3.Location = new Point(69, 532);
			label3.Name = "label3";
			label3.Size = new Size(54, 20);
			label3.TabIndex = 47;
			label3.Text = "TOTAL";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label2.ForeColor = Color.White;
			label2.Location = new Point(69, 382);
			label2.Name = "label2";
			label2.Size = new Size(110, 20);
			label2.TabIndex = 46;
			label2.Text = "ID VENDEDOR";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label1.ForeColor = Color.White;
			label1.Location = new Point(69, 305);
			label1.Name = "label1";
			label1.Size = new Size(88, 20);
			label1.TabIndex = 45;
			label1.Text = "ID CLIENTE";
			// 
			// button2
			// 
			button2.DialogResult = DialogResult.Cancel;
			button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			button2.Location = new Point(294, 713);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 44;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.DialogResult = DialogResult.OK;
			button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			button1.Location = new Point(157, 713);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 43;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label5.ForeColor = Color.White;
			label5.Location = new Point(69, 609);
			label5.Name = "label5";
			label5.Size = new Size(66, 20);
			label5.TabIndex = 53;
			label5.Text = "ESTADO";
			// 
			// textBox4
			// 
			textBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox4.Location = new Point(112, 632);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(313, 27);
			textBox4.TabIndex = 54;
			// 
			// button4
			// 
			button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			button4.Location = new Point(308, 405);
			button4.Name = "button4";
			button4.Size = new Size(117, 29);
			button4.TabIndex = 70;
			button4.Text = "SELECCIONAR";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button3
			// 
			button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			button3.Location = new Point(308, 326);
			button3.Name = "button3";
			button3.Size = new Size(117, 29);
			button3.TabIndex = 69;
			button3.Text = "SELECCIONAR";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.icons8_venta_48;
			pictureBox1.Location = new Point(187, 129);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(129, 118);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 152;
			pictureBox1.TabStop = false;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.White;
			label6.Location = new Point(146, 57);
			label6.Name = "label6";
			label6.Size = new Size(209, 28);
			label6.TabIndex = 151;
			label6.Text = "INSERTAR VENTA";
			// 
			// VentaInsertarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSlateBlue;
			ClientSize = new Size(517, 770);
			Controls.Add(pictureBox1);
			Controls.Add(label6);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(textBox4);
			Controls.Add(label5);
			Controls.Add(dateTimePicker1);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(button2);
			Controls.Add(button1);
			Name = "VentaInsertarVista";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "VentaInsertarVista";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private Label label5;
        private TextBox textBox4;
        private Button button4;
        private Button button3;
		private PictureBox pictureBox1;
		private Label label6;
	}
}