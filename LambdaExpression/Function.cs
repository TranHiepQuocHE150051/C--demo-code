using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
            

    public class Function
    {
        public delegate int TinhToan(int a, int b);
        public  static void calculate ()
        {

            Func<int, int, int> tinhtong1 = (int x, int y) => {
                return x + y;
            };
            Action<int> thongbao = (int vl) => {
                Console.WriteLine(vl);
            };

            int kq1 = tinhtong1(5, 3); 
            int kq2 = tinhtong1(5, 5); 
            thongbao(kq1); 
            thongbao(kq2); 

        }
    }
}
