using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Operator {
    class Program {

        static void Main(string[] args) {

            /* 算數運算子 */
            int a = 1, b = 2;
            Console.WriteLine(a + b); //一般數字相加

            string s1 = "1", s2 = "2";
            Console.WriteLine(s1 + s2); //字串直接連起來

            a = 3;
            b = 2;
            int c = a / b;
            Console.WriteLine(c);// int 會輸出1，只顯示到整數

            double x = 3.0, y = 2.0, z;
            z = x / y;
            Console.WriteLine(z);// double 會輸出1.5

            int d = 0;
            d++;
            Console.WriteLine(d);
            

            Console.ReadKey();
        }
    }
}

