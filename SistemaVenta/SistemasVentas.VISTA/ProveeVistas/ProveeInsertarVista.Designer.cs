﻿namespace SistemasVentas.VISTA.ProveeVistas
{
    partial class ProveeInsertarVista
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
			label7 = new Label();
			button2 = new Button();
			button1 = new Button();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			textBox3 = new TextBox();
			button3 = new Button();
			button4 = new Button();
			pictureBox1 = new PictureBox();
			label6 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			dateTimePicker1.Location = new Point(55, 417);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(334, 27);
			dateTimePicker1.TabIndex = 43;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label7.Location = new Point(33, 394);
			label7.Name = "label7";
			label7.Size = new Size(56, 20);
			label7.TabIndex = 41;
			label7.Text = "FECHA";
			// 
			// button2
			// 
			button2.DialogResult = DialogResult.Cancel;
			button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			button2.Location = new Point(228, 570);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 39;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.DialogResult = DialogResult.OK;
			button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			button1.Location = new Point(105, 570);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 38;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox2
			// 
			textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox2.Location = new Point(55, 352);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(174, 27);
			textBox2.TabIndex = 35;
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox1.Location = new Point(55, 274);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(174, 27);
			textBox1.TabIndex = 34;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label3.Location = new Point(33, 470);
			label3.Name = "label3";
			label3.Size = new Size(61, 20);
			label3.TabIndex = 31;
			label3.Text = "PRECIO";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label2.Location = new Point(33, 329);
			label2.Name = "label2";
			label2.Size = new Size(113, 20);
			label2.TabIndex = 30;
			label2.Text = "IDPROVEEDOR";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label1.Location = new Point(33, 251);
			label1.Name = "label1";
			label1.Size = new Size(109, 20);
			label1.TabIndex = 29;
			label1.Text = "ID PRODUCTO";
			// 
			// textBox3
			// 
			textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox3.Location = new Point(55, 493);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(334, 27);
			textBox3.TabIndex = 44;
			// 
			// button3
			// 
			button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			button3.Location = new Point(268, 274);
			button3.Name = "button3";
			button3.Size = new Size(121, 29);
			button3.TabIndex = 45;
			button3.Text = "SELECCIONAR";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			button4.Location = new Point(268, 352);
			button4.Name = "button4";
			button4.Size = new Size(121, 29);
			button4.TabIndex = 46;
			button4.Text = "SELECCIONAR";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.icons8_proveedor_50;
			pictureBox1.Location = new Point(158, 91);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(129, 118);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 79;
			pictureBox1.TabStop = false;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.White;
			label6.Location = new Point(94, 43);
			label6.Name = "label6";
			label6.Size = new Size(223, 28);
			label6.TabIndex = 78;
			label6.Text = "INSERTAR PROVEE";
			label6.Click += label6_Click;
			// 
			// ProveeInsertarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSlateBlue;
			ClientSize = new Size(463, 639);
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
			Name = "ProveeInsertarVista";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ProveeInsertarVista";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DateTimePicker dateTimePicker1;
        private Label label7;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private Button button3;
        private Button button4;
		private PictureBox pictureBox1;
		private Label label6;
	}
}