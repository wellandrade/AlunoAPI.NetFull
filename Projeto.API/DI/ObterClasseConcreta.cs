using Microsoft.Extensions.DependencyInjection;
using Projeto.Business.Interfaces.Servico;
using System;

namespace Projeto.API.DI
{
    public static class ObterClasseConcreta
    {
        public static IAlunoServico obterServicoAluno(IServiceProvider serviceProvider)
        {
            return serviceProvider.GetRequiredService<IAlunoServico>();
        }
    }
}