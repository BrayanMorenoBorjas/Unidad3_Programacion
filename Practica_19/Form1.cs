namespace Practica_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            double c1, c2, c3, c4, promedio;
            c1=double.Parse(textBox1.Text);
            c2=double.Parse(textBox2.Text);
            c3=double.Parse(textBox3.Text);
            c4=double.Parse(textBox4.Text);

            promedio = (c1 + c2 + c3 + c4) / 4;
            if (promedio >= 6)
            {
                if ((c1 >= 6) && (c2 >= 6) && (c3 >= 6) && (c4 >= 6)) {
                    MessageBox.Show("Aprobado");
                }
                else { MessageBox.Show("Reprobado"); }
            }
            else { MessageBox.Show("Reprobado"); }
        }
    }
}
