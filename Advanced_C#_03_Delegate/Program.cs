using static Advanced_C__03_Delegate.Sorting;
using static Advanced_C__03_Delegate.StringsFunctions;

namespace Advanced_C__03_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Delegate [Example 01]
            //GetCountFuncUpper x = StringsFunctions.GetCountOfUpperCharacter;//syntax Sugar
            ////GetCountFuncUpper x =new GetCountFuncUpper(StringsFunctions.GetCountOfUpperCharacter) ;

            ////x ==> Become Function Same Function StringsFunctions.GetCountOfUpperCharacter();
            //// X ==> Become Refer To Another Function Same Signature this Delegate
            //int Count = x("Hello World");// or int Count = x.Invoke("Hello World");
            //Console.WriteLine(Count);


            ////To X refer to another function
            //x += StringsFunctions.GetCountOfLowerCharacter;
            //int Count02 = x("Hello World");
            //Console.WriteLine(Count02); 
            #endregion

            #region Delegate [ Example 02 Sorting ]
            int[] Numbers = new int[] { 5, 7, 8, 7, 6, 4, 3, 2, 1 };
            ////Ascending
            //Sorting.BubbleSortAscending(Numbers);
            //foreach(int number in Numbers)
            //{
            //    Console.Write(" " + number);

            //}

            #region After Delegate
            //Descending
            SortingDelegateGraterOrSmallest Grater=Sorting.Greater;
            Sorting.BubbleSortWithDelegate(Numbers, Grater);

            foreach (int number in Numbers)
            {
                Console.Write(" " + number);

            }

            Console.WriteLine("\n\n=============");

            //Ascending
            SortingDelegateGraterOrSmallest Smaller = Sorting.Smallest;
            Sorting.BubbleSortWithDelegate(Numbers, Smaller);

            foreach (int number in Numbers)
            {
                Console.Write(" " + number);

            }

           
            #endregion
            #endregion
        }
    }
}
