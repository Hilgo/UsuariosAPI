using Microsoft.AspNetCore.Authorization;

namespace UsuariosApi.Authorization
{
    public class IdadeMinia : IAuthorizationRequirement
    {
        public IdadeMinia(int idade)
        {
            Idade = idade;
        }
        public int Idade { get; set; }
    }
}
