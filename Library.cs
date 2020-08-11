using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LibraryProject
{
    public class Library : Book
    {
        public List<Book> Books { get; set; }
        public Library()
        {
            Books = new List<Book>()
            {
                new Book("The Old Man and the Sea", "Ernest Hemingway", Genre.Fiction, false),
                new Book("Bluets", "Maggie Nelson", Genre.Poetry, false),
                new Book("Bough Down", "Karen Green", Genre.Poetry,false),
                new Book("Men Without Women", "Haruki Murakami", Genre.Fiction,false),
                new Book("Streetfight: Handbook for an Urban Revolution", "Janette Sadik-Khan", Genre.NonFiction,false),
                new Book("The Odyssey", "Homer", Genre.Fiction,false),
                new Book("The Language of Cities", "Deyan Sudjic", Genre.NonFiction,false),
                new Book("Pinball, 1973", "Haruki Murakami", Genre.Fiction,false),
                new Book("Play It As It Lays", "Joan Didion", Genre.Fiction,false),
                new Book("The Virgin Suicides", "Jeffery Eugenides", Genre.Fiction,false),
                new Book("The Metamorphosis", "Franz Kafka", Genre.Fiction,false),
                new Book("The Color of Law: A Forgotten History of How Our Gobernment Segregated America", "Richard Rothstein", Genre.NonFiction,false),
                new Book("The Things They Carried", "Tim O'Brien", Genre.Fiction,false),
                new Book("The Templars", "Dan Jones", Genre.NonFiction,false),
                new Book("In the Heart of the Sea", "Nathaniel Philbrick", Genre.NonFiction,false),
                new Book("A Time of Gifts", "Patrick Leigh Fermor", Genre.Fantasy,false),
                new Book("The Road Less Traveled", "Robert Frost", Genre.Poetry,false)
            };
        }
        public void GetTitles()
        {
            foreach (Book Book in Books)
            {
                Console.WriteLine(Book.Title);
            }
        }
        public void DisplayAvailableBooks()
        {
            foreach (Book book in Books)
            {
                if (CheckedOut == false)
                {
                    Console.WriteLine(book.CheckedOut);
                }
            }
        }
        public void CheckOutBookbyTitle()
        {
            
            
            Console.WriteLine("\n");
            Console.WriteLine("Ah so you would like to check out a book! Please input the name of the book you would like to take out: ");
            string title = Console.ReadLine().ToLower().Trim();
            foreach (Book book in Books)
            {
                if (book.Title.ToLower().Contains(title))
                {
                    if (book.CheckedOut == false)
                    {
                        Console.Write("\nPerfect that book " + title.ToUpper().Trim()); 
                        Console.WriteLine(" Is available would you like to check the book out? y/n");
                        string input = Console.ReadLine();
                        if (input == "y")
                        {
                            book.CheckedOut = true;
                            book.DueDate = DateTime.Now.AddDays(14);
                            break;
                        }
                    }
                }
            }
            Console.WriteLine("\n Alright, the current date and time is: \n");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
        }
        public void GetUserInputGenres(Genre genreValue)
        {
            Console.WriteLine("This is our list of Genres pick one and it will list the books in that Genre catagory ");
            Genre  = genreValue;

            foreach (Book book in Books)
            {
                   
                Console.WriteLine(book.Title);
                Console.WriteLine("This book is: ");
                Console.WriteLine(book.Genre);
            }
            
        }
        public static void WhichGenre()
        {
            Genre genreValue = Genre.Romance;
            string enumValue = genreValue.ToString();
            Console.WriteLine("Here are our genre's of books to choose from: \n");
            for (Genre g = Genre.SciFi;
            g <= Genre.Fiction; g++)
            {
                string value = g.ToString();
                Console.WriteLine(value);
            }
        }
        public void CheckOutBookByGenre()
        {
            Genre selectedGenre = 0;
            Console.WriteLine("\nAh so you would like to check out a book, great! \nPlease input your choice: ");
            string genre = Console.ReadLine().ToLower().Trim();
            if (genre == "scifi")
            {
                selectedGenre = Genre.SciFi;
            }
            if (genre == "romance")
            {
                selectedGenre = Genre.Romance;
            }
            if (genre == "action")
            {
                selectedGenre = Genre.Action;
            }
            if (genre == "fantasy")
            {
                selectedGenre = Genre.Fantasy;
            }
            if (genre == "biography")
            {
                selectedGenre = Genre.Biography;
            }
            if (genre == "nonfiction")
            {
                selectedGenre = Genre.NonFiction;
            }
            if (genre == "mystery")
            {
                selectedGenre = Genre.Mystery;
            }
            if (genre == "thriller")
            {
                selectedGenre = Genre.Thriller;
            }
            if (genre == "poetry")
            {
                selectedGenre = Genre.Poetry;
            }
            if (genre == "fiction")
            {
                selectedGenre = Genre.Fiction;
            }

            foreach (Book book in Books)
            {
                if (book.Genre == selectedGenre)

                {
                    if (book.CheckedOut == false)
                    {
                        Console.WriteLine("Perfect, books of that genre is available");
                        Console.WriteLine("Would you like to check out one of the books out? y/n");
                        string input = Console.ReadLine();
                        if (input == "y")
                        {
                            book.CheckedOut = true;
                            book.DueDate = DateTime.Now.AddDays(14);
                            break;
                        }
                    }
                }
            }
        }
        public void DisplayAuthors()
        {
            foreach (Book Book in Books)
            {
                Console.WriteLine(Book.Author);
            }
        }
        public void DisplayBooksByAuthor()
        {
            Console.WriteLine("\n ah so you would like to check out a book, great! \n Please input your choice: ");
            string author = Console.ReadLine().ToLower().Trim();
            foreach(Book book in Books)
            {
                if (book.Author.ToLower().Contains(author))
                {
                    Console.WriteLine(book.Title);
                }
            }
        }
        public void CheckOutBooksByAuthor()
        {
            Console.WriteLine("\n so you would like to checkout a book by a specific auther, great!\n");
            string author = Console.ReadLine().ToLower().Trim();

            foreach (Book book in Books)
            {
                if (book.Author.ToLower().Contains(author))
                {

                    if (book.CheckedOut == false)
                    {
                        Console.Write("\nPerfect, their book is available\n");
                        Console.WriteLine("Would you like to check the book out? y/n");
                        string input = Console.ReadLine();
                        if (input == "y")
                        {
                            book.CheckedOut = true;
                            book.DueDate = DateTime.Now.AddDays(14);
                            CheckOutBookbyTitle();
                            break;
                        }
                    }


                }
            }
        }
        public void PrintBooks()
        {
            for (int i = 0; i < Books.Count; i++)
            {
                Console.WriteLine($"{i +1}) {Books[i].Title} written by {Books[i].Author}");
            }
        }
       
    }
}
