namespace Cambios.Servicos
{
    using System.Net;
    using Modelos;
    public class NetworkService
    {
        public Resposnse CheckConnection()
        {
            var client = new WebClient();
            try
            {
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return new Resposnse
                    {
                        IsSuccess = true
                    };
                }
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
