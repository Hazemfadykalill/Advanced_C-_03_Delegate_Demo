using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__03_Delegate_Assignment.Part01
{
    public class Book
    {
        #region Constructor
        public Book(string iSBN, string title, DateTime publicationDate, decimal price, string[] authors)
        {
            ISBN = iSBN;
            Title = title;
            PublicationDate = publicationDate;
            Price = price;
            Authors = authors;
        } 
        #endregion
        #region Property
        public string ISBN { get; set; }
        public string Title { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        public string[] Authors { get; set; }

        #endregion

        #region Method
        public override string ToString()
        {

            return base.ToString();

        }
        #endregion
    }
}
