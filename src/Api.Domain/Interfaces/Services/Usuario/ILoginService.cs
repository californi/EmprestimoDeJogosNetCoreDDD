using System.Threading.Tasks;
using Api.Domain.Dtos;

namespace Api.Domain.Interfaces.Services.Usuario
{
    public interface ILoginService
    {
        Task<object> BuscarPorLogin(LoginDto usuario);
    }
}
