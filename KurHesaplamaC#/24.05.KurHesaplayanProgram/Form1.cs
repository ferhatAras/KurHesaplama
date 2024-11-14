using System.Xml;

namespace _24._05.KurHesaplayanProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Kullanýcýdan alýnan miktarlarý al
                double euroAmount = double.Parse(textBoxEuro.Text);
                double dolarAmount = double.Parse(textBoxDolar.Text);
                double sterlinAmount = double.Parse(textBoxSterlin.Text);

                // API'den kurlarý al
                var rates = await GetExchangeRates();

                // Sonuçlarý hesapla
                double euroToTRY = euroAmount * rates["EUR"];
                double dolarToTRY = dolarAmount * rates["USD"];
                double sterlinToTRY = sterlinAmount * rates["GBP"];

                // Sonuçlarý göster
                labelEuroResult.Text = $"EUR: {euroToTRY} TRY";
                labelDolarResult.Text = $"USD: {dolarToTRY} TRY";
                labelSterlinResult.Text = $"GBP: {sterlinToTRY} TRY";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
