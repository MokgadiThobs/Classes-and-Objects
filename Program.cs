using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    internal class Program
    {
        internal class book
        {
            public string title;
            public string author;
            public int pages;
        }
                static void Main(string[] args)
            {
                book book1 = new book(); //create a new book object, atthis point Book is now a data type in C#

                //creation of first book, you can now create thousans of different books eg for library app!
                book1.title = "Harry Porter";
                book1.author = "JK Rowling";
                book1.pages = 400;

                book book2 = new book();
                book2.title = "Lord of the rings";
                book2.author = "Tolkein";
                book2.pages = 900;

                Console.WriteLine(book1.pages);
                Console.WriteLine(book2.title);

                //freeze
                Console.ReadLine();
            }
            }
        }


