using System;
using System.Collections.Generic;
using System.Text;

namespace Objects_Lab___Class_Design
{
    class TVShow
    {
        string title;
        string plot;
        int year;
        string genre;

        public TVShow(string title, string plot, int year)
        {
            this.title = title;
            this.plot = plot;
            this.year = year;
        }

        public string Title { get => title; set => title = value; }
        public string Plot { get => plot; set => plot = value; }
        public int Year { get => year; set => year = value; }
    }
}
