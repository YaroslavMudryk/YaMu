using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YaMu.Helpers.Extensions;
using YaMu.Identity.Models;
namespace YaMu.Identity.Db.Configurations
{
    internal class MFAConfiguration : IEntityTypeConfiguration<MFA>
    {
        public void Configure(EntityTypeBuilder<MFA> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.RestoreCodes).HasConversion(
                s => s.ToJson(),
                s => s.FromJson<string[]>());
        }
    }
}