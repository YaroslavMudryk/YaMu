namespace YaMu.Helpers.Db
{
    public interface IAuditEntity
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
}
