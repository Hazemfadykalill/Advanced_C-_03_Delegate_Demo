using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C__03_Delegate
{
    public class StringsFunctions
    {
        public delegate int GetCountFuncUpper(string word);
        public static int GetCountOfUpperCharacter(string Word)
        {
            int count = 0;
            if (!string.IsNullOrEmpty(Word))
            {
                for (int i = 0; i < Word.Length; i++)
                {
                    if (char.IsUpper(Word[i]))
                    {
                        count++;
                    }

                }
                return count;

           }
            return count;
        }

        public static int GetCountOfLowerCharacter(string Word)
        {
            int count = 0;
            if (!string.IsNullOrEmpty(Word))
            {
                for (int i = 0; i < Word.Length; i++)
                {
                    if (char.IsLower(Word[i]))
                    {
                        count++;
                    }

                }
                return count;

            }
            return count;
        }
    }
}
