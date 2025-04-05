namespace Practica_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            float valor1= float.Parse(textBox1.Text);
            float valor2= float.Parse(textBox2.Text);
            float resultado = (valor1 * valor2) / 2;

            textBox3.Text = resultado.ToString();
        }
    }
}
