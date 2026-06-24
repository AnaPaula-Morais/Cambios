namespace Cambios.Servicos
{
    using System.Net;
    using Modelos;
    public class NetworkService
    {
        public async Task<Resposnse> CheckConnection()
        {
            var client = new HttpClient();
            try
            {
                var response = await client.GetAsync("http://clients3.google.com/generate_204");
                if (response.IsSuccessStatusCode)
                {
                    return new Resposnse
                    {
                        IsSuccess = true
                    };
                } 
                
                return new Resposnse
                {
                    IsSuccess = false,
                    Message = "Configure a sua ligação com a internt",
                };
            }
            catch
            {
                return new Resposnse
                {
                    IsSuccess = false,
                    Message = "Configure a sua ligação com a internt",
                };
            }
        }
    }
}
