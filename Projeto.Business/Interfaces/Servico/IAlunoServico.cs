using Projeto.Business.Dto;
using System.Collections.Generic;

namespace Projeto.Business.Interfaces.Servico
{
    public interface IAlunoServico
    {
        IList<Aluno> ListarAlunos();
        Retorno CadastrarAluno(Aluno aluno);
        Retorno RemoverAluno(int idAluno);
        Retorno AtualizarAluno(Aluno aluno);
        Aluno ObterAlunoPorId(int idAluno);
    }
}
