namespace Practica_6
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
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            Resultado = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 43);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 0;
            label1.Text = "Datos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 189);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(269, 32);
            label3.TabIndex = 2;
            label3.Text = "Opciones de conversión";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Location = new Point(101, 224);
            button1.Name = "button1";
            button1.Size = new Size(153, 56);
            button1.TabIndex = 3;
            button1.Text = "Fahrenheit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Location = new Point(314, 224);
            button2.Name = "button2";
            button2.Size = new Size(153, 56);
            button2.TabIndex = 4;
            button2.Text = "Centigrados";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 192, 192);
            button3.Location = new Point(224, 286);
            button3.Name = "button3";
            button3.Size = new Size(108, 56);
            button3.TabIndex = 5;
            button3.Text = "Borrar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(101, 366);
            label4.Name = "label4";
            label4.Size = new Size(239, 32);
            label4.TabIndex = 6;
            label4.Text = "Resultado en grados";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(346, 366);
            label5.Name = "label5";
            label5.Size = new Size(0, 32);
            label5.TabIndex = 7;
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(158, 417);
            label6.Name = "label6";
            label6.Size = new Size(265, 32);
            label6.TabIndex = 8;
            label6.Text = "Equivalente en grados:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 99);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(191, 32);
            label2.TabIndex = 1;
            label2.Text = "Ingresa el valor";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(342, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 40);
            textBox1.TabIndex = 9;
            // 
            // Resultado
            // 
            Resultado.Location = new Point(196, 470);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(174, 40);
            Resultado.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(585, 605);
            Controls.Add(Resultado);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Conversiones";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label2;
        private TextBox textBox1;
        private TextBox Resultado;
    }
}
