namespace Challenge13Library.Entities
{
    public class Return
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int StudentId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
    }
}