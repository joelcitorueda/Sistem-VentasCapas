namespace SistemasVentas.VISTA.Examen2
{
	partial class Consulta10
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
			dataGridView1 = new DataGridView();
			label1 = new Label();
			label2 = new Label();
			btnBuscar = new Button();
			txtMontoEspecificado = new TextBox();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(103, 154);
			dataGridView1.Margin = new Padding(3, 4, 3, 4);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(572, 254);
			dataGridView1.TabIndex = 4;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(63, 9);
			label1.Name = "label1";
			label1.Size = new Size(612, 62);
			label1.TabIndex = 6;
			label1.Text = "Encuentra los clientes que hayan realizado compras por \r\n\r\n";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.Location = new Point(92, 40);
			label2.Name = "label2";
			label2.Size = new Size(542, 31);
			label2.TabIndex = 7;
			label2.Text = "un monto superior a cierta cantidad especificada.";
			// 
			// btnBuscar
			// 
			btnBuscar.Location = new Point(675, 95);
			btnBuscar.Name = "btnBuscar";
			btnBuscar.Size = new Size(94, 29);
			btnBuscar.TabIndex = 8;
			btnBuscar.Text = "button1";
			btnBuscar.UseVisualStyleBackColor = true;
			btnBuscar.Click += btnBuscar_Click;
			// 
			// txtMontoEspecificado
			// 
			txtMontoEspecificado.Location = new Point(466, 97);
			txtMontoEspecificado.Name = "txtMontoEspecificado";
			txtMontoEspecificado.Size = new Size(168, 27);
			txtMontoEspecificado.TabIndex = 9;
			// 
			// Consulta10
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(txtMontoEspecificado);
			Controls.Add(btnBuscar);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(dataGridView1);
			Name = "Consulta10";
			Text = "Consulta10";
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
		private Label label1;
		private Label label2;
		private Button btnBuscar;
		private TextBox txtMontoEspecificado;
	}
}