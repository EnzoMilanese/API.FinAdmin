namespace Domain.Entities
{
    public class Entity
    {
        public int Id { get; set; }
        public DateTime Criacao { get; set; } = DateTime.Now;
        public DateTime UltimaEdicao { get; set; } = DateTime.Now;
        public bool Status { get; set; } = true;
    }
}
