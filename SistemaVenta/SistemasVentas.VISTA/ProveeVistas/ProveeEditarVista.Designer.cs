namespace SistemasVentas.VISTA.ProveeVistas
{
    partial class ProveeEditarVista
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
			label6 = new Label();
			button4 = new Button();
			button3 = new Button();
			textBox3 = new TextBox();
			dateTimePicker1 = new DateTimePicker();
			label7 = new Label();
			button2 = new Button();
			button1 = new Button();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.icons8_proveedor_50;
			pictureBox1.Location = new Point(180, 95);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(129, 118);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 93;
			pictureBox1.TabStop = false;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.White;
			label6.Location = new Point(116, 47);
			label6.Name = "label6";
			label6.Size = new Size(192, 28);
			label6.TabIndex = 92;
			label6.Text = "EDITAR PROVEE";
			// 
			// button4
			// 
			button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			button4.Location = new Point(290, 356);
			button4.Name = "button4";
			button4.Size = new Size(121, 29);
			button4.TabIndex = 91;
			button4.Text = "SELECCIONAR";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click_1;
			// 
			// button3
			// 
			button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			button3.Location = new Point(290, 278);
			button3.Name = "button3";
			button3.Size = new Size(121, 29);
			button3.TabIndex = 90;
			button3.Text = "SELECCIONAR";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click_1;
			// 
			// textBox3
			// 
			textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox3.Location = new Point(77, 497);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(334, 27);
			textBox3.TabIndex = 89;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			dateTimePicker1.Location = new Point(77, 421);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(334, 27);
			dateTimePicker1.TabIndex = 88;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label7.Location = new Point(55, 398);
			label7.Name = "label7";
			label7.Size = new Size(56, 20);
			label7.TabIndex = 87;
			label7.Text = "FECHA";
			// 
			// button2
			// 
			button2.DialogResult = DialogResult.Cancel;
			button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			button2.Location = new Point(250, 574);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 86;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.DialogResult = DialogResult.OK;
			button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			button1.Location = new Point(127, 574);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 85;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click_1;
			// 
			// textBox2
			// 
			textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox2.Location = new Point(77, 356);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(174, 27);
			textBox2.TabIndex = 84;
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox1.Location = new Point(77, 278);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(174, 27);
			textBox1.TabIndex = 83;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label3.Location = new Point(55, 474);
			label3.Name = "label3";
			label3.Size = new Size(61, 20);
			label3.TabIndex = 82;
			label3.Text = "PRECIO";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label2.Location = new Point(55, 333);
			label2.Name = "label2";
			label2.Size = new Size(113, 20);
			label2.TabIndex = 81;
			label2.Text = "IDPROVEEDOR";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label1.Location = new Point(55, 255);
			label1.Name = "label1";
			label1.Size = new Size(109, 20);
			label1.TabIndex = 80;
			label1.Text = "ID PRODUCTO";
			// 
			// ProveeEditarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSlateBlue;
			ClientSize = new Size(498, 688);
			Controls.Add(pictureBox1);
			Controls.Add(label6);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(textBox3);
			Controls.Add(dateTimePicker1);
			Controls.Add(label7);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "ProveeEditarVista";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ProveeEditarVista";
			Load += ProveeEditarVista_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Label label6;
		private Button button4;
		private Button button3;
		private TextBox textBox3;
		private DateTimePicker dateTimePicker1;
		private Label label7;
		private Button button2;
		private Button button1;
		private TextBox textBox2;
		private TextBox textBox1;
		private Label label3;
		private Label label2;
		private Label label1;
	}
}