using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace LibraryProject
{
    class Program
    {

    
        static void Main(string[] args)
        {
            Library library = new Library();
            MenuSelection(library);
           
            
        }

        public static string GetUserInput(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static void DisplayMenu()
        {
            Console.WriteLine("1.) View our Book List");
            Console.WriteLine("2.) Search by Title");
            Console.WriteLine("3.) Search by Author");
            Console.WriteLine("4.) Search by Genre");
            Console.WriteLine("5.) Exit the Library\n");
        }

        public static void MenuSelection(Library library)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to the Library");
            Console.WriteLine("======================");
            Console.Write("Please hit any key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Welcome to the Library");
            Console.WriteLine("=======================");
            DisplayMenu();
            Console.WriteLine("______________________");
            Console.WriteLine();
            switch (GetUserInput("Please pick a number from the List: "))
            {
                case "1":
                    Console.WriteLine("=========================");
                    Console.WriteLine();
                    Console.WriteLine("Library titles: \n");
                    library.PrintBooks();
                    ContinueMenu(library);
                    break;
                case "2":
                    Console.WriteLine("Here are our books by title: \n");
                    Console.WriteLine("------------------------------\n");
                    library.GetTitles();
                    library.CheckOutBookbyTitle();
                    ContinueMenu(library);
                    break;
                case "3":
                    Console.WriteLine("Here are our books by author: \n");
                    Console.WriteLine("---------------------------------\n");
                    Console.WriteLine("Please type out the name of your choice\n");
                    library.DisplayAuthors();
                    library.CheckOutBooksByAuthor();
                    ContinueMenu(library);
                    break;
                case "4":
                    Console.WriteLine("Here are our books by genre\n");
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Please type out the name of your choice\n");
                    Library.WhichGenre();
                    library.CheckOutBookByGenre();
                    ContinueMenu(library);
                    break;
                case "5":
                    Console.WriteLine("Thanks for visiting us today!");
                    Console.WriteLine("==============================");
                    Console.WriteLine("We love to read");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("What are you doing with youself?");
                    MenuSelection(library);
                    break;
            }
        }

        public static void ContinueMenu(Library library)
        {
            bool programStar = true;
            while (programStar)
            {
                
                Console.WriteLine("\nWould you like to continue? y/n\n");
                string responseLast = Console.ReadLine();

                if (responseLast == "y")
                {
                    MenuSelection(library);
                    break;
                }
                else if (responseLast == "n" || responseLast == "no")
                {
                    Console.WriteLine();
                    Console.WriteLine("Thank you for visitng us today\n");
                    Console.WriteLine("Please wear a mask and socially distance yourself!\n");
                    break;
                }
                else
                {
                    Console.WriteLine("Continue? y/n?");
                }
            }
        }
    }
}
