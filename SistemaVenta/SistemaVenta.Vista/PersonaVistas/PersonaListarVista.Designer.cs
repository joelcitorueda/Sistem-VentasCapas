namespace SistemaVenta.Vista.PersonasVistas
{
	partial class PersonaListarVista
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
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			button4 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(12, 12);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView1.Size = new Size(887, 426);
			dataGridView1.TabIndex = 0;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// button1
			// 
			button1.DialogResult = DialogResult.OK;
			button1.Location = new Point(718, 469);
			button1.Name = "button1";
			button1.Size = new Size(135, 44);
			button1.TabIndex = 1;
			button1.Text = "SELECCIONAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(173, 469);
			button2.Name = "button2";
			button2.Size = new Size(140, 44);
			button2.TabIndex = 2;
			button2.Text = "AGREGAR";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Location = new Point(342, 469);
			button3.Name = "button3";
			button3.Size = new Size(140, 44);
			button3.TabIndex = 3;
			button3.Text = "EDITAR";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button4
			// 
			button4.Location = new Point(513, 469);
			button4.Name = "button4";
			button4.Size = new Size(140, 44);
			button4.TabIndex = 4;
			button4.Text = "ELIMAR";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// PersonaListarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(919, 541);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(dataGridView1);
			Name = "PersonaListarVista";
			Text = "PersonaListarVista";
			Load += PersonaListarVista_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dataGridView1;
		private Button button1;
		private Button button2;
		private Button button3;
		private Button button4;
	}
}