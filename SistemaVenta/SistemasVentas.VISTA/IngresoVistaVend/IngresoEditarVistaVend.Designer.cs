﻿namespace SistemasVentas.VISTA.IngresoVistaVend
{
	partial class IngresoEditarVistaVend
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
			button3 = new Button();
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
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.pedido;
			pictureBox1.Location = new Point(191, 75);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(129, 118);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 88;
			pictureBox1.TabStop = false;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.White;
			label6.Location = new Point(154, 31);
			label6.Name = "label6";
			label6.Size = new Size(205, 28);
			label6.TabIndex = 87;
			label6.Text = "EDITAR INGRESO";
			// 
			// button3
			// 
			button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			button3.Location = new Point(277, 235);
			button3.Name = "button3";
			button3.Size = new Size(131, 29);
			button3.TabIndex = 86;
			button3.Text = "SELECCIONAR";
			button3.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			dateTimePicker1.Location = new Point(95, 300);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(313, 27);
			dateTimePicker1.TabIndex = 85;
			// 
			// textBox3
			// 
			textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox3.Location = new Point(95, 430);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(313, 27);
			textBox3.TabIndex = 84;
			// 
			// textBox2
			// 
			textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox2.Location = new Point(95, 365);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(313, 27);
			textBox2.TabIndex = 83;
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			textBox1.Location = new Point(95, 235);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(170, 27);
			textBox1.TabIndex = 82;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label4.ForeColor = Color.White;
			label4.Location = new Point(62, 407);
			label4.Name = "label4";
			label4.Size = new Size(66, 20);
			label4.TabIndex = 81;
			label4.Text = "ESTADO";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label3.ForeColor = Color.White;
			label3.Location = new Point(62, 342);
			label3.Name = "label3";
			label3.Size = new Size(54, 20);
			label3.TabIndex = 80;
			label3.Text = "TOTAL";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label2.ForeColor = Color.White;
			label2.Location = new Point(62, 277);
			label2.Name = "label2";
			label2.Size = new Size(125, 20);
			label2.TabIndex = 79;
			label2.Text = "FECHA INGRESO";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label1.ForeColor = Color.White;
			label1.Location = new Point(62, 212);
			label1.Name = "label1";
			label1.Size = new Size(117, 20);
			label1.TabIndex = 78;
			label1.Text = "ID PROVEEDOR";
			// 
			// button2
			// 
			button2.DialogResult = DialogResult.Cancel;
			button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			button2.Location = new Point(265, 521);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 77;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			button1.DialogResult = DialogResult.OK;
			button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			button1.Location = new Point(139, 521);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 76;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			// 
			// IngresoEditarVistaVend
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSlateBlue;
			ClientSize = new Size(505, 631);
			Controls.Add(pictureBox1);
			Controls.Add(label6);
			Controls.Add(button3);
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
			Name = "IngresoEditarVistaVend";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "IngresoEditarVistaVend";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private Label label6;
		private Button button3;
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
	}
}