using System.Xml;
using System.Xml.Serialization;

namespace Challenge06
{
    public class Person
    {
        private static string _path = @"--path";
        private static int _total { get; set; } = 0;
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Person()
        {
            Id = _total;
            _total++;
        }

        public Person(string email, string password) : this()
        {
            Email = email;
            Password = password;
        }

        public void CreateXML<T>(List<T> list)
        {
            Console.WriteLine("\nXML oluşturuluyor.");

            var xmlSerializer = new XmlSerializer(typeof(List<T>));

            using (var writer = new StreamWriter(_path))
            {
                xmlSerializer.Serialize(writer, list);
                var xmlContent = writer.ToString();
            }
        }

        public void ReadXML()
        {
            Console.WriteLine("\nXML okunuyor.\n");

            XmlTextReader reader = new XmlTextReader(_path);
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element: // The node is an element.
                        Console.Write("<" + reader.Name);
                        Console.WriteLine(">");
                        break;

                    case XmlNodeType.Text: //Display the text in each element.
                        Console.WriteLine("   " + reader.Value);
                        break;

                    case XmlNodeType.EndElement: //Display the end of the element.
                        Console.Write("</" + reader.Name);
                        Console.WriteLine(">");
                        break;
                }
            }
            Console.ReadLine();


        }
    }
}
