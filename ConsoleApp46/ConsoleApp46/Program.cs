using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp46
{
    class Program
    {
        public static void Main()
        {
            List<double> tallista = new List<double>();
            tallista.Add(4.1);
            tallista.Add(8.5);
            tallista.Add(6.8);
            tallista.Add(2.5);
            tallista.Add(1.6);

            tallista.RemoveAt(3);

            foreach (int element in tallista)
                Console.WriteLine(element);
        }
    }
}