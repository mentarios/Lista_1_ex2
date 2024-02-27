using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_1_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite um numero");
            int n;
            n = int.Parse(Console.ReadLine());
            if(n >= 20 && n<=100) { Console.WriteLine("está entre 20 e 100"); }
            else { Console.WriteLine("não está entre 20 e 100"); }
        }
    }
}
