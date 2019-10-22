using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一個數字: ");

            string input_str = Console.ReadLine();  //input  string 
            int input_int = int.Parse(input_str);
            Class1 class1 = new Class1();
            class1.Play();
            //while 


            Console.WriteLine("hello ");
            Console.ReadKey();

        }
    }
}
