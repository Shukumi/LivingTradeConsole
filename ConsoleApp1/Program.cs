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
            var rand = new Random();
            double Pferd = 150;
            double Stein = 3;
            double Stroh = 4;
            int Tag = 0;
            int NextTrendStart = 0;
            string AktuTrend = ""
            ArrayList Items = new ArrayList();
            Items.Add(Pferd);
            Items.Add(Stein);
            Items.Add(Stroh);
            

            void upTrend(ArrayList T)
            {
                Console.WriteLine(10);
                NextTrendStart = Tag + 7;


            }

            void downTrend(ArrayList T)
            {
                Console.WriteLine(40);
                NextTrendStart = Tag + 7;

            }

            void riskyTrend(ArrayList T)
            {
                Console.WriteLine(60);
                NextTrendStart = Tag + 7;

            }




            void priceChange(ArrayList T)
            {
                int r = rand.Next(101);
                Console.WriteLine("Hey" + r);
                switch (r)
                {
                    case int n when (n < 30):
                        upTrend(Items);
                        break;

                    case int n when (n < 70 && n >= 30):
                        riskyTrend(Items);
                        break;

                    case int n when (n >= 70):
                        downTrend(Items);
                        break;
                }

            }

           while(true)
            {
                Tag += 1;
                if (Tag == NextTrendStart)
                { 
                  priceChange(Items);
                }
                //foreach (double item in Items) {
                //    Console.WriteLine(item);
                //}
                
                Thread.Sleep(5000);
            }
            Console.ReadLine();


        }
    }
}
