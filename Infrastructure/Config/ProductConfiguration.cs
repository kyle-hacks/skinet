// Infrastructure/Config/ProductConfiguration.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Config;

public class ProductConfiguration : IEntityTypeConfiguration<Core.Entities.Product>
{
    public void Configure(EntityTypeBuilder<Core.Entities.Product> builder)
    {
        // If this line fails, then the Product the compiler sees here is NOT Core.Entities.Product
        builder.Property(p => p.Price).HasPrecision(18, 2);
    }
}
