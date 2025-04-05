namespace Practica_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ri, rs, suma = 0;
            ri = int.Parse(textBox1.Text);
            rs = int.Parse(textBox2.Text);
            for (int i = ri; i <= rs; i++)
            {
                listBox1.Items.Add(i);
                suma = suma + i;
            }
            textBox3.Text=suma.ToString();
        }
    }
}
