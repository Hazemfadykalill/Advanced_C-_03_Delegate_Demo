using System.Collections;
using static Advanced_C__03_Delegate.Listing;

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
            //int[] Numbers = new int[] { 5, 7, 8, 7, 6, 4, 3, 2, 1 };
            ////Ascending
            //Sorting.BubbleSortAscending(Numbers);
            //foreach(int number in Numbers)
            //{
            //    Console.Write(" " + number);

            //}

            #region After Delegate
            //Descending
            //SortingDelegateGraterOrSmallest Grater=Sorting.Greater;
            //Sorting.BubbleSortWithDelegate(Numbers, Grater);

            //foreach (int number in Numbers)
            //{
            //    Console.Write(" " + number);

            //}

            //Console.WriteLine("\n\n=============");

            ////Ascending
            //SortingDelegateGraterOrSmallest Smaller = Sorting.Smallest;
            //Sorting.BubbleSortWithDelegate(Numbers, Smaller);

            //foreach (int number in Numbers)
            //{
            //    Console.Write(" " + number);

            //}


            #endregion
            #endregion
            #region Delegate With Generics
            //string[] Characheter = { "a", "b", "c" };
            //int[] Numbers = { 1, 2, 3, 8,7,5,8};
            //SortingDelegateGraterOrSmallest As = Sorting<int>.Greater;
            //Sorting<int>.BubbleSortWithDelegateWithGenerics(Numbers, As); 
            #endregion

            #region Example 03 Without Generics
            //List<int> Numbers=Enumerable.Range(1,100).ToList();


            ////Even 
            //EvenOrOddDelegate Even = Listing.Even;
            //List<int> Result = Listing.FindNumbersEvenOrOdd(Numbers, Even);
            //Console.WriteLine("Even Numbers");
            //foreach (var item in Result)
            //{
            //    Console.Write("" + " " + item);

            //}
            //Console.WriteLine("\n\n============");


            ////Even 
            //EvenOrOddDelegate Odd = Listing.Odd;
            //List<int> Result02 = Listing.FindNumbersEvenOrOdd(Numbers, Odd);
            //Console.WriteLine("Odd Numbers");
            //foreach (var item in Result02)
            //{
            //    Console.Write("" + " " + item);

            //}
            //Console.WriteLine("\n\n============");

            #endregion

            #region Ex 03 With Generics
            //GeneralDel<string> three = Listing.GreaterThree;
            //List<string> Names = new List<string>() { "Hazam","Fady","Mohamed","fa" };
            //List<string> Result=Listing.Filteration<string>(Names, three);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(" " + item);
            //}


            #endregion

            #region Action Delegate
            //Action action = Helper<int>.actionFunc;
            //action();
            #endregion
        }
    }
}
