using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ServiceSearchActions.Core.Entites.Shares;
using ServiceSearchActions.Infrastructure.ClassGeneric;

namespace ServiceSearchActions.Infrastructure.Persistence.Configurations
{
    public class CompanyProfileConfigurations : TB_, IEntityTypeConfiguration<CompanyProfile>
    {
        public void Configure(EntityTypeBuilder<CompanyProfile> builder)
        {
            builder.ToTable(string.Concat(_TB, nameof(CompanyProfile)).ToUpper())
                   .HasKey(x => x.Id);
        }
    }
}
