﻿namespace SistemasVentas.VISTA.UsuarioRolVistas
{
    partial class UsuarioRolEditarVista
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
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            button4 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(156, 137);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(335, 27);
            dateTimePicker1.TabIndex = 52;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(156, 185);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(313, 27);
            textBox3.TabIndex = 51;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(156, 89);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(313, 27);
            textBox2.TabIndex = 50;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(156, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(313, 27);
            textBox1.TabIndex = 49;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 142);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 48;
            label4.Text = "FECHA ASIGNA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 185);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 47;
            label3.Text = "ESTADO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 92);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 46;
            label2.Text = "ID ROL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 36);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 45;
            label1.Text = "ID USUARIO";
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(375, 336);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 44;
            button2.Text = "CANCELAR";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(135, 336);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 43;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(513, 87);
            button4.Name = "button4";
            button4.Size = new Size(121, 29);
            button4.TabIndex = 54;
            button4.Text = "SELECCIONAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(513, 36);
            button3.Name = "button3";
            button3.Size = new Size(121, 29);
            button3.TabIndex = 53;
            button3.Text = "SELECCIONAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // UsuarioRolEditarVista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 450);
            Controls.Add(button4);
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
            Name = "UsuarioRolEditarVista";
            Text = "UsuarioRolEditarVista";
            Load += UsuarioRolEditarVista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Button button4;
        private Button button3;
    }
}