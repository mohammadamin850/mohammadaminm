using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



    abstract class Book
    {
        public string Title { get; set; }
        public string Auther { get; set; }
        public int Pages { get; set; }

        public Book(string title, string auther, int pages)
        {
            Title = title;
            Auther = auther;
            Pages = pages;
        }
        
        public abstract void Add();

        public void DisPlay()
        {
            Console.WriteLine($"Title :{Auther}");
            Console.WriteLine($"Auther : {Title}");
            Console.WriteLine($"Page : {Pages}");
        }
    }
