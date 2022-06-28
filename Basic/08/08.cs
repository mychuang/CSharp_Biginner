using System;

namespace _08_methods{
    class Program{
        public static void Main(){
            /*use static method*/
            int i = MyClass01.Add(3,5);
            Console.WriteLine(i);

            /*use non-static method*/
            MyClass02 MyObj = new MyClass02();
            int j = MyObj.plus(3,5);
            Console.WriteLine(j);

            /* Overload */
            string greeting = CreateGreeting();
            Console.WriteLine($"Default Greeting: {greeting}");
        
            string customGreeting = CreateGreeting("Steve");
            Console.WriteLine($"Custom Greeting: {customGreeting}");
        }

        /*Overload*/
        static string CreateGreeting(){
            // call version with more parameters, passing a default value
            return CreateGreeting("You"); 
        }
        static string CreateGreeting(string name){
            return $"Hi {name}!";
        }
    }

    class MyClass01{
        public static int Add(int x, int y){
            return x+y;
        }
    }

    class MyClass02{
        public int plus(int x, int y){
            return x*y;
        }
    }
}