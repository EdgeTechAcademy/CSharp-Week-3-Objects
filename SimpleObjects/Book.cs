using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleObjects
{
    class Book
    {
        int pages;
        string title;
        string author;
        string description;

        // click on the screw driver or Quick Actions light bulb
        // Generate Constructor
        public Book(int pages, string title, string author, string description)
        {
            this.Pages = pages;
            this.Title = title;
            this.Author = author;
            this.Description = description;
        }

        // Select class attributes 
        // Ctrl+. or click on Quick Actions light bulb
        // Encapsulate fields use Property
        public int Pages { get => pages; set => pages = value; }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Description { get => description; set => description = value; }

        // Quick Actions
        // Generate overrides
        // Only select the ToString method. 
        // This isn't a big deal since the editor really doesn't do much for you
        public override string ToString()
        {
            return String.Format("{0} is {1} pages long was written by {2}\nBook description {3}\n", Title, Pages, Author, Description);
        }
    }
}
