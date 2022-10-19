using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {//有一數是四位數，左兩位數字相同，右兩位數字相同，這四位數也是某數平方，求某數

            for(int i = 1; i < 10; i++)
            {
                for(int k=0; k<10; k++)
                {
                    string number = $"{i}{i}{k}{k}";
                    int number1=Convert.ToInt32(number);

                    double number3 = Math.Sqrt(number1);
                    if (int.TryParse(number3.ToString(), out int n4))
                    {
                        Console.WriteLine(number);
                    }
                }
            }                          
            

        
        
        
        
        
        }
    }
}
