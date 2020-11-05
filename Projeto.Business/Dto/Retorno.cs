using System.Collections.Generic;

namespace Projeto.Business.Dto
{
    public class Retorno
    {
        public Retorno()
        {
            mensagens = new List<string>();
        }

        public bool sucesso { get; set; }

        public IList<string> mensagens { get; set; }
    }
}
