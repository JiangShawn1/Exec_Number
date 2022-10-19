using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {//判斷某數是不是質數
            Console.Write("輸入要判斷的數字:");
            string input = Console.ReadLine();

            int num=int.Parse(input);
            int num1 = 0;

            for(int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    num1++;                    
                }               
                
            }
            if (num1 == 2)
            {
                Console.WriteLine("是質數");
            }
            else
            {
                Console.WriteLine("不是質數");
            }

        }
    }
}
