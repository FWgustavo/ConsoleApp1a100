using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1a100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 1;
            while (cont <= 100) 
            {
                Console.WriteLine(cont); 
                cont++;
            }
            Console.ReadKey();
        }
    }
}
