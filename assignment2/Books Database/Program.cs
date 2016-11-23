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
            int amount = 0;
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
                        if (amount < value)
                        {
                            Console.WriteLine("Enter data for book {0}", amount + 1);
                            Console.Write("Enter the name of the book: ");
                            books[amount].title = Console.ReadLine();

                            Console.Write("Enter the author: ");
                            books[amount].author = Console.ReadLine();

                            Console.WriteLine("Enter the name of publication: ");
                            books[amount].publication = Console.ReadLine();

                            amount++;
                            Console.WriteLine();
                        }
                        else
                            Console.WriteLine("Database full");
                        break;


                    case "2":
                        if (amount == 0)
                            Console.WriteLine("No data to search");
                        else
                        {
                            for (int i = 0; i < amount; i++)
                            {
                                Console.WriteLine("-----------------------------------------------------------------------");
                                Console.WriteLine("{0}: Title  : {1}  | \t Author  : {2}  | \t Publication  : {3}  ",
                                i + 1, books[i].title, books[i].author, books[i].publication);
                                Console.WriteLine();
                            }
                        }
                        break;

                    case "3":
                        Console.WriteLine("Enter the name of the book");
                        search = Console.ReadLine();
                        found = false;

                        for (int i = 0; i < amount; i++)
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
                        if(amount==0)
                        Console.WriteLine("No Books To Delete");
                        else
                        {
                            Console.WriteLine("Enetr Number Of Book To Delete:");
                            int pos = Convert.ToInt32(Console.ReadLine());
                            for (int i = pos; pos < amount; i++)
                                books[i] = books[i + 1];
                            amount--;
                            
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
