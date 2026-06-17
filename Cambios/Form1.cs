using Cambios.Modelos;
using Newtonsoft.Json;

namespace Cambios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadRates();

        }

        private async void LoadRates()
        {
            //bool load;

            progressBar1.Value = 0;

            var client = new HttpClient();
            client.BaseAddress = new Uri("http://rates.somee.com");

            var response = await client.GetAsync("/api/Rates");

            var result = await response.Content.ReadAsStringAsync();

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show(response.ReasonPhrase);
                return;
            }

            var rates = JsonConvert.DeserializeObject<List<Rate>>(result);

            comboBoxOrigem.DataSource = rates;
            comboBoxOrigem.DisplayMember = "Name";

            comboBoxDestino.BindingContext = new BindingContext();

            comboBoxDestino.DataSource = rates;
            comboBoxDestino.DisplayMember = "Name";

            progressBar1.Value = 100;
        }
    }
}
