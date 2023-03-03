namespace Challenge06
{
    public class Teacher : Person
    {

        public List<Student> Students { get; set; }
        public Lesson Lesson { get; set; }

        Teacher() : base()
        {
            Students = new List<Student>();
        }

        public Teacher(string email, string password, Lesson lesson) : this()
        {
            Lesson = lesson;
        }

        public List<Student> GetStudents()
        {
            return Students;
        }

        /// <summary>
        /// Belli bir ogrencinin notunu almak icin kullanilir.
        /// Ogrenci o dersten sinava girmemisse nota ulasilamaz.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public (bool, int) GetGradeOfStudent(int id)
        {
            bool b = false;
            int grade = 0;

            foreach (var item in Students)
            {
                if (item.GetId() == id)
                {
                    (b, grade) = item.GetGrade(Lesson);
                }
            }

            return (b, grade);

        }

        /// <summary>
        /// Ogretmene, ogrenci eklemek icin kullanilir. (Admin tarafindan cagrilacak.)
        /// </summary>
        /// <param name="student"></param>
        public void AddStudent(Student student)
        {
            Console.WriteLine(student.GetFullName());
            if (student != null)
            {
                Students.Add(student);
            }
        }

        /// <summary>
        /// Ogrenciye not eklemek icin kullanilir.
        /// </summary>
        /// <param name="student"></param>
        /// <param name="grade"></param>
        public void AddGrade(Student student, int grade)
        {
            foreach (var item in Students)
            {
                if (item.Id == student.Id)
                {
                    student.AddGrade(Lesson, grade);
                }
            }
        }

    }
}
