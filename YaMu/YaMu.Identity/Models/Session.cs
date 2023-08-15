using DeviceDetector.Models;
using YaMu.Helpers.Db;
using YaMu.Identity.Models.Helpers;

namespace YaMu.Identity.Models;

public class Session : BaseSoftDeletableModel<Guid>
{
    public AppInfo App { get; set; }
    public LocationInfo Location { get; set; }
    public ClientInfo Client { get; set; }
    public bool IsActive { get; set; }
    public string Type { get; set; }
    public bool ViaMFA { get; set; }
    public SessionStatus Status { get; set; }
    public string Language { get; set; }
    public DateTime? DeactivatedAt { get; set; }
    public Guid? DeactivatedBySessionId { get; set; }
    public string RefreshToken { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public List<Token> Tokens { get; set; }
}

public enum SessionStatus
{
    New,
    Active,
    Close
}
