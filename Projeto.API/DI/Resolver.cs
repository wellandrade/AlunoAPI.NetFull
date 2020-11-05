using Microsoft.Extensions.DependencyInjection;
using Projeto.Business.Interfaces.Repositorio;
using Projeto.Business.Interfaces.Servico;
using Projeto.Business.Servico;
using Projeto.Infra.Repositorio;

namespace Projeto.API.DI
{
    public class Resolver
    {
        public static ServiceProvider ResolverInjecaoDependencia()
        {
            var serviceProvider = new ServiceCollection()
                                      .AddTransient<IAlunoServico, AlunoServico>()
                                      .AddTransient<IRepositorio, Repositorio>()
                                      .BuildServiceProvider();

            return serviceProvider;
        }
    }
}