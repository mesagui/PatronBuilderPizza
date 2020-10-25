using BuilderPatron.Models.Producto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BuilderPatron.Models.DataBase.Maps
{
    public class PizzaMap : IEntityTypeConfiguration<Pizza>
    {
        public void Configure(EntityTypeBuilder<Pizza> builder)
        {
            builder.ToTable("Pizza");
            builder.HasKey(o => o.idPizza);
        }
    }
}