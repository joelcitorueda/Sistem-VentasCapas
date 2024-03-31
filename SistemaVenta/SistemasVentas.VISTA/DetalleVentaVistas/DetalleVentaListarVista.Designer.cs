namespace SistemasVentas.VISTA.DetalleVentaVistas
{
    partial class DetalleVentaListarVista
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetalleVentaListarVista));
			dataGridView1 = new DataGridView();
			button4 = new Button();
			button3 = new Button();
			button2 = new Button();
			button1 = new Button();
			button5 = new Button();
			label2 = new Label();
			label1 = new Label();
			btnGuardarPDF = new Button();
			btnGuardarExcel = new Button();
			label3 = new Label();
			pServicios = new Panel();
			button18 = new Button();
			button17 = new Button();
			button16 = new Button();
			button15 = new Button();
			button14 = new Button();
			button13 = new Button();
			button12 = new Button();
			button11 = new Button();
			button10 = new Button();
			button9 = new Button();
			button8 = new Button();
			button7 = new Button();
			button6 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			pServicios.SuspendLayout();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.AllowUserToAddRows = false;
			dataGridView1.AllowUserToDeleteRows = false;
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(63, 179);
			dataGridView1.Margin = new Padding(3, 4, 3, 4);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.ReadOnly = true;
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(706, 373);
			dataGridView1.TabIndex = 2;
			// 
			// button4
			// 
			button4.Image = Properties.Resources.icons8_eliminar_27;
			button4.ImageAlign = ContentAlignment.MiddleRight;
			button4.Location = new Point(435, 64);
			button4.Name = "button4";
			button4.Size = new Size(161, 34);
			button4.TabIndex = 16;
			button4.Text = "ELIMINAR";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// button3
			// 
			button3.Image = Properties.Resources.icons8_editar_27;
			button3.ImageAlign = ContentAlignment.MiddleRight;
			button3.Location = new Point(231, 64);
			button3.Name = "button3";
			button3.Size = new Size(161, 34);
			button3.TabIndex = 15;
			button3.Text = "EDITAR";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// button2
			// 
			button2.Image = (Image)resources.GetObject("button2.Image");
			button2.ImageAlign = ContentAlignment.MiddleRight;
			button2.Location = new Point(24, 64);
			button2.Name = "button2";
			button2.Size = new Size(161, 34);
			button2.TabIndex = 14;
			button2.Text = "AGREGAR";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.DialogResult = DialogResult.OK;
			button1.Image = Properties.Resources.icons8_marque_todas_las_27;
			button1.ImageAlign = ContentAlignment.MiddleRight;
			button1.Location = new Point(637, 64);
			button1.Name = "button1";
			button1.Size = new Size(161, 34);
			button1.TabIndex = 13;
			button1.Text = "SELECCIONAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button5
			// 
			button5.ForeColor = Color.SlateBlue;
			button5.Image = (Image)resources.GetObject("button5.Image");
			button5.Location = new Point(766, 12);
			button5.Name = "button5";
			button5.Size = new Size(62, 43);
			button5.TabIndex = 18;
			button5.UseVisualStyleBackColor = true;
			button5.Click += button5_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.BackColor = Color.SlateBlue;
			label2.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.White;
			label2.Location = new Point(174, 12);
			label2.Name = "label2";
			label2.Size = new Size(479, 31);
			label2.TabIndex = 19;
			label2.Text = "ADMINISTRACION DE DETALLES VENTAS";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.Black;
			label1.Location = new Point(24, 129);
			label1.Name = "label1";
			label1.Size = new Size(321, 28);
			label1.TabIndex = 20;
			label1.Text = "LISTADO DE DETALLES VENTAS";
			// 
			// btnGuardarPDF
			// 
			btnGuardarPDF.Image = Properties.Resources.icons8_pdf_27;
			btnGuardarPDF.ImageAlign = ContentAlignment.MiddleRight;
			btnGuardarPDF.Location = new Point(155, 575);
			btnGuardarPDF.Name = "btnGuardarPDF";
			btnGuardarPDF.Size = new Size(173, 34);
			btnGuardarPDF.TabIndex = 21;
			btnGuardarPDF.Text = "GENERAR PDF";
			btnGuardarPDF.UseVisualStyleBackColor = true;
			btnGuardarPDF.Click += btnGuardarPDF_Click;
			// 
			// btnGuardarExcel
			// 
			btnGuardarExcel.Image = Properties.Resources.icons8_ms_excel_27;
			btnGuardarExcel.ImageAlign = ContentAlignment.MiddleRight;
			btnGuardarExcel.Location = new Point(373, 575);
			btnGuardarExcel.Name = "btnGuardarExcel";
			btnGuardarExcel.Size = new Size(173, 34);
			btnGuardarExcel.TabIndex = 22;
			btnGuardarExcel.Text = "GENERAR EXCEL";
			btnGuardarExcel.UseVisualStyleBackColor = true;
			btnGuardarExcel.Click += btnGuardarExcel_Click;
			// 
			// label3
			// 
			label3.BackColor = Color.SlateBlue;
			label3.Location = new Point(0, -8);
			label3.Name = "label3";
			label3.Size = new Size(841, 125);
			label3.TabIndex = 23;
			// 
			// pServicios
			// 
			pServicios.BackColor = Color.SlateBlue;
			pServicios.Controls.Add(button18);
			pServicios.Controls.Add(button17);
			pServicios.Controls.Add(button16);
			pServicios.Controls.Add(button15);
			pServicios.Controls.Add(button14);
			pServicios.Controls.Add(button13);
			pServicios.Controls.Add(button12);
			pServicios.Controls.Add(button11);
			pServicios.Controls.Add(button10);
			pServicios.Controls.Add(button9);
			pServicios.Controls.Add(button8);
			pServicios.Controls.Add(button7);
			pServicios.Controls.Add(button6);
			pServicios.Location = new Point(670, 51);
			pServicios.Name = "pServicios";
			pServicios.Size = new Size(158, 548);
			pServicios.TabIndex = 24;
			pServicios.Visible = false;
			// 
			// button18
			// 
			button18.FlatAppearance.MouseOverBackColor = Color.Lime;
			button18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button18.Location = new Point(0, 495);
			button18.Name = "button18";
			button18.Size = new Size(158, 43);
			button18.TabIndex = 19;
			button18.Text = "Venta";
			button18.UseVisualStyleBackColor = true;
			button18.Click += button18_Click;
			// 
			// button17
			// 
			button17.FlatAppearance.MouseOverBackColor = Color.Lime;
			button17.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button17.Location = new Point(0, 455);
			button17.Name = "button17";
			button17.Size = new Size(158, 43);
			button17.TabIndex = 18;
			button17.Text = "Usuario";
			button17.UseVisualStyleBackColor = true;
			button17.Click += button17_Click;
			// 
			// button16
			// 
			button16.FlatAppearance.MouseOverBackColor = Color.Lime;
			button16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button16.Location = new Point(0, 415);
			button16.Name = "button16";
			button16.Size = new Size(158, 43);
			button16.TabIndex = 17;
			button16.Text = "Usuario Rol";
			button16.UseVisualStyleBackColor = true;
			button16.Click += button16_Click;
			// 
			// button15
			// 
			button15.FlatAppearance.MouseOverBackColor = Color.Lime;
			button15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button15.Location = new Point(0, 375);
			button15.Name = "button15";
			button15.Size = new Size(158, 43);
			button15.TabIndex = 16;
			button15.Text = "Tipo Productos";
			button15.UseVisualStyleBackColor = true;
			button15.Click += button15_Click;
			// 
			// button14
			// 
			button14.FlatAppearance.MouseOverBackColor = Color.Lime;
			button14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button14.Location = new Point(0, 335);
			button14.Name = "button14";
			button14.Size = new Size(158, 43);
			button14.TabIndex = 15;
			button14.Text = "Roles";
			button14.UseVisualStyleBackColor = true;
			button14.Click += button14_Click;
			// 
			// button13
			// 
			button13.FlatAppearance.MouseOverBackColor = Color.Lime;
			button13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button13.Location = new Point(0, 295);
			button13.Name = "button13";
			button13.Size = new Size(158, 43);
			button13.TabIndex = 14;
			button13.Text = "Provee";
			button13.UseVisualStyleBackColor = true;
			button13.Click += button13_Click;
			// 
			// button12
			// 
			button12.FlatAppearance.MouseOverBackColor = Color.Lime;
			button12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button12.Location = new Point(0, 255);
			button12.Name = "button12";
			button12.Size = new Size(158, 43);
			button12.TabIndex = 13;
			button12.Text = "Proveedor";
			button12.UseVisualStyleBackColor = true;
			button12.Click += button12_Click;
			// 
			// button11
			// 
			button11.FlatAppearance.MouseOverBackColor = Color.Lime;
			button11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button11.Location = new Point(0, 216);
			button11.Name = "button11";
			button11.Size = new Size(158, 43);
			button11.TabIndex = 12;
			button11.Text = "Productos";
			button11.UseVisualStyleBackColor = true;
			button11.Click += button11_Click;
			// 
			// button10
			// 
			button10.FlatAppearance.MouseOverBackColor = Color.Lime;
			button10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button10.Location = new Point(0, 177);
			button10.Name = "button10";
			button10.Size = new Size(158, 43);
			button10.TabIndex = 11;
			button10.Text = "Personas";
			button10.UseVisualStyleBackColor = true;
			button10.Click += button10_Click;
			// 
			// button9
			// 
			button9.FlatAppearance.MouseOverBackColor = Color.Lime;
			button9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button9.Location = new Point(0, 138);
			button9.Name = "button9";
			button9.Size = new Size(158, 43);
			button9.TabIndex = 10;
			button9.Text = "Marcas";
			button9.UseVisualStyleBackColor = true;
			button9.Click += button9_Click;
			// 
			// button8
			// 
			button8.FlatAppearance.MouseOverBackColor = Color.Lime;
			button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button8.Location = new Point(0, 97);
			button8.Name = "button8";
			button8.Size = new Size(158, 43);
			button8.TabIndex = 9;
			button8.Text = "Ingresos";
			button8.UseVisualStyleBackColor = true;
			button8.Click += button8_Click;
			// 
			// button7
			// 
			button7.FlatAppearance.MouseOverBackColor = Color.Lime;
			button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button7.Location = new Point(0, 13);
			button7.Name = "button7";
			button7.Size = new Size(158, 43);
			button7.TabIndex = 8;
			button7.Text = "Clientes";
			button7.UseVisualStyleBackColor = true;
			button7.Click += button7_Click;
			// 
			// button6
			// 
			button6.FlatAppearance.MouseOverBackColor = Color.Lime;
			button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button6.Location = new Point(0, 53);
			button6.Name = "button6";
			button6.Size = new Size(158, 53);
			button6.TabIndex = 7;
			button6.Text = "Detalle Ing";
			button6.UseVisualStyleBackColor = true;
			button6.Click += button6_Click;
			// 
			// DetalleVentaListarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(840, 623);
			Controls.Add(pServicios);
			Controls.Add(button1);
			Controls.Add(button4);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button5);
			Controls.Add(label2);
			Controls.Add(label3);
			Controls.Add(btnGuardarExcel);
			Controls.Add(btnGuardarPDF);
			Controls.Add(label1);
			Controls.Add(dataGridView1);
			ForeColor = Color.Black;
			Name = "DetalleVentaListarVista";
			Text = "DetalleVentaListarVista";
			Load += DetalleVentaListarVista_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			pServicios.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
		private Button button5;
		private Label label2;
		private Label label1;
		private Button btnGuardarPDF;
		private Button btnGuardarExcel;
		private Label label3;
		private Panel pServicios;
		private Button button18;
		private Button button17;
		private Button button16;
		private Button button15;
		private Button button14;
		private Button button13;
		private Button button12;
		private Button button11;
		private Button button10;
		private Button button9;
		private Button button8;
		private Button button7;
		private Button button6;
	}
}