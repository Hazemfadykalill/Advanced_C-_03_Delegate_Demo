using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__03_Delegate
{
    public  class Sorting
    {
        #region Method Sorting Without Generic
        #region Delegate 
        public delegate bool SortingDelegateGraterOrSmallest(int L ,int R);   
        public delegate void SortingDelegate(int[]arr);
       
        #endregion
        #region Without Delegate [Without Generics]
        #region Ascending
        public static void BubbleSortAscending(int[] arr)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            //Swap
                            Helper.Swap(ref arr[j], ref arr[j + 1]);
                        }
                    }

                }
            }
        }
        #endregion

        #region Descending
        public static void BubbleSortDescending(int[] arr)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (arr[j] < arr[j + 1])
                        {
                            //Swap
                            Helper.Swap(ref arr[j], ref arr[j + 1]);
                        }
                    }

                }
            }
        }
        #endregion 
        #endregion

        #region Notes
        //دلوقتي الداللتين ياعم حازم نفس الكود مع اختلاف  الأكبير من والأصغر من فلازم نحل ذلك لعدم التكرار 

        #region Sol Method Greater OR Smaller
        public static bool Greater(int left, int Right) => left < Right;
        public static bool Smallest(int left, int Right) => left > Right;
        #endregion
        #endregion


        #region Sorting By Use Delegate

        public static void BubbleSortWithDelegate(int[] arr,SortingDelegateGraterOrSmallest del)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (del(arr[j], arr[j+1]))
                        {
                            //Swap
                            Helper.Swap(ref arr[j], ref arr[j + 1]);
                        }
                    }

                }
            }
        }
        #endregion
        #endregion

    }
}
