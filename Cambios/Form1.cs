using Cambios.Modelos;
using Cambios.Servicos;
using Newtonsoft.Json;
using System.ComponentModel;

namespace Cambios
{
    public partial class Form1 : Form
    {
        #region Atributos
        private List<Rate> Rates;
        private NetworkService networkService;
        private ApiService apiService;
        private DialogService dialogService;
        private DataService dataService;

        #endregion
        public Form1()
        {
            InitializeComponent();
            networkService = new NetworkService();
            apiService = new ApiService();
            dialogService = new DialogService();
            dataService = new DataService();
            LoadRates();

        }

        private async void LoadRates()
        {
            bool load;

            labelResultado.Text = "A atualizar taxas...";
            var connection = await networkService.CheckConnection();

            if (!connection.IsSuccess)
            {
                //dados locais
                loadLocalRates();
                load = false;
                
            }
            else
            {
                //dados da api
                await LoadApiRates();
                load = true;
            }

            if (Rates.Count == 0)
            {
                labelResultado.Text = "Não há ligação à internet" + Environment.NewLine +
                    "e não foram previamente carregadas as taxas" + Environment.NewLine +
                    "Tente mais tarde!";
                labelStatus.Text = "Primeira Inicialização deverá ter ligação à internet";
                return;
            }

            comboBoxOrigem.DataSource = Rates;
            comboBoxOrigem.DisplayMember = "Name";

            comboBoxDestino.BindingContext = new BindingContext();

            comboBoxDestino.DataSource = Rates;
            comboBoxDestino.DisplayMember = "Name";

            
            labelResultado.Text = "Taxas atualizadas...";

            if (load)
            {
                labelStatus.Text = string.Format("Taxas carregadas da internet em {0:F}", DateTime.Now);
            }
            else
            {
                labelStatus.Text = string.Format("Taxas carregadas da Base de Dados.");
            }

            progressBar1.Value = 100;
            buttonConverter.Enabled = true;
            btnTroca.Enabled = true;
        }

        private void loadLocalRates()
        {
            Rates = dataService.GetData();
        }

        private async Task LoadApiRates()
        {
            progressBar1.Value = 0;
            var response = await apiService.GetRates("http://rates.somee.com", "/api/rates");

            Rates = (List<Rate>)response.Result;

            dataService.DeleteData();
            dataService.SaveData(Rates);
        }

        private void buttonConverter_Click(object sender, EventArgs e)
        {
            Converter();
        }

        private void Converter()
        {
            if (string.IsNullOrEmpty(textBoxValor.Text))
            {
                dialogService.ShowMessage("Erro", "Insira um valor a converter");
                return;
            }

            decimal valor;
            if (!decimal.TryParse(textBoxValor.Text, out valor))
            {
                dialogService.ShowMessage("Erro de converção", "Valor terá que ser numérico");
                return;
            }

            if (comboBoxOrigem.SelectedItem == null)
            {
                dialogService.ShowMessage("Erro", "Tem que escolher uma moeda a converter");
                return;
            }

            if (comboBoxDestino.SelectedItem == null)
            {
                dialogService.ShowMessage("Erro", "Tem que escolher uma moeda de destino para converter");
                return;
            }

            var taxaOrigem = (Rate)comboBoxOrigem.SelectedItem;
            var taxaDestino = (Rate)comboBoxDestino.SelectedItem;

            var valorConvertido = valor / (decimal)taxaOrigem.TaxRate * (decimal)taxaDestino.TaxRate;
            labelResultado.Text = string.Format("{0} {1:C2} = {2} {3:C2}",
                taxaOrigem.Code, valor,
                taxaDestino.Code,
                valorConvertido);
        }

        private void btnTroca_Click(object sender, EventArgs e)
        {
            Trocar();
        }

        private void Trocar()
        {
            var aux = comboBoxOrigem.SelectedItem;
            comboBoxOrigem.SelectedItem = comboBoxDestino.SelectedItem;
            comboBoxDestino.SelectedItem = aux;
            Converter();
        }
    }
}
