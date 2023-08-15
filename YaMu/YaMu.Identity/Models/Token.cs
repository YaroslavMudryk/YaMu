using System.ComponentModel.DataAnnotations;
using YaMu.Helpers.Db;

namespace YaMu.Identity.Models;

public class Token : BaseModel<long>
{
    public string JwtToken { get; set; }
    public DateTime ExpiredAt { get; set; }
    public Guid SessionId { get; set; }
    public Session Session { get; set; }
}