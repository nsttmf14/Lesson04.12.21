using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04._12._21
{
    class Books<Book>
    {
        Book[] books = new Book[] { };
        int size;

        public int Size { get => size; }
        public void Add(Book book)
        {
            Book[] newData = new Book[Size + 1];
            books.CopyTo(newData, 0);
            newData[size] = book;
            size++;
            books = new Book[size];
            newData.CopyTo(books, 0);
        }

        public void Array()
        {
            books = new Book[] { };
            size = 0;
        }

        public void Array(params Book[] books)
        {
            this.books = books;
            size += books.Length;
        }

        public void RemoveAll()
        {
            books = null;
            size = 0;
        }

        public Book GetAt(int index)
        {
            if (index >= 0 && index < Size)
            {
                return books[index];
            }
            else
            {
                throw new Exception("This index does not exist.");
            }
        }

        public Book this[int index]
        {
            get
            {
                if (index >= 0 && index < Size)
                {
                    return books[index];
                }
                else
                {
                    throw new Exception("This index does not exist.");
                }
            }
            set
            {
                if (index >= 0 && index < Size && value is Book)
                {
                    books[index] = value;
                }
                else
                {
                    throw new Exception("This index does not exist.");
                }
            }
        }

        public delegate void SortingType();

        public static SortingType byName = SortingByName;
        public static SortingType byAuthor = SortingByAuthor;
        public static SortingType byPublisher = SortingByPiblisher;

        private static void SortingByName()
        {
            Console.WriteLine("Сортировка по имени");
        }

        private static void SortingByAuthor()
        {
            Console.WriteLine("Сортировка по автору");
        }

        private static void SortingByPiblisher()
        {
            Console.WriteLine("Сортировка по издательству");
        }

        public void Sort(SortingType sort)
        {
            sort();
        }
    }
}
