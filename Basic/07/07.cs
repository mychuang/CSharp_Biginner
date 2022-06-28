using System;

namespace _07_Array{
    class Program{
        static void Main(){
            /*未初始化*/
            int[] someIntegers = new int[3];
            //Console.WriteLine(someIntegers[0]);
            //Console.WriteLine(someIntegers[1]);
            //Console.WriteLine(someIntegers[2]);

            /*初始化陣列*/
            int[] moreIntegers = new int[] {1,2,3,4,5};
            //Console.WriteLine(moreIntegers[0]);
            //Console.WriteLine(moreIntegers[1]);
            //Console.WriteLine(moreIntegers[2]);

            //二維陣列
            int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            //Console.WriteLine(array2D[1, 1]);
            //Console.WriteLine(array2D[3, 0]);

            //三維陣列
            int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };
            //Console.WriteLine(array3D[1, 1, 2]);

            //Jagged Array
            int[][] jaggedArray = new int[4][]; // define first dimension
            jaggedArray[0] = new int[2] { 1, 2 }; // set values of first array
            //Console.WriteLine(jaggedArray[0][0]); // first element in first row
            //Console.WriteLine(jaggedArray[0][1]); // second element in first row

            /* 輸入10個數字計算平均 */
            double[] numbers = new double[10];
            Console.WriteLine("計算平均值請輸入10個數字");

            for(int i=0; i<10; i++){
                double x = Convert.ToDouble(Console.ReadLine());
                numbers[i] = x;
            }

            Console.WriteLine($"平均值為{numbers.Average()}");


        }
    }
} 
