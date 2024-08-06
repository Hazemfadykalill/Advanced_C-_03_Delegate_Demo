using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__03_Delegate_Assignment.Part01
{
    public  class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }

        public static string[] GetAuthors(Book B)
        {
            string[] Authors= B.Authors;
            return Authors;
         

          
        }

        public static decimal GetPrice(Book B)
        {
            return B.Price;
        }

    }
}
