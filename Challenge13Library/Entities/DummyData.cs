using Challenge13Library.Business.Concrete;

namespace Challenge13Library.Entities
{
    public static class DummyData
    {
        public static List<Author> Authors;
        public static List<Category> Categories;
        public static List<Book> Books;

        public static List<Student> Students;
        public static List<Favorites> FavoritesList;
        public static List<Return> Returns;

        static Random r = new Random();

        static StudentBusiness sb;
        public static int Id = 0;
        static DummyData()
        {
            Books = new List<Book>();
            Students = new List<Student>();
            Authors = new List<Author>();
            Categories = new List<Category>();
            FavoritesList = new List<Favorites>();
            Returns = new List<Return>();

            sb = new StudentBusiness();

            //FillLists();

        }

        public static int GetId()
        {
            return Id++;
        }
        public static void FillLists()
        {
            FillCategories();
            FillAuthors();
            FillBooks();

            FillStudents();
            FillFavoritesList();
            FillReturns();
        }

        private static void FillReturns()
        {
            for (int i = 0; i < 50; i++)
            {
                int bookId = r.Next(0, Books.Count);
                int studentId = r.Next(0, Students.Count);
                sb.TakeBook(bookId, studentId);

            }

            //for (int i = 0; i < 2; i++)
            //{
            //    Returns.Add(new Return()
            //    {
            //        Id = i,
            //        BookId = r.Next(0, Books.Count),
            //        StudentId = r.Next(0, Students.Count),
            //        StartDate = new DateTime(2023, 1, 1).AddDays(r.Next((DateTime.Today - new DateTime(2023, 1, 1)).Days))
            //    });

            //}

            // Teslim edilmemiş kitapları bulma.
            //var bookIDs = Returns.Where(x => x.FinishDate == default(DateTime)).Select(x => x.BookId);

            //// Teslim edilmemiş(kütüphanede mevcut olmayan) kitapları işaretleme.
            //(from book in Books
            // join id in bookIDs
            // on book.Id equals id
            // select book).ToList().ForEach(x => x.IsTake = true);


            ////(from book in Books
            //// from r in Returns
            //// where (book.Id == r.BookId && r.FinishDate == default(DateTime))
            //// select book)
            ////.ToList().ForEach(x => x.IsTake = true);

            //Console.WriteLine("Teslim edilmemiş kitap sayısı: " + Books.Where(x => x.IsTake == true).Count());

        }
        private static void FillFavoritesList()
        {
            for (int i = 0; i < Students.Count; i++)
            {
                List<int> bookIds = new List<int>();
                List<int> categoryIds = new List<int>();
                List<int> authorIds = new List<int>();

                for (int j = 0; j < 5; j++)
                {
                    bookIds.Add(r.Next(0, Books.Count));
                    categoryIds.Add(r.Next(0, Books.Count));
                    authorIds.Add(r.Next(0, Books.Count));
                }

                FavoritesList.Add(new Favorites()
                {
                    StudentId = r.Next(0, Students.Count),
                    BookIds = bookIds,
                    CategoryIds = categoryIds,
                    AuthorIds = authorIds
                });
            }

        }
        private static void FillStudents()
        {

            for (int i = 0; i < 20; i++)
            {
                Students.Add(new Student()
                {
                    No = GetId(),
                    FirstName = "Öğrenci Adı " + i,
                    LastName = "Öğrenci Soyadı " + i,
                    BirthDate = new DateTime(1900, 1, 1).AddDays(r.Next((DateTime.Today - new DateTime(1900, 1, 1)).Days)),
                    Point = 0,
                    Favorites = FavoritesList.Where(x => x.StudentId == i).ToList(),
                    Returns = Returns.Where(x => x.StudentId == i).ToList()
                });
            }


        }

        private static void FillAuthors()
        {
            for (int i = 0; i < 10; i++)
            {
                Authors.Add(new Author()
                {
                    Id = i,
                    Name = "Yazar" + i,
                    LastName = "Yazar Soyad" + i
                });
            }
        }

        private static void FillCategories()
        {
            for (int i = 0; i < 5; i++)
            {
                Categories.Add(new Category()
                {
                    Id = i,
                    Name = "Kategori" + i
                });
            }
        }
        private static void FillBooks()
        {
            for (int i = 0; i < 20; i++)
            {
                Books.Add(new Book()
                {
                    Id = i,
                    AgeLimit = i % 2 == 0,
                    Name = "Kitap" + i,
                    Author = Authors.ElementAt(r.Next(0, Authors.Count)),
                    Category = Categories.ElementAt(r.Next(0, Categories.Count)),
                    Description = "Description" + i,
                    Page = 50 + i * 2,
                });
            }
        }
    }
}
