using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double n2;
            double n3;
            double n4;
            double result;
            double result2;

            Console.WriteLine("valor n1");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("valor n2");
            n2=double.Parse(Console.ReadLine());

            Console.WriteLine("valor n3");
            n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("valor n4");
            n4 = double.Parse(Console.ReadLine());

            result = n1 + n2 + n3 + n4;

            Console.WriteLine("valor de result é {0}", result);

            result2 = result / 4;
            Console.WriteLine("valor da media é {0}", result2);






        }
    }
}
