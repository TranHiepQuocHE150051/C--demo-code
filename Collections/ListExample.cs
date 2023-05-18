using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class ListExample
    {
        public static void TestListFunction()
        {
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);
            numbers.RemoveAt(0);
            numbers.RemoveRange(numbers.Count - 2, 2);            
        }
        
    }
}
