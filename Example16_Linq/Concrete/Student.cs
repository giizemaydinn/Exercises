namespace Example16.Concrete
{
    public class Student
    {
        public int No { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Book> Books { get; set; }
        public List<Book> ReturnedBooks { get; set; }
        public List<Favorites> Favorites { get; set; }
    }
}
