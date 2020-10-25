using BuilderPatron.Models.DataBase.Maps;
using BuilderPatron.Models.Producto;
using Microsoft.EntityFrameworkCore;

namespace BuilderPatron.Models.DataBase
{
    public class PizzaContext : DbContext
    {
        public PizzaContext(DbContextOptions<PizzaContext> options):base(options)
        {
            
        }

        public DbSet<Pizza> Pizzas { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PizzaMap());
        }

    }
}