﻿namespace SistemaVenta.Vista.TipoProdVistas
{
	partial class TipoProdInsertarVista
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
			button1 = new Button();
			label1 = new Label();
			textBox1 = new TextBox();
			label2 = new Label();
			button2 = new Button();
			button3 = new Button();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(90, 173);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 0;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(108, 30);
			label1.Name = "label1";
			label1.Size = new Size(179, 20);
			label1.TabIndex = 1;
			label1.Text = "INSERTE TIPO PRODUCTO";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(149, 97);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(249, 27);
			textBox1.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(46, 100);
			label2.Name = "label2";
			label2.Size = new Size(70, 20);
			label2.TabIndex = 3;
			label2.Text = "NOMBRE";
			// 
			// button2
			// 
			button2.Location = new Point(243, 173);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 4;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Location = new Point(388, 97);
			button3.Name = "button3";
			button3.Size = new Size(10, 29);
			button3.TabIndex = 5;
			button3.Text = "SELECCIONAR";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// TipoProdInsertarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(627, 281);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(label2);
			Controls.Add(textBox1);
			Controls.Add(label1);
			Controls.Add(button1);
			Name = "TipoProdInsertarVista";
			Text = "TipoProdInsertarVista";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private Label label1;
		private TextBox textBox1;
		private Label label2;
		private Button button2;
		private Button button3;
	}
}