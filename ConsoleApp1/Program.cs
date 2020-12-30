using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Pferd = 150;
            double Stein = 3;
            double Stroh = 4;
            ArrayList Items = new ArrayList();
            Items.Add(Pferd);
            Items.Add(Stein);
            Items.Add(Stroh);

            void priceChange(ArrayList T)
            {
                foreach (double item in Items)
                {
                    Console.WriteLine(item);
                }


           while(true)
            { 

            foreach (double item in Items) {
                Console.WriteLine(item);
            }

            Thread.Sleep(2000);
            }
            Console.ReadLine();


        }
    }
}
