using DeviceDetector.Models;
using YaMu.Helpers.Db;
using YaMu.Identity.Models.Helpers;

namespace YaMu.Identity.Models;

public class LoginAttempt : BaseSoftDeletableModel<int>
{
    public string Login { get; set; }
    public string Password { get; set; }
    public ClientInfo Client { get; set; }
    public LocationInfo Location { get; set; }
    public bool IsSuccess { get; set; }
    public int? UserId { get; set; }
    public User User { get; set; }
}