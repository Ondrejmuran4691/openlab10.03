using System;
using System.Collections.Generic;
using System.Text;

namespace openlab10._03
{
    class Book
    {
        public string title;
        public int pages;
        public string category;
        public string author;
        public int releaseDate;


        public void apages()
        {
            if (pages < 0)
            {
                pages = 1;
            }

        }
        public void areleaseDate()
        {
            if (releaseDate < 1405)
            {
                releaseDate = -1;
            }
            else
            {
                if (releaseDate > 2021)
                {
                    releaseDate = -1;
                }
            }
        }

        public void writeall()
        {

            Console.WriteLine(title);
            Console.WriteLine(pages);
            Console.WriteLine(category);
            Console.WriteLine(author);
            Console.WriteLine(releaseDate);
        }
    }
}
