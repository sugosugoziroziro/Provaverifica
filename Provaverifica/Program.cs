
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Provaverifica
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string s = "pollo";
            Cerchio c;
            if (Cerchio.TryParse(s, out c))

            {
                Console.WriteLine(c);
            }

            else {Console.WriteLine("ERRORE");}

            Cerchio b = new Cerchio(45);
            Cerchio d = new Cerchio(45);
            Cerchio b=Cerchio d;
            if (b == d)
                { 
                    Console.WriteLine("sono uguali");
                }
            else
                {
                    Console.WriteLine("non sono uguali");
                }





            Console.ReadLine();

        }
    }
}
