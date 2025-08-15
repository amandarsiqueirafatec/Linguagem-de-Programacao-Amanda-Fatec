using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            double v, d, t;
            Console.Write("Informe o tempo:");
            t = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a distância:");
            d = Convert.ToDouble(Console.ReadLine());

            v = d / t;

            Console.WriteLine("A velocidade é " + v);
            Console.WriteLine("A velocidade é {0}", v);


            Console.Read();
        }
    }
}
