using YaMu.Helpers.Db;

namespace YaMu.Identity.Models;

public class Claim : BaseModel<int>
{
    public string Type { get; set; }
    public string Value { get; set; }
    public string DisplayText { get; set; }
    public List<RoleClaim> RoleClaims { get; set; }
    public List<AppClaim> AppClaims { get; set; }
}