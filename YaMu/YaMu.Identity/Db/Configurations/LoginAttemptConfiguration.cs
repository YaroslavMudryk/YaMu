using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YaMu.Identity.Models;

namespace YaMu.Identity.Db.Configurations
{
    internal class LoginAttemptConfiguration : IEntityTypeConfiguration<LoginAttempt>
    {
        public void Configure(EntityTypeBuilder<LoginAttempt> builder)
        {
            builder.HasKey(x => x.Id);


            builder.OwnsOne(s => s.Location, builder =>
            {
                builder.ToJson();
            });

            builder.OwnsOne(s => s.Client, builder =>
            {
                builder.ToJson();
            });
        }
    }
}
