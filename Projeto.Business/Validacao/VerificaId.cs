using Projeto.Business.Dto;

namespace Projeto.Business.Validacao
{
    public class VerificaId
    {
        public static Retorno idAlunoValido(int idAluno)
        {
            Retorno retorno = new Retorno();

            if (idAluno <= 0)
            {
                retorno.sucesso = false;
                retorno.mensagens.Add("Id do aluno invalido");
                return retorno;
            }
            retorno.sucesso = true;
            return retorno;
        }
    }
}
