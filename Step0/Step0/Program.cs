using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step0
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                    Console.WriteLine("ModernMedical");
                else if (i % 3 == 0)
                    Console.WriteLine("Modern");
                else if (i % 5 == 0)
                    Console.WriteLine("Medical");
                else
                    Console.WriteLine(i);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
