namespace SistemasVentas.VISTA.PersonaVistas
{
    partial class PersonaInsertarVista
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			textBox4 = new TextBox();
			textBox5 = new TextBox();
			button1 = new Button();
			button2 = new Button();
			pictureBox1 = new PictureBox();
			label6 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label1.ForeColor = Color.White;
			label1.Location = new Point(49, 205);
			label1.Name = "label1";
			label1.Size = new Size(74, 20);
			label1.TabIndex = 0;
			label1.Text = "NOMBRE";
			label1.Click += label1_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label2.ForeColor = Color.White;
			label2.Location = new Point(49, 269);
			label2.Name = "label2";
			label2.Size = new Size(88, 20);
			label2.TabIndex = 1;
			label2.Text = "APELLIDOS";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label3.ForeColor = Color.White;
			label3.Location = new Point(49, 335);
			label3.Name = "label3";
			label3.Size = new Size(84, 20);
			label3.TabIndex = 2;
			label3.Text = "TELEFONO";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label4.ForeColor = Color.White;
			label4.Location = new Point(90, 397);
			label4.Name = "label4";
			label4.Size = new Size(23, 20);
			label4.TabIndex = 3;
			label4.Text = "CI";
			label4.Click += label4_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label5.ForeColor = Color.White;
			label5.Location = new Point(49, 460);
			label5.Name = "label5";
			label5.Size = new Size(68, 20);
			label5.TabIndex = 4;
			label5.Text = "CORREO";
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox1.Location = new Point(101, 228);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(264, 27);
			textBox1.TabIndex = 5;
			// 
			// textBox2
			// 
			textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox2.Location = new Point(101, 292);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(264, 27);
			textBox2.TabIndex = 6;
			// 
			// textBox3
			// 
			textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox3.Location = new Point(101, 358);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(264, 27);
			textBox3.TabIndex = 7;
			// 
			// textBox4
			// 
			textBox4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox4.Location = new Point(101, 420);
			textBox4.Name = "textBox4";
			textBox4.Size = new Size(264, 27);
			textBox4.TabIndex = 8;
			// 
			// textBox5
			// 
			textBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox5.Location = new Point(101, 483);
			textBox5.Name = "textBox5";
			textBox5.Size = new Size(264, 27);
			textBox5.TabIndex = 9;
			// 
			// button1
			// 
			button1.DialogResult = DialogResult.OK;
			button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			button1.Location = new Point(116, 561);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 10;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.DialogResult = DialogResult.Cancel;
			button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			button2.Location = new Point(245, 561);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 11;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.icons8_usuario_50;
			pictureBox1.Location = new Point(153, 73);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(129, 118);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 87;
			pictureBox1.TabStop = false;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.White;
			label6.Location = new Point(116, 29);
			label6.Name = "label6";
			label6.Size = new Size(241, 28);
			label6.TabIndex = 86;
			label6.Text = "INSERTAR PERSONA";
			// 
			// PersonaInsertarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSlateBlue;
			ClientSize = new Size(456, 618);
			Controls.Add(pictureBox1);
			Controls.Add(label6);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox5);
			Controls.Add(textBox4);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "PersonaInsertarVista";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "PersonaInsertarVista";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private Button button2;
		private PictureBox pictureBox1;
		private Label label6;
	}
}