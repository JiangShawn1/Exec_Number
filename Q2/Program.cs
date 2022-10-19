using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {//找出數值區間內所有質數
            Console.Write("輸入要判斷的區間下限:");
            string input = Console.ReadLine();
            Console.Write("輸入要判斷的區間上限:");
            string input1 = Console.ReadLine();
            
            int num = int.Parse(input);
            int num1=int.Parse(input1);            
            int num2 = 0;

            for (int i = num; i <= num1; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        num2++;
                    }                    
                }
                if (num2 == 2)
                {
                    Console.WriteLine(i);
                    
                }
                num2 = 0;
            }
            
        }
    }
}
