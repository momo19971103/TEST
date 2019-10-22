using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class1
    {
        private int randomNum;
        private int inputNum;
        private bool gameOver;

        public void Play()
        {
            Console.WriteLine("歡迎來到我的遊戲");

            Random rnd = new Random();
            randomNum = rnd.Next(10);

            while (true)
            {

                //處理輸入，並將其轉為數字
                string input_str = Console.ReadLine();  //input  string 
                inputNum = int.Parse(input_str);

                //遊戲邏輯
                if (randomNum == inputNum)
                {
                    gameOver = true;
                }

                if (gameOver)
                {
                    break; //離開遊戲
                }
            }

            Console.WriteLine("你已經死了!");
        }
    }
}
