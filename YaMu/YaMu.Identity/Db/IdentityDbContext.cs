using Microsoft.EntityFrameworkCore;
using YaMu.Helpers;
using YaMu.Helpers.Db.Extensions;
using YaMu.Identity.Db.Configurations;
using YaMu.Identity.Models;

namespace YaMu.Identity.Db
{
    public class IdentityDbContext : DbContext
    {
        private readonly IIdentityService _identityService;
        private readonly IDateTimeProvider _dateTimeProvider;

        public IdentityDbContext(DbContextOptions<IdentityDbContext> options, IIdentityService identityService, IDateTimeProvider dateTimeProvider) : base(options)
        {
            _identityService = identityService;
            _dateTimeProvider = dateTimeProvider;
        }

        public DbSet<App> Apps { get; set; }
        public DbSet<AppClaim> AppClaims { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Confirm> Confirms { get; set; }
        public DbSet<LoginAttempt> LoginAttempts { get; set; }
        public DbSet<LoginChange> LoginChanges { get; set; }
        public DbSet<MFA> MFAs { get; set; }
        public DbSet<Password> Passwords { get; set; }
        public DbSet<Qr> Qrs { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RoleClaim> RoleClaims { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserLogin> UsersLogin { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        public override int SaveChanges()
        {
            this.ApplyAuditInfo(_identityService, _dateTimeProvider);

            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            this.ApplyAuditInfo(_identityService, _dateTimeProvider);

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LoginAttemptConfiguration());
            modelBuilder.ApplyConfiguration(new MFAConfiguration());
            modelBuilder.ApplyConfiguration(new RoleClaimConfiguration());
            modelBuilder.ApplyConfiguration(new SessionConfiguration());
        }
    }
}