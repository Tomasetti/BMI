using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace BMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcoloBMI_Click(object sender, EventArgs e)
        {
            try
            {
                double altezza = CheckDouble(txtAltezza.Text, "Altezza");
                double peso = CheckDouble(txtPeso.Text, "Peso");
                CheckPositive(altezza, "Altezza");
                CheckPositive(peso, "Peso");

                BMI bmi = new(peso, altezza);

                txtRisultato.Text = $"BMI: {bmi.Indice.ToString("0.00")} Stato: {bmi.Stato}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private double CheckDouble(string value, string field)
        {
            if (double.TryParse(value, CultureInfo.GetCultureInfo("IT-it"), out double altezza))
                return altezza;
            throw new Exception($"Il valore {field} deve essere un numerico");
        }

        private void CheckPositive(double value, string field)
        {
            if (value <= 0)
                throw new Exception($"Il valore {field} deve essere positivo");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (var c in Controls)
                if (c is TextBox)
                    ((TextBox)c).Text = string.Empty;
        }

    }
}
