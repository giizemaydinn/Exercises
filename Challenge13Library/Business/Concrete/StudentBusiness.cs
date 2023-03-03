using Challenge13Library.Business.Abstract;
using Challenge13Library.Entities;

namespace Challenge13Library.Business.Concrete
{
    public class StudentBusiness : IStudent
    {
        Random r = new Random();
        public void TakeBook(int bookId, int studentId)
        {
            if (!CheckLimit(studentId) || !CheckIsTake(bookId) || !CheckDayLimit(studentId, bookId))
            {
                return;
            }

            Return returnBook = new Return()
            {
                Id = DummyData.GetId(),
                BookId = bookId,
                StudentId = studentId,
                StartDate = new DateTime(2023, 1, 1).AddDays(r.Next((DateTime.Today - new DateTime(2023, 1, 1)).Days))
            };
            // Yeni iadeyi oluşturma.
            DummyData.Returns.Add(returnBook);

            // Teslim tarihine, şimdiki tarihle başlangıç tarihi arasında değer atama.
            //DummyData.Returns.Last().FinishDate = DummyData.Returns.Last().StartDate.AddDays(r.Next((DateTime.Today - DummyData.Returns.Last().StartDate).Days));

            // Kitapları alındı olarak işaretleme.
            DummyData.Books.Where(x => x.Id == bookId).ToList().ForEach(x => x.IsTake = true);

            //Kitabı öğrenciye ekle.
            DummyData.Students.Where(x => x.No == studentId).First().Returns.Add(returnBook);
            Console.WriteLine("Kitap eklendi.");
        }

        /// <summary>
        /// Eğer teslim tarihi gecikmişse gün sayısı kadar eksi puan,
        /// Eğer teslim tarihinden önce getirilmişsse teslime kadar olan gün sayısı kadar artı puan.
        /// Eğer eksi puana düşerse 2 hafta kitap alamaz.
        /// </summary>
        /// <param name="studentId"></param>
        /// <param name="returnId"></param>
        public void CalcPoint(int studentId, int returnId)
        {
            var r = DummyData.Students.Where(x => x.No == studentId).First().Returns.Where(x => x.Id == returnId).Select(x => new { x.StartDate, x.FinishDate }).FirstOrDefault();
            int days = (r.FinishDate - r.StartDate).Days;
            int point = 0;

            // kitabın elinde kaldığı süre kadar eksi puan.
            if (days > 7)
            {
                point -= days;
            }
            else
            {
                // kitabın teslimine kalan süre kadar artı puan.
                point += 7 - days;
            }
        }
        /// <summary>
        /// Kitap iadesi yapan metot.
        /// </summary>
        /// <param name="bookId"></param>
        /// <param name="studentId"></param>
        public void ReturnBook(int bookId, int studentId)
        {
            // Kitap öğrencide görünüyorsa teslim tarihi eklenir.
            var returnId = DummyData.Students.Where(x => x.No == studentId).FirstOrDefault()
                .Returns.Where(x => x.BookId == bookId && x.FinishDate == default)
                .Select(x => { x.FinishDate = DateTime.Now; return x.Id; }).FirstOrDefault();

            // Kitap alınabilir duruma getirilir.
            bool v = DummyData.Books.Where(x => x.Id == bookId && x.IsTake).Select(x => { x.IsTake = false; return x.IsTake; }).FirstOrDefault();

            //CalcPoint(studentId, returnId);
        }

        public List<Return> GetReturns(int studentId)
        {                                                                              //
            List<Return> r = DummyData.Students.Where(x => x.No == studentId).First().Returns.Where(x => x.FinishDate == default).ToList();
            return r;
        }
        /// <summary>
        /// Öğrencinin alıp da teslim etmediği(teslim tarihi olmayan) kitap sayısı 3'ten fazlaysa kitap alamaz.
        /// </summary>
        /// <returns></returns>
        private bool CheckLimit(int studentId)
        {

            int count = (from student in DummyData.Students
                         from book in student.Returns
                         where student.No == studentId && book.FinishDate == default
                         select book).Count();

            if (count > 3)
            {
                Console.WriteLine("Elinizdeki kitap sayısı 3'ten fazla olduğundan kitap alamazsınız.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Kitap mevcut değilse veya başkası tarafından alındıysa false döner.
        /// </summary>
        /// <param name="bookId"></param>
        /// <returns></returns>
        private bool CheckIsTake(int bookId)
        {
            int count = (from book in DummyData.Books
                         where book.Id == bookId && !book.IsTake
                         select book).Count();

            if (count != 1)
            {
                Console.WriteLine("Kitap mevcut değil.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Aynı kitap daha önce 2 kere alındıysa 14 gün sonra tekrar alınabilir.
        /// </summary>
        /// <param name="studentId"></param>
        /// <param name="bookId"></param>
        /// <returns></returns>
        private bool CheckDayLimit(int studentId, int bookId)
        {
            int count = (from b in (from student in DummyData.Students
                                    from book in student.Returns
                                    where book.Id == bookId
                                    select book).TakeLast(2).ToList()
                         where (DateTime.Now - b.FinishDate).Days < 14
                         select b).Count();

            if (count != 0)
            {
                Console.WriteLine("Aynı kitap 3. defa almak için 14 gün geçmesi gereklidir.");
                return false;
            }
            return true;
        }

        public void Add(Student student)
        {
            DummyData.Students.Add(new Student()
            {
                No = DummyData.GetId(),
                FirstName = student.FirstName,
                LastName = student.LastName,
                BirthDate = student.BirthDate
            });
        }

        public List<Student> GetStudents()
        {
            return DummyData.Students;
        }

        public List<Book> GetBooks()
        {
            return DummyData.Books.Where(x => !x.IsTake).ToList();
        }

        public Book GetBook(int id)
        {
            return DummyData.Books.Where(x => x.Id == id).First();
        }
    }
}
