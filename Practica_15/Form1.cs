namespace Practica_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sueldo, ns;
            sueldo = double.Parse(textBox1.Text);
            if (sueldo < 40000.00)
            {
                ns = sueldo * 1.15;
            }
            else ns = sueldo * 1.08;

            textBox2.Text = ns.ToString();
        }
    }
}
