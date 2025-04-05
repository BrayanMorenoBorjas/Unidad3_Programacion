namespace Practica_19
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
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(165, 168);
            label1.Name = "label1";
            label1.Size = new Size(162, 32);
            label1.TabIndex = 0;
            label1.Text = "Calificación 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 231);
            label2.Name = "label2";
            label2.Size = new Size(162, 32);
            label2.TabIndex = 1;
            label2.Text = "Calificación 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 304);
            label3.Name = "label3";
            label3.Size = new Size(162, 32);
            label3.TabIndex = 2;
            label3.Text = "Calificación 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 374);
            label4.Name = "label4";
            label4.Size = new Size(162, 32);
            label4.TabIndex = 3;
            label4.Text = "Calificación 4";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(368, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 40);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(368, 228);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 40);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(368, 301);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(228, 40);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(368, 371);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(228, 40);
            textBox4.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(165, 41);
            label5.Name = "label5";
            label5.Size = new Size(431, 64);
            label5.TabIndex = 8;
            label5.Text = "Diagrama que solicita 4 calificaciones\r\ny te indica si estas aprobado o no\r\n";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Location = new Point(300, 443);
            button1.Name = "button1";
            button1.Size = new Size(152, 49);
            button1.TabIndex = 9;
            button1.Text = "Consultar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(738, 525);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label5;
        private Button button1;
    }
}
