using Microsoft.EntityFrameworkCore;

namespace YaMu.Helpers.Db.Extensions
{
    public static class DbContextExtensions
    {
        public static void ApplyAuditInfo(this DbContext dbContext, IIdentityService identityService, IDateTimeProvider dateTimeProvider)
        {
            var now = dateTimeProvider.UtcNow;

            ApplyUpsertInfo(dbContext, now, identityService);
            ApplyDeleteInfo(dbContext, now, identityService);
            ApplyContextId(dbContext);
        }

        private static void ApplyUpsertInfo(DbContext dbContext, DateTime now, IIdentityService identityService)
        {
            var entries = dbContext.ChangeTracker.Entries().Where(s => s.Entity is IAuditEntity && (s.State == EntityState.Added || s.State == EntityState.Modified));

            entries.ToList().ForEach(entry =>
            {
                var entity = (IAuditEntity)entry.Entity;

                if (entry.State == EntityState.Added)
                {
                    entity.CreatedAt = now;
                    entity.CreatedBy = identityService != null ? identityService.GetUserId() : DefaultsAudit.CreatedBy;
                    entity.CreatedFromIP = identityService != null ? identityService.GetUserIp() : DefaultsAudit.CreatedFromIP;
                }

                if(entry.State == EntityState.Modified)
                {
                    entity.LastUpdatedAt = now;
                    entity.LastUpdatedBy = identityService != null ? identityService.GetUserId() : DefaultsAudit.CreatedBy;
                    entity.LastUpdatedFromIP = identityService != null ? identityService.GetUserIp() : DefaultsAudit.CreatedFromIP;
                }

                entity.Version++;
            });
        }

        private static void ApplyDeleteInfo(DbContext dbContext, DateTime now, IIdentityService identityService)
        {
            var entries = dbContext.ChangeTracker.Entries().Where(s => s.Entity is ISoftDeletableEntity && (s.State == EntityState.Deleted));

            entries.ToList().ForEach(entry =>
            {
                var entity = (ISoftDeletableEntity)entry.Entity;

                entity.DeletedAt = now;
                entity.IsDeleted = true;
                entity.DeletedBy = identityService != null ? identityService.GetUserId() : DefaultsAudit.CreatedBy;
                entry.State = EntityState.Modified;
            });
        }

        private static void ApplyContextId(DbContext dbContext)
        {
            var allEntries = dbContext.ChangeTracker.Entries().Where(s => s.Entity is IAuditEntity);

            allEntries.ToList().ForEach(entry =>
            {
                var entity = (IAuditEntity)entry.Entity;

                entity.LastContextId = dbContext.ContextId.ToString();
            });
        }
    }
}
