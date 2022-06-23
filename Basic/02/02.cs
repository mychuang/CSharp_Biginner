using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variable {
    class Program {

        static void Main(string[] args) {

            /* 變數宣告 */
            const double Pi = 3.14;
            var a = 1; //自動將a定義為int
            var b = "hello";//自動將b定義為string

            Console.WriteLine(Pi);

            /* 強制轉換 */
            DateTime z = new DateTime(2019,9,5);
            string y = z.ToString();//把DateTime形式轉成字串

            Console.WriteLine(y);

            /* 字串 */
            string empty1 = "";
            string empty2 = String.Empty;
            int empty2_len = empty2.Length;
            Console.WriteLine(empty1.Length); //0
            Console.WriteLine(empty2_len ); //0

            /*null & empty*/
            string emptyString = String.Empty;
            string nullString = null;

            Console.WriteLine(emptyString); // prints nothing
            Console.WriteLine(nullString); // prints nothing

            // this line will print 0
            Console.WriteLine($"1st string is {emptyString.Length} characters long.");

            // this line will throw an exception (uncomment it to confirm)
            //Console.WriteLine($"2nd string is {nullString.Length} characters long.");


            Console.ReadKey();
        }
    }
}
