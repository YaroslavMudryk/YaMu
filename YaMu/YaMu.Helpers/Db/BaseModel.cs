using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace YaMu.Helpers.Db
{
    public class BaseModel : IAuditEntity
    {
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedFromIP { get; set; }

        public DateTime? LastUpdatedAt { get; set; }
        public int? LastUpdatedBy { get; set; }
        public string LastUpdatedFromIP { get; set; }
        public string LastContextId { get; set; }

        public int Version { get; set; }
    }

    public class BaseModel<T> : BaseModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T Id { get; set; }
    }
}
