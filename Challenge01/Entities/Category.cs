namespace Challenge01.Entities
{
    class Category
    {
        public static int id = 0;
        public int ID { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Ekleme fonksiyonu cagrilarak nesne olusturulur.
        /// </summary>
        /// <param name="name"></param>
        public Category(string name)
        {
            Add(name);
        }

        /// <summary>
        /// Id otomatik arttirilarak kategori eklenir. 
        /// </summary>
        /// <param name="name"></param>
        /// <exception cref="Exception"></exception>
        public void Add(string name)
        {
            ID = id++;

            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Boş değer gönderilemez.");
            if (Name == name)
                throw new Exception("Kategori mevcut");

            Name = name;
        }
    }
}
