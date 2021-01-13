using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class program
    {

        static void Main(string[] args)
        {
            Bil p = new Bil();
            p.setTillverkare("Volvo");
            p.setModell("V70");
            p.setYear(1996);
            p.setVikt(2200);

            Console.WriteLine("Tillverkare: " + p.getTillverkare());
            Console.WriteLine("Modell: " + p.getModell());
            Console.WriteLine("År: " + p.getYear());
            Console.WriteLine("Vikt: " + p.getVikt() + " kg");
        }
    }
}