namespace TAL.Task.Domains.Entities
{
    public class Occupation
    {
        public int OccupationId { get; set; }
        public string Name { get; set; }
        public int RatingId { get; set; }
        public virtual Rating Rating { get; }
    }
}
