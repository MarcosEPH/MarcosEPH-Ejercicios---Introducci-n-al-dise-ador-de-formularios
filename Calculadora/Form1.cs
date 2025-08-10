namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ValidarNumeros(out double num1, out double num2)
        {
            num1 = num2 = 0;
            if (!double.TryParse(txtNum1.Text, out num1))
            {
                MessageBox.Show("Número 1 inválido");
                return false;
            }
            if (!double.TryParse(txtNum2.Text, out num2))
            {
                MessageBox.Show("Número 2 inválido");
                return false;
            }
            return true;

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (ValidarNumeros(out double a, out double b))
                lblResultado.Text = $"Resultado: {a + b}";

        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (ValidarNumeros(out double a, out double b))
                lblResultado.Text = $"Resultado: {a - b}";

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (ValidarNumeros(out double a, out double b))
                lblResultado.Text = $"Resultado: {a * b}";

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (ValidarNumeros(out double a, out double b))
            {
                if (b == 0)
                {
                    MessageBox.Show("No se puede dividir entre cero");
                    return;
                }

                lblResultado.Text = $"Resultado: {a / b}";
            }
          }
        }
    }

