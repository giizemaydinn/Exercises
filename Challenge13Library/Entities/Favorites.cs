namespace Challenge13Library.Entities
{
    public class Favorites
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public List<int> BookIds { get; set; }
        public List<int> AuthorIds { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}