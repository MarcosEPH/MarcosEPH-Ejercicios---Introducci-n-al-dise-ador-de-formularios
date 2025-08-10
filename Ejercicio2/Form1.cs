namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbConversion.Items.Add("Celsius a Fahrenheit");
            cmbConversion.Items.Add("Fahrenheit a Celsius");
            cmbConversion.SelectedIndex = 0;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (!double.TryParse(txtTemperatura.Text, out double temp))
            {
                errorProvider1.SetError(txtTemperatura, "Ingresa un número válido");
                return;
            }


            double resultado;
            if (cmbConversion.SelectedIndex == 0)
                resultado = (temp * 9 / 5) + 32; 
            else
                resultado = (temp - 32) * 5 / 9; 

            lblResultado.Text = $"Resultado: {resultado:F2}";
        }
    }
}
