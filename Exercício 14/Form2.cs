namespace Exercício_14
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numtextbox1 = Convert.ToInt32(textBox1.Text);
            Soma.soma = numtextbox1 + Soma.soma;
            textBox1.Text = Convert.ToString(Soma.soma);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
