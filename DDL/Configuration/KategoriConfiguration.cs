using DDL.EntitiesTablolar;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDL.Configuration
{
    internal class KategoriConfiguration : IEntityTypeConfiguration<Kategoriler>
    {
        public void Configure(EntityTypeBuilder<Kategoriler> builder)
        {
            builder.HasKey(x => x.Id); //PK
            builder.Property(x => x.Id).UseIdentityColumn(); // SQL DE Increment, Seed ayarlarını 1,1 yapar.
            builder.Property(x => x.Adi).IsRequired().HasMaxLength(250);
        }
    }

}
