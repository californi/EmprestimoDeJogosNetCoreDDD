using Api.Domain.Interfaces.Services.EmprestimoJogo;
using Api.Domain.Interfaces.Services.Jogador;
using Api.Domain.Interfaces.Services.Jogo;
using Api.Domain.Interfaces.Services.Usuario;
using Api.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUsuarioService, UsuarioService>();
            serviceCollection.AddTransient<ILoginService, LoginService>();

            serviceCollection.AddTransient<IJogadorService, JogadorService>();
            serviceCollection.AddTransient<IJogoService, JogoService>();
            serviceCollection.AddTransient<IEmprestimoJogoService, EmprestimoJogoService>();

        }
    }
}
