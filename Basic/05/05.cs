using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_if {
    class Program {

        /* sample 1 */
        static void Main(string[] args) {
            Greet("Miller");
            checkNum();
            testSwitch();
        }
        static void Greet(string name){
            if (String.IsNullOrEmpty(name)) return;
            Console.WriteLine($"Hello, {name}!");
        }

        /* sample 2 */
        static void checkNum(){
            int x, y, answer;
            Console.Write("Enter x =");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y =");
            y = Convert.ToInt32(Console.ReadLine());

            if (x > y){
                answer = x;
            }else if(x == y){
                answer = x;
            }else{
                answer = y;
            }

            Console.Write("The big number = {0}", answer);
        }

        static void testSwitch(){
            uint guessedNumber = 1; // try different numbers to see resulting behavior
            switch (guessedNumber){
                case 0:
                    Console.WriteLine("Sorry, 0 is not a valid guess.");
                    break;
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("You guessed low.");
                    break;
                case 4:
                    Console.WriteLine("You guessed the right number!");
                    break;
                default:
                    Console.WriteLine("You guessed high.");
                    break;
}
        }
    }
}
