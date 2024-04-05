namespace SistemasVentas.VISTA.ProductoVistasProvee
{
	partial class ProductoListarVistaProvee
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
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
			button2 = new Button();
			pictureBox1 = new PictureBox();
			label2 = new Label();
			button5 = new Button();
			label3 = new Label();
			dataGridView1 = new DataGridView();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// button2
			// 
			button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button2.Image = Properties.Resources.icons8_comprar_27;
			button2.ImageAlign = ContentAlignment.MiddleRight;
			button2.Location = new Point(870, 75);
			button2.Name = "button2";
			button2.Size = new Size(188, 40);
			button2.TabIndex = 16;
			button2.Text = "COMPRA AQUI";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.icons8_productos_100;
			pictureBox1.Location = new Point(410, 21);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(261, 234);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 43;
			pictureBox1.TabStop = false;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Arial Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.White;
			label2.Location = new Point(784, 35);
			label2.Name = "label2";
			label2.Size = new Size(353, 28);
			label2.TabIndex = 44;
			label2.Text = "DESEA HACER UNA COMPRA ?";
			// 
			// button5
			// 
			button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button5.Image = Properties.Resources.icons8_cerrar_sesión_27;
			button5.ImageAlign = ContentAlignment.MiddleRight;
			button5.Location = new Point(21, 21);
			button5.Name = "button5";
			button5.Size = new Size(164, 42);
			button5.TabIndex = 48;
			button5.Text = "Log Out";
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.White;
			label3.Location = new Point(34, 286);
			label3.Name = "label3";
			label3.Size = new Size(337, 32);
			label3.TabIndex = 46;
			label3.Text = "LISTADO DE PRODUCTOS\r\n";
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dataGridView1.BackgroundColor = Color.DarkSlateBlue;
			dataGridView1.BorderStyle = BorderStyle.None;
			dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = Color.SlateBlue;
			dataGridViewCellStyle4.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			dataGridViewCellStyle4.ForeColor = Color.White;
			dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.EnableHeadersVisualStyles = false;
			dataGridView1.GridColor = Color.SteelBlue;
			dataGridView1.Location = new Point(83, 335);
			dataGridView1.Margin = new Padding(3, 4, 3, 4);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = Color.SlateBlue;
			dataGridViewCellStyle5.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			dataGridViewCellStyle5.ForeColor = Color.White;
			dataGridViewCellStyle5.SelectionBackColor = Color.SteelBlue;
			dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
			dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
			dataGridView1.RowHeadersWidth = 51;
			dataGridViewCellStyle6.BackColor = Color.DarkSlateBlue;
			dataGridViewCellStyle6.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			dataGridViewCellStyle6.ForeColor = Color.White;
			dataGridViewCellStyle6.SelectionBackColor = Color.SlateBlue;
			dataGridViewCellStyle6.SelectionForeColor = Color.White;
			dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
			dataGridView1.Size = new Size(984, 301);
			dataGridView1.TabIndex = 47;
			// 
			// ProductoListarVistaProvee
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSlateBlue;
			ClientSize = new Size(1171, 679);
			Controls.Add(button5);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(button2);
			Controls.Add(dataGridView1);
			Controls.Add(pictureBox1);
			Name = "ProductoListarVistaProvee";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ProductoListarVistaProvee";
			Load += ProductoListarVistaProvee_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Button button2;
		private PictureBox pictureBox1;
		private Label label2;
		private Button button5;
		private Label label3;
		private DataGridView dataGridView1;
	}
}