﻿using System.Collections;
using System.Collections.Generic;

namespace _01_Library
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library()
        {
            this.books = new List<Book>();
        }

        public void Add(Book book)
        {
            this.books.Add(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            foreach (var book in this.books)
            {
                yield return book;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
