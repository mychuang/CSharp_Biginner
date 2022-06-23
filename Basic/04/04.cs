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
            
            /* Math */

            int x1, y1;
            Console.Write("Enter x:");
            x1 = int.Parse(Console.ReadLine());
            Console.Write("Enter y:");
            y1 = int.Parse(Console.ReadLine());

            Console.WriteLine("x = {0}, y={1}, Mean={2}", x1, y1, (x1+y1)/2);

            /* Math retrun value is Double*/
            Double x2, y2;
            Console.Write("Enter x:");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y:");
            y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("x^2 - y^2 = {0}", Math.Pow(x2, 2) - Math.Pow(y2,2));

            Console.WriteLine("sqrt(x) = {0}", Math.Pow(x2, 02));
            Console.WriteLine("sqrt(y) = {0}", Math.Sqrt(y2));

            Console.WriteLine("sin(x)={0}", Math.Sin(x2));

            Console.ReadKey();
        }
    }
}

