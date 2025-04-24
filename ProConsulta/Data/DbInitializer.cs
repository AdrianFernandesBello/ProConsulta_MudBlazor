using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProConsulta.Models;

namespace ProConsulta.Data
{
    public class DbInitializer
    {
        private readonly ModelBuilder _modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }

        // esse metodo cria os dados quando iniciar o banco
        internal void seed()
        {
            //primeiro registro
            _modelBuilder.Entity<IdentityRole>().HasData(

                new IdentityRole()
                {
                    Id = "8305f33b-5412-47d0-b4ab-14cf6867f2e2",
                    Name = "Atendente",
                    NormalizedName = "ATENDENTE"
                },

                new IdentityRole()
                {
                    Id = "0043fdb-e5e1-49eb-8e36-837561d584f1",
                    Name = "Medico",
                    NormalizedName = "MEDICO"
                }
            );
            var hasher = new PasswordHasher<IdentityUser>();

            _modelBuilder.Entity<Atendente>().HasData(

                new Atendente
                {
                    Id = "2658rcb-r9f1-46as-8d66-854561d586c7",
                    Nome = "Pro Consulta",
                    Email = "proconsulta@hotmail.com.br",
                    EmailConfirmed = true,
                    UserName = "proconsulta@hotmail.com.br",
                    NormalizedEmail = "PROCONSULTA@HOTMAIL.COM.BR",
                    NormalizedUserName = "PROCONSULTA@HOTMAIL.COM.BR",
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd")

                }
            );

            _modelBuilder.Entity<IdentityUserRole<string>>().HasData(

                new IdentityUserRole<string>
                {
                    RoleId = "8305f33b-5412-47d0-b4ab-14cf6867f2e2",
                    UserId = "2658rcb-r9f1-46as-8d66-854561d586c7"
                }
            );

            _modelBuilder.Entity<Especialidade>().HasData(

                new Especialidade { Id = 1, Nome = "Cardiologia", Descrição = "Especialidade médica que trata doenças do coração e do sistema circulatório." },
                new Especialidade { Id = 2, Nome = "Dermatologia", Descrição = "Área da medicina que cuida da pele, cabelos, unhas e mucosas." },
                new Especialidade { Id = 3, Nome = "Ortopedia", Descrição = "Ramo da medicina voltado ao sistema músculo-esquelético, como ossos e articulações." },
                new Especialidade { Id = 4, Nome = "Pediatria", Descrição = "Especialidade responsável pela saúde de crianças e adolescentes." },
                new Especialidade { Id = 5, Nome = "Ginecologia", Descrição = "Cuida da saúde do sistema reprodutor feminino e das mamas." },
                new Especialidade { Id = 6, Nome = "Neurologia", Descrição = "Diagnóstico e tratamento de distúrbios do sistema nervoso." },
                new Especialidade { Id = 7, Nome = "Psiquiatria", Descrição = "Foca no diagnóstico, prevenção e tratamento de transtornos mentais." },
                new Especialidade { Id = 8, Nome = "Endocrinologia", Descrição = "Estuda e trata distúrbios hormonais e das glândulas endócrinas." },
                new Especialidade { Id = 9, Nome = "Oftalmologia", Descrição = "Responsável pelo tratamento dos olhos e da visão." },
                new Especialidade { Id = 10, Nome = "Urologia", Descrição = "Cuida do trato urinário masculino e feminino, e do sistema reprodutor masculino." }

            );

        }
    }
}
