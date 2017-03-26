using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article2
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();

            Console.WriteLine("Enter product index: ");
            int a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("There is folowing information under index {0}: ", a);
            Console.WriteLine(store[a]);

            Console.WriteLine("Enter product name: ");
            string b = Console.ReadLine();
            Console.WriteLine("There is folowing information under name {0}: ", b);
            Console.WriteLine(store[b]);
            Console.ReadKey();
        }
    }
}
