namespace Exercício_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Show();
        }

         private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}