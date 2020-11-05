using Projeto.Business.Enum;
using System;

namespace Projeto.Business.Dto
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public EEscolaridade Escolaridade { get; set; }

    }
}
