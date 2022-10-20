using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {//百元買百雞，公雞5元母雞3元小雞三隻1元

            //x+y+z=100
            //5x+3y+z/3=100
            for (int c = 0; c <= 20; c++)
            {
                for (int h = 0; h <= 33; h++)
                {
                    for (int i = 0; i < 100; i++)
                    {
                        if (5 * c + 3 * h + i/3 == 100 && c + h + i == 100)
                        {
                            Console.WriteLine($"公雞買{c}隻，母雞買{h}隻，小雞買{i}隻");
                        }
                                
                    }
                }

            }
            
        
        }
    }
}
