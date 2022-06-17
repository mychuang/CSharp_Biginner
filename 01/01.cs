using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_HelloWorld {
    class Program {

        static void Main(string[] args) {

            //Console是System下的類別
            Console.WriteLine("Hello World!");

            /* Read()這個方法是讀入主控台輸入的字串。
             * 程式預設一執行完就會關閉視窗，你就看不到輸出結果了。
             * 加了這一行它就會等著我們輸入字串暫時不關閉視窗。
             * 也可以寫Console.ReadKey();，讀入一個鍵的意思。
             */
            //Console.Read();
            Console.ReadKey();

            /*Console.Read():讀入一個字元
            Console.ReadLine():讀入一行字串
            Console.ReadKey():讀入一個鍵*/
        }
    }
}
