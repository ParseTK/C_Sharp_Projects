using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Methods_SET_GET_Practice
{
    class Book
    {
        public string title;
        public string author;
        public int pages;
        private int rating;


        public Book(string aTitle, string aAuthor, int aPages, int aRating)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
            Rating = aRating;
            
        }

        public bool HasPageHundred()
        {
            if (pages >= 100)
                return true;
            return false;
        }

        public int Rating 
        {         
        get { return rating; }
        set 
            {

            if (value == 1 || value == 2 || value == 3 || value == 4 || value ==5)
            {
                rating = value;
            }
            else
                {
                    rating = 0;
                }

            }
        }
    }
}
