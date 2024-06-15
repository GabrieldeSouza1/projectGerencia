
using Microsoft.EntityFrameworkCore;
using tpGerencia.Models;

namespace tpGerencia.context
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        public DbSet<Paciente> Pacientes { get; set; }


    }
}