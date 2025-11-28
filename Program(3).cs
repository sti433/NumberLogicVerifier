using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication136
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, i,s;
            i = 0;
            s = 0;
            a = int.Parse(Console.ReadLine());
            while (a > 0)
            {
                s= a % 10;
                i++;
                a= a / 10;
               
            }
            if(i%2==0)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");

               // Console.WriteLine(i);
            
            Console.ReadKey();
        
        }
    }
}
