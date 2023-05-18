using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class TestGeneric
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T c = a;
            a = b;
            b = c;
        }
        public static void TestSwap()
        {
            int a = 1;
            int b = 2;
            Swap<int>(ref a, ref b);                       
            System.Console.WriteLine($"a = {a}; b = {b}"); 
            string a1 = "A";
            string b1 = "B";
            Swap<string>(ref a1, ref b1); 
            System.Console.WriteLine($"a1 = {a1}; b1 = {b1}"); 
        }
    }
}
