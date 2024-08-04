using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__03_Delegate
{
    public class Helper<T>
    {
        public static void Swap(ref T x ,ref T y)
        {
            T Temp = x;
            x = y;
            y=Temp; 
        }
    }
}
