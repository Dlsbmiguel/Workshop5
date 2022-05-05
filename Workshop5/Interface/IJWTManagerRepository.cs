using Workshop5.Models;

namespace Workshop5.Repository
{
    public interface IJWTManagerRepository
    {
        Tokens Authenticate(Usuario usuario);
    }
}
