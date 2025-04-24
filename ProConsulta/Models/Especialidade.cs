namespace ProConsulta.Models
{
    public class Especialidade
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string?  Descrição { get; set; }
        public ICollection<Medico> Medicos { get; set; } = [];
    }
}
