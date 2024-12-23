using Database.Interfaces;
using Domain.Entities;
using Domain.Payloads.Usuario;
using Service.Interfaces;

namespace Service
{
    public class UsuarioService(
        ICRUDRepository<Usuario> _usuarioCrudRepo
        ) : IUsuarioService
    {
        public Usuario Create(CreateUsuarioPayload payload) 
            => _usuarioCrudRepo.Create(new Usuario(payload));

        public Usuario? Get(int id) 
            => _usuarioCrudRepo.Get(id);

        public IEnumerable<Usuario> Get()
            => _usuarioCrudRepo.Get();

        public Usuario Update(UpdateUsuarioPayload payload) 
            => _usuarioCrudRepo.Update(new Usuario(payload));

        public Usuario? Remove(int id) 
            => _usuarioCrudRepo.Remove(id);
    }
}
