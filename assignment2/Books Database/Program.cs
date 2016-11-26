using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Database
{
    public class BooksDatabase
    {

        struct book
        {
            public string title;
            public string publication;
            public string author;
        }

        public static void Main()
        {

            int value = 10;
            book[] books = new book[value];
            bool repeat = true;
            bool found;
            string option, search;
            int index = 0;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Books database");
                Console.WriteLine();
                Console.WriteLine("1- Add a new book");
                Console.WriteLine("2- Display all books");
                Console.WriteLine("3- Search book");
                Console.WriteLine("4- Delete a book");
                Console.WriteLine("5- Exit");
                Console.Write("Enter an option: ");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        if (index < value)
                        {
                            Console.WriteLine("Enter data for book {0}", index + 1);
                            Console.Write("Enter the name of the book: ");
                            books[index].title = Console.ReadLine();

                            Console.Write("Enter the author: ");
                            books[index].author = Console.ReadLine();

                            Console.WriteLine("Enter the name of publication: ");
                            books[index].publication = Console.ReadLine();

                            index++;
                            Console.WriteLine();
                        }
                        else
                            Console.WriteLine("Database full");
                        break;


                    case "2":
                        if (index == 0)
                            Console.WriteLine("No data to search");
                        else
                            for (int i = 0; i < index; i++)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------");
                                Console.WriteLine("{0}: Title  : {1}  | \t Author  : {2}  | \t Publication  : {3}  ",
                                i + 1, books[i].title, books[i].author, books[i].publication);
                                Console.WriteLine();
                            }
                        break;

                    case "3":
                        Console.WriteLine("Enter the name of the book");
                        search = Console.ReadLine();
                        found = false;

                        for (int i = 0; i < index; i++)
                            if (books[i].title == search.ToUpper())
                            {
                                Console.WriteLine("-----------------------------------------------------------------------");
                                Console.WriteLine("{0}: Title  : {1}  | \t Author  : {2}  | \t Publication  : {3}  ",
                                i + 1, books[i].title, books[i].author, books[i].publication);
                                found = true;
                            }

                        if (!found)
                            Console.WriteLine("Not found!");

                        Console.WriteLine();
                        break;

                    case "4":
                        if (index == 0)
                        Console.WriteLine("No Books To Delete");
                        else
                        {
                            Console.WriteLine("Enetr Number Of Book To Delete:");
                            int pos = Convert.ToInt32(Console.ReadLine())-1;
                            for (int i = pos; i < index-1; i++)
                                books[i] = books[i + 1];
                            index--;
                        }
                        break;
                    case "5":
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Wrong option. Please enter \n");
                        break;
                }

            }
            while (repeat);
        }
    }
}
