using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__03_Delegate_Assignment.Part01
{
    public class LibraryEngine
    {

        public static void ProcessBooks(List<Book> bList,BookFunctions FPtr)
        {
            foreach (Book B in bList)
            { 
                //Console.WriteLine(FPtr(B));    
            }

        }
    }
}
