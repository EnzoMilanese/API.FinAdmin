namespace Domain.Entities
{
    public class Conta : Entity
    {
        public string Descricao { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
