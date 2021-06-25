using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class3
    {
        private string title;
        private string director;
        private string rating;


        public Class3(string aTitle2, string aDirector, string aRating)
        {
            title = aTitle2;
            director = aDirector;
            Rating = aRating;
            Rating = aRating;
        }

        public string Rating
        {
            get { return rating; }
            set
            {
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
