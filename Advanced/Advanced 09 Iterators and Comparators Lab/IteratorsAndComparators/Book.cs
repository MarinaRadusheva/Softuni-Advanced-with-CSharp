﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book:IComparable<Book>
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }
        public Book(string title, int year, params string[] authors)
        {
            this.Year = year;
            this.Title = title;
            this.Authors = authors.ToList();
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }

        public int CompareTo(Book other)
        {
            int index = this.Year.CompareTo(other.Year);
            if (index==0)
            {
                index = this.Title.CompareTo(other.Title);
            }
            return index;
        }
    }
}
