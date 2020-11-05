using Projeto.API.DI;
using Projeto.Business.Dto;
using Projeto.Business.Interfaces.Servico;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Projeto.API.Controllers
{
    public class AlunoController : ApiController
    {
        private readonly IServiceProvider _serviceProvider;

        private readonly IAlunoServico _alunoServico;

        public AlunoController()
        {
            _serviceProvider = Resolver.ResolverInjecaoDependencia();

            _alunoServico = ObterClasseConcreta.obterServicoAluno(_serviceProvider);
        }

        [HttpPost]
        [Route("v1/cadastrarAluno")]
        public HttpResponseMessage Post([FromBody] Aluno aluno)
        {
            Retorno gravouAluno;

            try
            {
                gravouAluno = _alunoServico.CadastrarAluno(aluno);

                return Request.CreateResponse<Retorno>(HttpStatusCode.OK, gravouAluno);
            }
            catch
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Falha ao cadastrar aluno");
            }
        }

        [HttpGet]
        [Route("v1/listarAlunos")]
        public HttpResponseMessage GetAll()
        {
            try
            {
                return Request.CreateResponse<IList<Aluno>>(HttpStatusCode.OK, _alunoServico.ListarAlunos());
            }
            catch
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Falha ao listar alunos");
            }
        }

        [HttpGet]
        [Route("v1/obterAlunoPorId")]
        public HttpResponseMessage GetById(int idAluno)
        {
            try
            {
                return Request.CreateResponse<Aluno>(HttpStatusCode.OK, _alunoServico.ObterAlunoPorId(idAluno));
            }
            catch
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Falha ao obter aluno por id");
            }
        }

        [HttpDelete]
        [Route("v1/excluirAluno")]
        public HttpResponseMessage Delete(int idAluno)
        {
            try
            {
                Retorno removeuAluno = _alunoServico.RemoverAluno(idAluno);

                return Request.CreateResponse<Retorno>(HttpStatusCode.OK, removeuAluno);
            }
            catch
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Falha ao remover o aluno");
            }
        }

        [HttpPut]
        [Route("v1/alterarAluno")]
        public HttpResponseMessage AtualizarAluno([FromBody] Aluno aluno)
        {
            try
            {
                Retorno atualizouAluno = _alunoServico.AtualizarAluno(aluno);

                return Request.CreateResponse<Retorno>(HttpStatusCode.OK, atualizouAluno);
            }
            catch
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Falha ao alterar dados do aluno");
            }
        }
    }
}
