namespace Desafio.TecnicoLLip.Domain.Models.Utility
{
    public class Token
    {
        public bool Autenticated { get; set; }
        public string Created { get; set; }
        public string Expiration { get; set; }
        public string AccessToken { get; set; }
        public string Message { get; set; }
    }
}
