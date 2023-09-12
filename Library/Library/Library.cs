using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;
        public Library(params Book[]books)
        {
            this.books = books.ToList();
            
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraItearator(books);
        }

        IEnumerator IEnumerable.GetEnumerator()=>GetEnumerator();
        
    }
    class LibraItearator : IEnumerator<Book>
    {
        private List<Book> books;
        private int currentIndex = -1;
        public LibraItearator(List<Book>books)
        {
            this.books=books;
        }
        public Book Current => books[currentIndex];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
          
        }

        public bool MoveNext()
        {
            return ++currentIndex < books.Count;
        }

        public void Reset()
        {
            currentIndex = -1;
        }
    }
}
