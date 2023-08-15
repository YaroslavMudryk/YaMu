namespace YaMu.Helpers.Db
{
    public class BaseSoftDeletableModel<T> : BaseModel<T>, ISoftDeletableEntity
    {
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; }
        public int? DeletedBy { get; set; }
    }
}
