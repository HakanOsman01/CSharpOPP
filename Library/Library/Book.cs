﻿namespace Library
{
    public class Book
    {
        
        public Book(string title,int year, params string[]authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors=authors.ToList();
            
        }
        public string  Title { get; private set; }
        public int Year { get;private set; }
        List<string> Authors { get; set; }
    }
}