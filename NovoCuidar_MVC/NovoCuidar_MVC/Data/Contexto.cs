using Microsoft.EntityFrameworkCore;
using NovoCuidar_MVC.Models;

namespace NovoCuidar_MVC.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Gestores> Gestores { get; set; }

    }
}
