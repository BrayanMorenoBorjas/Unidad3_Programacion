namespace Practica_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v1, far;
            v1 = double.Parse(textBox1.Text);
            far = v1 * (9.00 / 5.00) + 32;
            Resultado.Text = far.ToString();
            label5.Text = "Fahrenheit";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double v1, cen;
            v1 = double.Parse(textBox1.Text);
            cen = (v1 - 32) * (5.0 / 9.0);
            Resultado.Text = cen.ToString();
            label5.Text = "Centigrados";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Resultado.Text = "";
        }



        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void label5_Click(object sender, EventArgs e)
        {
        }

     
    }
}
