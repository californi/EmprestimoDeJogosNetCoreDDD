using System;

namespace Api.Domain.Models
{
    public class EmprestimoJogoModel : BaseModel
    {
        private Guid _jogoId;
        public Guid JogoId
        {
            get { return _jogoId; }
            set { _jogoId = value; }
        }

        private Guid _jogadorId;
        public Guid JogadorId
        {
            get { return _jogadorId; }
            set { _jogadorId = value; }
        }

        private bool _devolvido;
        public bool Devolvido
        {
            get { return _devolvido; }
            set { _devolvido = value; }
        }


    }
}
