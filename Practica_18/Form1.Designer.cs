namespace Practica_18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            textBox4 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 32);
            label1.Name = "label1";
            label1.Size = new Size(815, 32);
            label1.TabIndex = 0;
            label1.Text = "Diagrama que pida los 3 lados de un triangulo y te dice de que tipo es.";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Cursor = Cursors.IBeam;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(624, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(406, 434);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 139);
            label2.Name = "label2";
            label2.Size = new Size(195, 32);
            label2.TabIndex = 2;
            label2.Text = "Longitud Lado A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 207);
            label3.Name = "label3";
            label3.Size = new Size(193, 32);
            label3.TabIndex = 3;
            label3.Text = "Longitud Lado B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(129, 276);
            label4.Name = "label4";
            label4.Size = new Size(192, 32);
            label4.TabIndex = 4;
            label4.Text = "Longitud Lado C";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(450, 136);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 40);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(450, 204);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 40);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(450, 273);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 40);
            textBox3.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(87, 367);
            button1.Name = "button1";
            button1.Size = new Size(137, 46);
            button1.TabIndex = 8;
            button1.Text = "Decisión";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(264, 367);
            button2.Name = "button2";
            button2.Size = new Size(137, 46);
            button2.TabIndex = 9;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(438, 367);
            button3.Name = "button3";
            button3.Size = new Size(137, 46);
            button3.TabIndex = 10;
            button3.Text = "Salir";
            button3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(129, 462);
            label5.Name = "label5";
            label5.Size = new Size(170, 32);
            label5.TabIndex = 11;
            label5.Text = "Tipo Triangulo";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(346, 459);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(229, 40);
            textBox4.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1042, 570);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label5;
        private TextBox textBox4;
    }
}
