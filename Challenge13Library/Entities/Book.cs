namespace Challenge13Library.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Page { get; set; }
        public Author Author { get; set; }
        public Category Category { get; set; }
        public bool AgeLimit { get; set; }
        public bool IsTake { get; set; } = false;
    }
}