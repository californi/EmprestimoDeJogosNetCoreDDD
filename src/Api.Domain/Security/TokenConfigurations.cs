namespace Api.Domain.Security
{
    public class TokenConfigurations
    {
        //Publico
        public string Audience { get; set; }
        //Emissor
        public string Issuer { get; set; }
        //Validade
        public int Seconds { get; set; }
    }
}
