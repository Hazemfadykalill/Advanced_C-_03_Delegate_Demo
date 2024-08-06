using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__03_Delegate_Assignment.Part01
{
    public class ProcessBooks
    {
        #region Delegate Method Based On Books Functions
      
        public  delegate string GetTitleDelegate(Book B);
        public delegate string[] GetAuthorsDelegate(Book B);

        public delegate decimal GetPriceDelegate(Book B);
      
        #endregion
    }
}
