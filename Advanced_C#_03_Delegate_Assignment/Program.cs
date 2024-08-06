using Advanced_C__03_Delegate_Assignment.Part01;
using System.Runtime.Intrinsics.X86;
using static Advanced_C__03_Delegate_Assignment.Part01.ProcessBooks;

namespace Advanced_C__03_Delegate_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01
            //Console.WriteLine("Welcome Question 2");
            #region Q01
            /*
             * 1.Considering the Code Below,
             * Write Down the Body of all Listed Methods and Properties and Constructor:
             */

            /*
             * 1.You need to parameterize ProcessBooks function to accept BookFunctions Methods
             * using following cases:
             */


            #region Delegate Method Based On Books Functions
            /*
             * a)Create User Defined Delegate with the same signature of methods
                existed in Book Functions class.
            */


                        // Sol in class ProcessBooks 


            //GetTitleDelegate GetTitle = BookFunctions.GetTitle;
            //GetAuthorsDelegate GetAuthors = BookFunctions.GetAuthors;
            //GetPriceDelegate GetPrice = BookFunctions.GetPrice;


            //b)Use the Proper build in delegate. 

            Func<Book,string> GetTitle = BookFunctions.GetTitle;
            Func<Book, string[]> GetAuthors = BookFunctions.GetAuthors;
            Func<Book,decimal> GetPrice = BookFunctions.GetPrice;


            //c)Anonymous Method(GetISBN).
            Func<Book, string> GetISBN = delegate (Book B) { return B.ISBN; };

            //d)Lambda Expression(GetPublicationDate).
            Func<Book, DateTime> GetPublicationDate =  B=>  B.PublicationDate;


            #endregion





            #endregion
            #endregion

            #region Part 02

            //Console.WriteLine("Welcome Question 2");
            #region Q02
            /*2.We need to Implement the List methods from scratch with all overloads.*/
            //●	Exist
            //●	Find
            //●	Find All
            //●	Find index
            //●	Find Last
            //●	Find Last Index
            //●	Foreach
            //●	TrueForAll

            #endregion

            #endregion
        }
    }
}
