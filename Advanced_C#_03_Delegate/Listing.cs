using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__03_Delegate
{
    public class Listing
    {
        #region Delegate
        public delegate bool EvenOrOddDelegate(int i);
        #endregion
        #region Delegate Example 03 Without Generics

        #region Method General
        public static List<int> FindOddNumbers(List<int> list)
        {
            List<int> result = new List<int>();
            if(list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 != 0)
                    {
                        result.Add(list[i]);
                    }

                }
            }

            return result;

        }

        public static List<int> FindEvenNumbers(List<int> list)
        {
            List<int> result = new List<int>();
            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] % 2 == 0)
                    {
                        result.Add(list[i]);
                    }

                }
            }

            return result;

        }
        #endregion

        #region Method With Delegate Without Generics
        //public static List<int> FindNumbersEvenOrOdd(List<int> list, EvenDelegate del)
        //{
        //    List<int> result = new List<int>();
        //    if (list is not null)
        //    {
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            if (del(list[i]))
        //            {
        //                result.Add(list[i]);
        //            }

        //        }
        //    }

        //    return result;

        //}
        #endregion

      

        #region Constant Method Condition
        public static bool Even(int i) => i % 2 == 0;
        public static bool Odd(int i) => i % 2 != 0;
        #endregion
        #endregion

        #region Delegate Examlpe03 With Generics
        #region Method Delegate With Generics
        public static List<int> FindNumbersEvenOrOdd(List<int> list, EvenDelegate del)
        {
            List<int> result = new List<int>();
            if (list is not null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (del(list[i]))
                    {
                        result.Add(list[i]);
                    }

                }
            }

            return result;

        }
        #endregion 
        #endregion
    }
}
