using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System.Collections;

    class Program
    {
        static void Main()
        {
           Library library = new Library();
            
            Reader reader = new Reader();
          
            reader.SeeBooks(library);
           
            Console.Read();
        }
    }

    class Reader
    {
        public void SeeBooks(Library library)
        {
            IBookIterator iterator = library.CreateNumerator();

            


            while (!iterator.HasNext())
            {
          
                Book book = iterator.Next();
                Console.WriteLine(book.Name);
            }
        }
    }
    class Library : IBookNumerable
    {
        private Book[] books;
        public Library()
        {
          
            books = new Book[]
            {
                new Book{Name="Война и мир"},
                new Book{Name="Вишневый сад"},
            };
        }
        public int Count
        {
            get { return books.Length; }
        }
        public Book this[int index]
        {
            get { return books[index]; }
        }
        public IBookIterator CreateNumerator()
        {
            return new LibraryNumerator(this);
        }

    }
    interface IBookIterator
    {
        bool HasNext();
        Book Next();
    }

    interface IBookNumerable
    {
        IBookIterator CreateNumerator();
        int Count { get; }
        Book this[int index] { get; }
    }

    class Book
    {
        public string Name { get; set; }
    }
    class LibraryNumerator : IBookIterator
    {
        IBookNumerable aggregate;
        int index=0;
        public LibraryNumerator(IBookNumerable a)
        {
            aggregate = a;
        }

        public Book Next()
        {
            //Console.WriteLine("124" + " " + index);
            return aggregate[index++];
        }
        public bool HasNext()
        {
            
            return index < aggregate.Count;
        }


    }
}
