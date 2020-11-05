using Projeto.Business.Dto;
using System.Collections.Generic;

namespace Projeto.Business.Interfaces.Repositorio
{
    public interface IRepositorio
    {
        IList<Aluno> ListarAlunos();
        bool CadastrarAluno(Aluno aluno);
        bool ExcluirAluno(Aluno aluno);
        bool AtualizarAluno(Aluno aluno);
        Aluno ObterAlunoPorId(int idAluno);
    }
}
