using System;
using System.Collections.Generic;
using System.Text;

namespace MovieLab
{
    class Movie
    {
        //fields
        private string _title;
        private string _category;
        //properties
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Category
        {
            get { return _category; }
            set { _category = value; }
        }
        //constructor
        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }
    }
}
