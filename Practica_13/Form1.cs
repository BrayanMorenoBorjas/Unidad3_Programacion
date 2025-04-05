namespace Practica_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sueldo, aumento, ns;
            sueldo = double.Parse(textBox1.Text);
            if (sueldo < 40000)
            {
                aumento = sueldo * 0.15;
                ns = sueldo + aumento;
                textBox2.Text = ns.ToString();
            }
        }
    }
}
