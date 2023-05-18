using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Functions
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }

        public static void TestFunc(int x, int y)
        {
            Func<int, int, int> sum;         
            sum = Sum;                     

            var ketqua = sum(x, y);
            Console.WriteLine(ketqua);
        }
    }
}
