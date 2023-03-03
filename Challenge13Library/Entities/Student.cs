namespace Challenge13Library.Entities
{
    public class Student
    {
        public int No { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public List<Book> Books { get; set; }
        public List<Return> Returns { get; set; }
        public List<Favorites> Favorites { get; set; }
        public int Point { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsBlocked { get; set; }

    }
}
