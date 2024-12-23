using Database.Interfaces;
using Domain.Entities;

namespace Database.Repositories
{
    public class UsuarioRepository(Context dbContext) : BaseRepository<Usuario>(dbContext), ICRUDRepository<Usuario>
    {
    }
}
