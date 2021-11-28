using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace openlab10._03
{


    class Program
    {
        static void Main(string[] args)
        {
            
            
                Book LOTR = new Book();
                LOTR.title = "LOTR";
                LOTR.author = "J. R. R. Tolkien";
                LOTR.category = "Fantasy";
                LOTR.pages = 9250;
                LOTR.releaseDate = 1954;
                if (LOTR.pages < 0)
                {
                    LOTR.pages = 1;
                }
                if (LOTR.releaseDate < 1405)
                {
                    LOTR.releaseDate = -1;
                }
                else
                {
                    if (LOTR.releaseDate > 2021)
                    {
                        LOTR.releaseDate = -1;
                    }
                }
                LOTR.apages();
                Console.WriteLine(LOTR.title);
                Console.WriteLine(LOTR.pages);
                Console.WriteLine(LOTR.category);
                Console.WriteLine(LOTR.author);
                Console.WriteLine(LOTR.releaseDate);



            
        }
    }
}
