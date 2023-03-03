namespace Challenge06
{
    [Serializable]
    public class Student : Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Tc { get; set; }
        public List<Lesson> Lessons { get; set; }
        public List<ExamGrade> _examGrades { get; set; }

        /// <summary>
        /// Id bilgisini otomatik alir.
        /// </summary>
        Student() : base()
        {
            _examGrades = new List<ExamGrade>();
            Lessons = new List<Lesson>();
        }

        /// <summary>
        /// Ogrenci olusturuldugunda cagirilan ctor.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastName"></param>
        /// <param name="tc"></param>
        public Student(string email, string password, string name, string lastName, string tc) : this()
        {
            Name = name;
            LastName = lastName;
            Tc = tc;
        }

        /// <summary>
        /// Ogrencinin aldigi dersleri goruntuler.
        /// </summary>
        public List<Lesson> GetLessons()
        {
            return Lessons;
        }

        /// <summary>
        /// Ogrencinin sinav notlarini goruntuler.
        /// </summary>
        public void GetExamGrades()
        {
            Console.WriteLine("\nDersler ve Aldığınız Notlar: ");
            foreach (var item in _examGrades)
            {
                Console.WriteLine("Ders: " + item.Lesson + " Notu: " + item.Grade);
            }
        }

        /// <summary>
        /// Ogrencinin belli bir derse ait notunu doner.
        /// </summary>
        /// <param name="lesson"></param>
        /// <returns></returns>
        public (bool, int) GetGrade(Lesson lesson)
        {
            foreach (var item in _examGrades)
            {
                if (item.Lesson == lesson)
                {
                    return (true, item.Grade);
                }
            }

            return (false, 0);
        }

        /// <summary>
        /// Ogrenci ad+soyad bilgisi dondurur.
        /// </summary>
        /// <returns></returns>
        public (string, string) GetFullName()
        {
            return (Name, LastName);
        }

        public int GetId()
        {
            return Id;
        }

        /// <summary>
        /// Ogrenciye ders atamak icin kullanilacak. (Admin tarafindan kullanilacak.)
        /// </summary>
        /// <param name="lesson"></param>
        public void AddLesson(Lesson lesson)
        {
            Lessons.Add(lesson);
        }

        /// <summary>
        /// Derslere ait notlari eklemek icin cagrilir. (Ogretmen tarafindan kullanilacak.)
        /// </summary>
        /// <param name="lesson"></param>
        /// <param name="grade"></param>
        public void AddGrade(Lesson lesson, int grade)
        {
            foreach (var item in Lessons)
            {
                if (item == lesson)
                {
                    ExamGrade eg = new ExamGrade(lesson, grade);
                    _examGrades.Add(eg);
                }
            }
        }
    }
}