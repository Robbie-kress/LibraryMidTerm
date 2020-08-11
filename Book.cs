using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace LibraryProject
{
    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }
        public Genre Genre { get; set; }

        public List<Library> Books { get; set; }

        public bool CheckedOut { get; set; }
        public DateTime DueDate { get; set; }
        public Book() { }
        public Book(string Title, string Author, Genre Genre, bool CheckedOut)
        {
            this.Title = Title;
            this.Author = Author;
            this.Genre = Genre;
            this.CheckedOut = CheckedOut;
            DueDate = DateTime.Now.AddDays(14);
       
        }
        public void PrintInfo()
        {
            Console.WriteLine($"{Title}");
            Console.WriteLine($"{Author}");
            Console.WriteLine($"{Genre}");
        }
    }   
}
