namespace Serie3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double MontoPrestamo =
                double.Parse(Monto.Text);
            double TasaInteresAnual =
                double.Parse(InteresAnual.Text) / 100;
            int numeroCuotas =
                int.Parse(Cuotas.Text);
            double tasaInteresMensual =
                TasaInteresAnual / 12;
            double CuotaMensual =
                (MontoPrestamo * tasaInteresMensual) / (1 - Math.Pow(1 + tasaInteresMensual, -numeroCuotas));
            double TotalAPagar = CuotaMensual * numeroCuotas;
            double TotalIntereses = TotalAPagar - MontoPrestamo;
            Resultado.Text =
                "La Cuota Mensual es: " + CuotaMensual.ToString("C2");
            Resultado2.Text =
                 "El Total a Pagar es: " + TotalAPagar.ToString("C2");
            Resultado3.Text =
                "El Total de Intereses es: " + TotalIntereses.ToString("C2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Monto.Text = "";
            InteresAnual.Text = "";
            Cuotas.Text = "";
            Resultado.Text = "";
            Resultado2.Text = "";
            Resultado3.Text = "";
        }
    }
}
