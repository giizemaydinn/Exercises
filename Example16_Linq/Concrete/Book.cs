﻿namespace Example16.Concrete
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Page { get; set; }
        public Author Author { get; set; }

    }
}