using Domain.Payloads.Usuario;

namespace Domain.Entities
{
    public class Usuario : Entity
    {
        public string Nome { get; set; }
        public virtual List<Conta> Contas { get; set; }
        public Usuario()
        {
            
        }

        public Usuario(CreateUsuarioPayload payload)
        {
            Nome = payload.Nome;
        }

        public Usuario(UpdateUsuarioPayload payload)
        {
            Id = payload.Id;
            Nome = payload.Nome;
        }
    }
}
