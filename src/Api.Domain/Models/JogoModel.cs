using System;

namespace Api.Domain.Models
{
    public class JogoModel : BaseModel
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private Guid _jogadorId;
        public Guid JogadorId
        {
            get { return _jogadorId; }
            set { _jogadorId = value; }
        }

        private string _descricao;
        public string Descricao
        {
            get { return _descricao; }
            set { _descricao = value; }
        }

        private string _tipo;
        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

    }
}
