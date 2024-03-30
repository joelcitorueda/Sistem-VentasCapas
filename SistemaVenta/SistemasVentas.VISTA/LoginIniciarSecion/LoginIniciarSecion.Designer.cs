namespace SistemasVentas.VISTA.LoginIniciarSecion
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
			label2 = new Label();
			label3 = new Label();
			iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(353, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(116, 106);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(311, 152);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(36, 27);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 1;
			pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
			pictureBox3.Location = new Point(311, 220);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(36, 27);
			pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox3.TabIndex = 2;
			pictureBox3.TabStop = false;
			// 
			// txtNombreUsuario
			// 
			txtNombreUsuario.BackColor = Color.Black;
			txtNombreUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtNombreUsuario.ForeColor = Color.White;
			txtNombreUsuario.Location = new Point(353, 152);
			txtNombreUsuario.Name = "txtNombreUsuario";
			txtNombreUsuario.Size = new Size(207, 27);
			txtNombreUsuario.TabIndex = 3;
			txtNombreUsuario.Tag = "";
			txtNombreUsuario.Text = "USUARIO";
			// 
			// txtContraseña
			// 
			txtContraseña.BackColor = Color.Black;
			txtContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			txtContraseña.ForeColor = Color.White;
			txtContraseña.Location = new Point(353, 220);
			txtContraseña.Name = "txtContraseña";
			txtContraseña.PasswordChar = '*';
			txtContraseña.Size = new Size(207, 27);
			txtContraseña.TabIndex = 4;
			txtContraseña.Text = "PASSWORD";
			// 
			// button1
			// 
			button1.BackColor = Color.SlateBlue;
			button1.Cursor = Cursors.Hand;
			button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button1.ForeColor = Color.White;
			button1.Location = new Point(403, 274);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 5;
			button1.Text = "LOGIN";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.BackColor = Color.Black;
			label1.Font = new Font("Gill Sans Ultra Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.White;
			label1.Location = new Point(466, 48);
			label1.Name = "label1";
			label1.Size = new Size(111, 31);
			label1.TabIndex = 6;
			label1.Text = "Sign In";
			// 
			// label2
			// 
			label2.BackColor = Color.SlateBlue;
			label2.Dock = DockStyle.Left;
			label2.Location = new Point(0, 0);
			label2.Name = "label2";
			label2.Size = new Size(304, 333);
			label2.TabIndex = 7;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.BackColor = Color.SlateBlue;
			label3.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.White;
			label3.Location = new Point(28, 231);
			label3.Name = "label3";
			label3.Size = new Size(250, 29);
			label3.TabIndex = 8;
			label3.Text = "SISTEMA DE VENTA";
			// 
			// iconPictureBox1
			// 
			iconPictureBox1.BackColor = Color.SlateBlue;
			iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Store;
			iconPictureBox1.IconColor = Color.White;
			iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
			iconPictureBox1.IconSize = 194;
			iconPictureBox1.Location = new Point(55, 34);
			iconPictureBox1.Name = "iconPictureBox1";
			iconPictureBox1.Size = new Size(199, 194);
			iconPictureBox1.TabIndex = 9;
			iconPictureBox1.TabStop = false;
			// 
			// LoginIniciarSecion
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Black;
			ClientSize = new Size(601, 333);
			Controls.Add(iconPictureBox1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(button1);
			Controls.Add(txtContraseña);
			Controls.Add(txtNombreUsuario);
			Controls.Add(pictureBox3);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox1);
			Name = "LoginIniciarSecion";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "LoginIniciarSecion";
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
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
		private Label label2;
		private Label label3;
		private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
	}
}