﻿namespace SistemasVentas.VISTA.LoginIniciarSecion
{
	partial class LoginIniciarSecion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginIniciarSecion));
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			pictureBox3 = new PictureBox();
			txtNombreUsuario = new TextBox();
			txtContraseña = new TextBox();
			button1 = new Button();
			label1 = new Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(103, 49);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(116, 106);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(61, 199);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(36, 27);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 1;
			pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(61, 267);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(36, 27);
			pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox3.TabIndex = 2;
			pictureBox3.TabStop = false;
			// 
			// txtNombreUsuario
			// 
			txtNombreUsuario.Location = new Point(103, 199);
			txtNombreUsuario.Name = "txtNombreUsuario";
			txtNombreUsuario.Size = new Size(278, 27);
			txtNombreUsuario.TabIndex = 3;
			txtNombreUsuario.Tag = "";
			txtNombreUsuario.Text = "USUARIO";
			// 
			// txtContraseña
			// 
			txtContraseña.Location = new Point(103, 267);
			txtContraseña.Name = "txtContraseña";
			txtContraseña.Size = new Size(278, 27);
			txtContraseña.TabIndex = 4;
			txtContraseña.Text = "PASSWORD";
			// 
			// button1
			// 
			button1.ForeColor = Color.Black;
			button1.Location = new Point(190, 325);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 5;
			button1.Text = "LOGIN";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(225, 81);
			label1.Name = "label1";
			label1.Size = new Size(132, 46);
			label1.TabIndex = 6;
			label1.Text = "Sign In";
			// 
			// LoginIniciarSecion
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(64, 64, 64);
			ClientSize = new Size(474, 450);
			Controls.Add(label1);
			Controls.Add(button1);
			Controls.Add(txtContraseña);
			Controls.Add(txtNombreUsuario);
			Controls.Add(pictureBox3);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox1);
			Name = "LoginIniciarSecion";
			Text = "LoginIniciarSecion";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
		private PictureBox pictureBox3;
		private TextBox txtNombreUsuario;
		private TextBox txtContraseña;
		private Button button1;
		private Label label1;
	}
}