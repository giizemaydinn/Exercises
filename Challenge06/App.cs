namespace Challenge06
{
    /// <summary>
    /// </summary>
    public static class App
    {
        private static List<Teacher> _teacherList = new List<Teacher>();
        private static List<Student> _studentList = new List<Student>();
        private static string _path = "";
        public static void Start(string path)
        {
            _path = path;
            ChoiceUser();

        }

        public static void ChoiceUser()
        {
            User user = default;
            bool ex = false;

            Console.WriteLine("\nKullanici Kimligi Seciniz: ");

            foreach (User u in Enum.GetValues(typeof(User)))
            {
                Console.WriteLine((int)u + " - " + u);
            }

            try
            {
                user = (User)Enum.Parse(typeof(User), Console.ReadLine());
            }
            catch (Exception)
            {
                ex = true;
                Console.WriteLine("\nGecersiz kullanici kimligi. Varsayilan deger ataniyor. Artik adminsiniz :D");
            }


            switch ((int)user)
            {
                case 0:
                    {
                        Console.WriteLine("1 calisti");
                        break;

                    }
                case 1:
                    {
                        LoginTeacher();
                        break;

                    }
                case 2:
                    {
                        Console.WriteLine("calisti");
                        break;

                    }
                default:
                    {
                        Console.WriteLine("d calisti");
                        break;

                    }
            }

        }

        public static void LoginAdmin()
        {
            string email, password;
            Lesson lesson = default;
            bool ex = false;

            Console.WriteLine("\nEmail: ");
            email = Console.ReadLine();

            Console.WriteLine("Sifre: ");
            password = Console.ReadLine();

            Console.WriteLine("\nBrans Seciniz: ");

            foreach (Lesson l in Enum.GetValues(typeof(Lesson)))
            {
                Console.WriteLine((int)l + " - " + l);
            }

            try
            {
                lesson = (Lesson)Enum.Parse(typeof(Lesson), Console.ReadLine());
            }
            catch (Exception)
            {
                ex = true;
                Console.WriteLine("\nGecersiz brans girdiniz. Varsayılan değer kullanılıyor.");
            }


            Teacher t1 = new Teacher(email, password, lesson);

            _teacherList.Add(t1);

            Student s1 = new Student(email, password, "ad1", "soyad1", "tc1");
            Student s2 = new Student(email, password, "ad2", "soyad2", "tc2");
            s1.AddLesson(lesson); s2.AddLesson(lesson);
            s2.AddGrade(lesson, 60); s2.AddGrade(lesson, 60);

            t1.AddStudent(s1);
            t1.AddStudent(s2);

            t1.CreateXML(t1.GetStudents());
            t1.ReadXML();
        }
        public static void LoginTeacher()
        {
            string email, password;
            Lesson lesson = default;
            bool ex = false;

            Console.WriteLine("\nEmail: ");
            email = Console.ReadLine();

            Console.WriteLine("Sifre: ");
            password = Console.ReadLine();

            Console.WriteLine("\nBrans Seciniz: ");

            foreach (Lesson l in Enum.GetValues(typeof(Lesson)))
            {
                Console.WriteLine((int)l + " - " + l);
            }

            try
            {
                lesson = (Lesson)Enum.Parse(typeof(Lesson), Console.ReadLine());
            }
            catch (Exception)
            {
                ex = true;
                Console.WriteLine("\nGecersiz brans girdiniz. Varsayılan değer kullanılıyor.");
            }


            Teacher t1 = new Teacher(email, password, lesson);

            _teacherList.Add(t1);

            Student s1 = new Student(email, password, "ad1", "soyad1", "tc1");
            Student s2 = new Student(email, password, "ad2", "soyad2", "tc2");
            s1.AddLesson(lesson); s2.AddLesson(lesson);
            s2.AddGrade(lesson, 60); s2.AddGrade(lesson, 60);

            t1.AddStudent(s1);
            t1.AddStudent(s2);

            bool start = true;
            while (start)
            {
                Console.WriteLine("Islem Seciniz: \n1- XML olustur.\n2- XML oku. \n3-Cikis Yap.");
                int islem = Convert.ToInt32(Console.ReadLine());
                switch (islem)
                {
                    case 1:
                        {
                            t1.CreateXML(t1.GetStudents());
                            break;

                        }
                    case 2:
                        {
                            t1.ReadXML();
                            break;

                        }
                    default:
                        {
                            start = false;
                            Console.WriteLine("Cikis yapiliyor.");
                            break;

                        }
                }
            }

        }

    }
}
