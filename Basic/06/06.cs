using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Loop {
    class Program {

        static void Main(string[] args) {

            /* 99 乘法表*/
            for(int i=1; i<=9; i++){
                for(int j=1; j<=9; j++){
                    Console.WriteLine("{0} * {1} = {2}", i, j, i*j);
                }
            }

            /* for each */
            var myList = new List<string>(){ "one", "two", "three" };
            foreach (var item in myList){
                Console.WriteLine(item);
            }

            /*while*/
            int index = 0;
            while(index < myList.Count){
                Console.WriteLine(myList[index]);
                index++;
            }

            /*求數字N的所有因數*/
            int N = 66;
            int factor = 1;
            string answer = "";

            while (factor <= N){ //欲判斷的因數是否<=N
                if (N % factor == 0){
                    //符合條件的值轉成字串後，加進去字串內，後面加一個,隔開
                    answer += factor.ToString() + ",";
                }
                factor++;//每次執行完+1
            }
            Console.WriteLine($"{N}的因數為:{answer}");

            /*do...while*/
            index = 0;
            do{
                Console.WriteLine(myList[index]);
                index++;
            }while(index < myList.Count);

            Console.ReadKey();
        }
    }
}