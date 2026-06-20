

namespace Cambios.Servicos
{
    using Modelos;
    using Newtonsoft.Json;
    public class ApiService
    {
        public async Task<Resposnse> GetRates(string urlBase, string controller)
        {
            try
            {
                var client = new HttpClient();
                client.BaseAddress = new Uri(urlBase);

                var response = await client.GetAsync(controller);

                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return new Resposnse
                    {
                        IsSuccess = false,
                        Message = result
                    };
                }

                var rates = JsonConvert.DeserializeObject<List<Rate>>(result);

                return new Resposnse
                {

                    IsSuccess = true,
                    Result = rates
                };
            }
            catch (Exception ex)
            {
                return new Resposnse
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }
    }
}
