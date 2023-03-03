using Example16;

class Program
{
    /// <summary>
    /// LINQ
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {

        List<Student> Students = new List<Student>()
        {
            new Student() { Id = 1, FirstName = "Cihan", LastName = "Özhan", BirthDate = new DateTime(1988, 7, 17)},
            new Student() { Id = 2, FirstName = "Hakkı", LastName = "Bulut", BirthDate = new DateTime(1987, 3, 10)},
            new Student() { Id = 3, FirstName = "Ali", LastName = "Bulut", BirthDate = new DateTime(1986, 4, 7)},
            new Student() { Id = 4, FirstName = "Veli", LastName = "Yağmur", BirthDate = new DateTime(1985, 1, 22)},
            new Student() { Id = 5, FirstName = "Zeki", LastName = "Su", BirthDate = new DateTime(1984, 6, 11)},
            new Student() { Id = 6, FirstName = "Medine", LastName = "Toprak", BirthDate = new DateTime(1983, 1, 14)},
            new Student() { Id = 7, FirstName = "Ayşe", LastName = "Tahta", BirthDate = new DateTime(1983, 8, 1)},
            new Student() { Id = 8, FirstName = "Fatma", LastName = "Odun", BirthDate = new DateTime(1982, 3, 11)},
            new Student() { Id = 9, FirstName = "Murtaza", LastName = "Ateş", BirthDate = new DateTime(1981, 11, 18)},
            new Student() { Id = 10, FirstName = "Kemal", LastName = "Cemal", BirthDate = new DateTime(1976, 12, 20)},
            new Student() { Id = 11, FirstName = "Gizem", LastName = "Aydın", BirthDate = new DateTime(1999, 02, 17)}
        };

        #region ID'si 4'ten büyük olan öğrencileri bul.
        #region SQL
        // select * from Students where id > 4;
        #endregion
        Console.WriteLine();
        #region C#
        foreach(var item in Students)
        {
            if(item.Id > 4)
            {
                Console.WriteLine(item.FirstName);
            }
        }
        #endregion
        Console.WriteLine();

        #region LINQ
        var query = from student in Students
                where student.Id > 4
                select student;
        foreach (var item in query)
        {
            Console.WriteLine(item.FirstName);
        }
        #endregion
        Console.WriteLine();

        #region Lambda
        var q = Students.Where(x => x.Id > 4);
        foreach (var item in q)
        {
            Console.WriteLine(item.FirstName);
        }
        #endregion
        #endregion

        #region Adı M ile başlayan öğrencileri bul.

        query = Students.Where(x => x.FirstName.StartsWith('M'));

        Console.WriteLine();
        foreach (var item in query)
        {
            Console.WriteLine(item.FirstName);
        }
        #endregion
        #region Soyadı "t" ile biten öğrencileri bul.
        Console.WriteLine("\nSoyadı \"t\" ile biten öğrenciler\n");

        #region Yöntem 1
        Console.WriteLine("Yöntem 1");

        query = from student in Students
                where student.LastName.EndsWith('t')
                select student;
        foreach(var item in query)
        {
            Console.WriteLine(item.LastName);
        }
        Console.WriteLine();

        #endregion
        #region Yöntem 2
        Console.WriteLine("Yöntem 2");

        query = Students.Where(x => x.LastName.EndsWith('t'));
        foreach (var item in query)
        {
            Console.WriteLine(item.LastName);
        }
        Console.WriteLine();

        #endregion

        #region Yöntem 3
        Console.WriteLine("Yöntem 3");

        foreach(var item in Students)
        {
            if (item.LastName[item.LastName.Length-1] == 't')
            {
                Console.WriteLine(item.LastName);
            }
        }
        Console.WriteLine();

        #endregion

        #region Yöntem 4
        Console.WriteLine("Yöntem 4");
        query = Students.Where(x => x.LastName.Substring(x.LastName.Length - 1, 1).ToLower() == "t");

        foreach (var item in query)
        {
            Console.WriteLine(item.LastName);
        }
        Console.WriteLine();

        #endregion
        #endregion

        #region Yaşı 27'den küçük olan öğrencileri bul.
        Console.WriteLine("\nYaşı 27'den küçük olan öğrencileri bul.\n");

        #region Yöntem 1
        Console.WriteLine("Yöntem 1");

        query = from student in Students
                where DateTime.Now.Year - student.BirthDate.Year <27
                select student;
        foreach (var item in query)
        {
            Console.WriteLine(item.FirstName);
        }
        Console.WriteLine();

        #endregion

        #region Yöntem 2
        Console.WriteLine("Yöntem 2");

        query = Students.Where(x => (DateTime.Now - x.BirthDate).TotalDays / 365 < 27);
        
        foreach (var item in query)
        {
            Console.WriteLine(item.FirstName);
        }

        Console.WriteLine();

        #endregion
        #endregion

        #region Pazartesi günü doğan öğrencileri bul.
        Console.WriteLine("\nPazartesi günü doğan öğrencileri bul\n");

        #region Yöntem 1
        Console.WriteLine("Yöntem 1");

        query = from student in Students
                where student.BirthDate.DayOfWeek == DayOfWeek.Monday
                select student;
        
        foreach (var item in query)
        {
            Console.WriteLine(item.FirstName);
        }
        Console.WriteLine();

        #endregion
        #endregion

        #region Öğrenci ad soyad no'ları al.
        Console.WriteLine("\nÖğrenci ad soyad no'ları al\n");
        #region Yöntem 1
        Console.WriteLine("Yöntem 1");

        var query1 = from student in Students
                select new
                {
                    Name = student.FirstName + " " + student.LastName,
                    No = student.Id
                };

        foreach (var item in query1)
        {
            Console.WriteLine(item.Name + " "+ item.No);
        }
        Console.WriteLine();

        #endregion

        #region Yöntem 2
        Console.WriteLine("Yöntem 2");

        var query2 = Students.Select(x =>
            new {
                No = x.Id,
                Name = x.FirstName + " " + x.LastName
            });

  
        foreach (var item in query2)
        {
            Console.WriteLine(item.Name+" "+item.No);
        }
        Console.WriteLine();

        #endregion

        #endregion

        
    }
}