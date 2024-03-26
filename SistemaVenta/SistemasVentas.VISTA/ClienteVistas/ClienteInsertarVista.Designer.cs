namespace SistemasVentas.VISTA.ClienteVistas
{
    partial class ClienteInsertarVista
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
			button2 = new Button();
			button1 = new Button();
			textBox3 = new TextBox();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			button3 = new Button();
			SuspendLayout();
			// 
			// button2
			// 
			button2.DialogResult = DialogResult.Cancel;
			button2.Location = new Point(373, 269);
			button2.Name = "button2";
			button2.Size = new Size(94, 29);
			button2.TabIndex = 23;
			button2.Text = "CANCELAR";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button1
			// 
			button1.DialogResult = DialogResult.OK;
			button1.Location = new Point(145, 269);
			button1.Name = "button1";
			button1.Size = new Size(94, 29);
			button1.TabIndex = 22;
			button1.Text = "GUARDAR";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(133, 114);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(334, 27);
			textBox3.TabIndex = 19;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(133, 77);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(334, 27);
			textBox2.TabIndex = 18;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(133, 38);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(334, 27);
			textBox1.TabIndex = 17;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(5, 119);
			label3.Name = "label3";
			label3.Size = new Size(124, 20);
			label3.TabIndex = 14;
			label3.Text = "CODIGO CLIENTE";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(30, 84);
			label2.Name = "label2";
			label2.Size = new Size(99, 20);
			label2.TabIndex = 13;
			label2.Text = "TIPO CLIENTE";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(40, 41);
			label1.Name = "label1";
			label1.Size = new Size(74, 20);
			label1.TabIndex = 12;
			label1.Text = "PERSONA";
			// 
			// button3
			// 
			button3.Location = new Point(495, 38);
			button3.Name = "button3";
			button3.Size = new Size(114, 29);
			button3.TabIndex = 33;
			button3.Text = "SELECCIONAR";
			button3.UseVisualStyleBackColor = true;
			button3.Click += button3_Click;
			// 
			// ClienteInsertarVista
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(642, 345);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "ClienteInsertarVista";
			Text = "ClienteInsertarVista";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button2;
        private Button button1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button3;
    }
}