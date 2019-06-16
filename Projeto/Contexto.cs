using Microsoft.EntityFrameworkCore;
using Projeto.Entidades;

namespace Projeto
{
    // herda DbContext da EntityFramework
    public class Contexto : DbContext
    {
        public Contexto() : base() { }


        public DbSet<Alergia> Alergias { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        // cria banco de dados de nome MedMob no servidor localhost
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost; Initial Catalog=MedMob;Integrated Security=true");
        }
    }
}