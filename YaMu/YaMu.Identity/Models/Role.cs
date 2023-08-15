using YaMu.Helpers.Db;

namespace YaMu.Identity.Models;

public class Role : BaseModel<int>
{
    public string Name { get; set; }
    public string NameNormalized { get; set; }
    public List<UserRole> UserRoles { get; set; }
    public List<RoleClaim> RoleClaims { get; set; }
}
