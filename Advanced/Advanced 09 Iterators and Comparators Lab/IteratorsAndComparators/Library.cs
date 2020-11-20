using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        
        public Library(params Book[] books)
        {
            this.Books = new List<Book>(books);
            this.Books.Sort(new BookComparator());
        }
        public List<Book> Books { get; set; }

        public IEnumerator<Book> GetEnumerator()
        {
            return new Library.LibraryIterator(this.Books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        private class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int currentIndex;
            public LibraryIterator(List<Book> booksList)
            {
                this.Reset();
                this.books = booksList;
            }

            Book IEnumerator<Book>.Current => this.Current();

            object IEnumerator.Current => throw new NotImplementedException();

            public Book Current()
            {
                return this.books[this.currentIndex];
            }
            public void Dispose()
            {
              
            }
            public bool MoveNext()
            {
                return ++this.currentIndex < this.books.Count;
            }

            public void Reset()
            {
                this.currentIndex = -1;
            }
        }
    }
}
