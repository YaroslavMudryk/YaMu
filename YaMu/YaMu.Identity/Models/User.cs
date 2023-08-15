using YaMu.Helpers.Db;

namespace YaMu.Identity.Models
{
    public class User : BaseModel<int>
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Image { get; set; }

        public DateTime Birthday { get; set; }

        public string Login { get; set; }
        public string PasswordHash { get; set; }

        public bool MFA { get; set; }
        public string MFASecretKey { get; set; }

        public int AccessFailedCount { get; set; }
        public bool LockoutEnabled { get; set; }
        public DateTime? LockoutEnd { get; set; }
        public bool IsActivated { get; set; }

        public List<Session> Sessions { get; set; }
        public List<Password> Passwords { get; set; }
        public List<UserRole> UserRoles { get; set; }
        public List<Qr> Qrs { get; set; }
        public List<Confirm> Confirms { get; set; }
        public List<UserLogin> UserLogins { get; set; }
        public List<LoginAttempt> LoginAttempts { get; set; }
        public List<MFA> MFAs { get; set; }
        public List<LoginChange> Logins { get; set; }

        public bool IsLocked()
        {
            var isLocked = false;
            if (LockoutEnd == null)
                isLocked = false;
            if (LockoutEnd.HasValue)
            {
                if (LockoutEnd.Value > DateTime.Now)
                    isLocked = true;
                else
                {
                    LockoutEnd = null;
                    isLocked = false;
                }
            }
            return isLocked;
        }
    }
}
