using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YaMu.Identity.Models;
namespace YaMu.Identity.Db.Configurations
{
    internal class RoleClaimConfiguration : IEntityTypeConfiguration<RoleClaim>
    {
        public void Configure(EntityTypeBuilder<RoleClaim> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(s => new
            {
                s.ClaimId,
                s.RoleId
            });
        }
    }
}