namespace Api.Domain.Models
{
    public class JogadorModel : BaseModel
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _cidade;
        public string Cidade
        {
            get { return _cidade; }
            set { _cidade = value; }
        }


    }
}
