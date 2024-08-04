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
        }
    }
}
