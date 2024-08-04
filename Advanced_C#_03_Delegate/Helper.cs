using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__03_Delegate
{
    public class Helper
    {
        public static void Swap(ref int x ,ref int y)
        {
            int Temp = x;
            x = y;
            y=Temp; 
        }
    }
}
