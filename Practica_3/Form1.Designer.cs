﻿namespace Practica_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            button2 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(193, 52);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(508, 32);
            label1.TabIndex = 0;
            label1.Text = "Este programa suma los numeros capturados\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(193, 153);
            label2.Name = "label2";
            label2.Size = new Size(246, 32);
            label2.TabIndex = 1;
            label2.Text = "Introduce un numero";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(454, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 40);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Location = new Point(500, 191);
            button1.Name = "button1";
            button1.Size = new Size(110, 42);
            button1.TabIndex = 3;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(717, 153);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 228);
            listBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Location = new Point(17, 328);
            button2.Name = "button2";
            button2.Size = new Size(170, 85);
            button2.TabIndex = 5;
            button2.Text = "Sumar\r\nNumeros\r\n";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(193, 381);
            label3.Name = "label3";
            label3.Size = new Size(255, 32);
            label3.TabIndex = 6;
            label3.Text = "La suma de todos es:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(454, 373);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(209, 40);
            textBox2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 590);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private ListBox listBox1;
        private Button button2;
        private Label label3;
        private TextBox textBox2;
    }
}
