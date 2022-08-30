using System.Security.Cryptography.X509Certificates;

namespace Aula01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String texto = caixa1.Text;
            String texto2 = caixa2.Text;

            int soma;
            soma = Int32.Parse(texto) + Int32.Parse(texto2);

            label1.Text = soma.ToString();

            int x, y;
            x = int.Parse(texto);
            y = int.Parse(texto2);

            if (x >= y)
            {
                comparar.Text = "O primeiro é maior ou igual";
            }
            else
                comparar.Text = "o primeiro é menor";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String texto = caixa1.Text;
            String texto2 = caixa2.Text;

            int subtracao;
            subtracao = Int32.Parse(texto) - Int32.Parse(texto2);

            label1.Text = subtracao.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String texto = caixa1.Text;
            String texto2 = caixa2.Text;

            int divisao;
            divisao = Int32.Parse(texto) / Int32.Parse(texto2);

            label1.Text = divisao.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String texto = caixa1.Text;
            String texto2 = caixa2.Text;

            int multiplicacao;
            multiplicacao = Int32.Parse(texto) * Int32.Parse(texto2);

            label1.Text = multiplicacao.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            String ValorDigitado = textBox1.Text;
            int y = Int32.Parse(ValorDigitado);

            Random randNum = new Random(); 
            int x = randNum.Next(10);

            if (y == x)
            {
                resultadoadv.Text = "Você acertou!";
                resultadoadv.BackColor = Color.Green;
                resultadoadv.ForeColor = Color.Orange;
            }
            else
            { 
                resultadoadv.Text = "Você errou!";
                resultadoadv.BackColor = Color.Black;
                resultadoadv.ForeColor = Color.Red;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}