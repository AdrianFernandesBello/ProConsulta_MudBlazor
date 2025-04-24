using Microsoft.AspNetCore.Identity;
using ProConsulta.Data;

namespace ProConsulta.Models
{
    public class Atendente : ApplicationUser //identifica quem e o usuario por exemplo atendete que faz o agendamentos e nao o medico
    {
        public string Nome { get; set; }
    }
}
