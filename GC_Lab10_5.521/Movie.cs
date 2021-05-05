using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace GC_Lab10_5._521
{
    class Movie : IComparable<Movie>
    {
        //FIELDS:
        private string title;
        private string category;

        //PROPERTIES
        public string Title {get {return title;} set { title = value;}}
        public string Category { get { return category; } set { category = value; } }

        //CONSTRUCTOR
        public Movie(string _title, string _category)
        {
            title = _title;
            category = _category;
        }

        public Movie() { } //default

        //METHODS
        public void PrintTitle()
        {
            Console.WriteLine(title);
        }

        public void PrintGenre()
        {
            Console.WriteLine(category);
        }

        public int CompareTo(Movie mo)
        {
            return this.Title.CompareTo(mo.Title);
        }

    }
}
