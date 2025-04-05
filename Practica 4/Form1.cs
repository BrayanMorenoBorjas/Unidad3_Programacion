namespace Practica_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radio, altura;
            double BaseArea, LateralArea, TotalArea;
            double Volumen;

            radio = double.Parse(textBox1.Text);
            altura = double.Parse(textBox2.Text);

            BaseArea = radio * radio * Math.PI;
            LateralArea = 2 * Math.PI * radio * altura;
            TotalArea = 2 * Math.PI * radio * (altura + radio);
            Volumen = Math.PI * radio * radio * altura;

            textBox3.Text = BaseArea.ToString("0.##");
            textBox4.Text = LateralArea.ToString("0.##");
            textBox5.Text = TotalArea.ToString("0.##");
            textBox6.Text = Volumen.ToString("0.##");
                

        }
    }
}
