using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YaMu.Identity.Models;
namespace YaMu.Identity.Db.Configurations
{
    internal class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder)
        {
            builder.HasKey(x => x.Id);

            builder.OwnsOne(s => s.App, builder =>
            {
                builder.ToJson();
            });

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