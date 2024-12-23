using Domain.Entities;
using Domain.Payloads.Usuario;

namespace Service.Interfaces
{
    public interface IUsuarioService
    {
        public Usuario Create(CreateUsuarioPayload payload);
        public Usuario? Get(int id);
        public IEnumerable<Usuario> Get();
        public Usuario Update(UpdateUsuarioPayload payload);
        public Usuario? Remove(int id);
    }
}
