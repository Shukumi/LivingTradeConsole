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
            double GetRandomNumber(double minimum, double maximum)
            {
                Random r = new Random();
                return r.NextDouble() * (maximum - minimum) + minimum;
            }

            var rand = new Random();
            double Pferd = 150;
            double Stein = 3;
            double Stroh = 4;
            int Tag = 0;
            int NextTrendStart = 0;
            string AktuTrend = "";
            ArrayList Items = new ArrayList();
            Items.Add(Pferd);
            Items.Add(Stein);
            Items.Add(Stroh);
            

            void upTrend(ArrayList T)
            {
                Console.WriteLine(10);
                AktuTrend = "up";

            }

            void downTrend(ArrayList T)
            {
                Console.WriteLine(40);
                AktuTrend = "down";

            }

            void riskyTrend(ArrayList T)
            {
                Console.WriteLine(60);
                AktuTrend = "risky";

            }

            ArrayList priceChange(ArrayList T)
            {
                ArrayList Z = new ArrayList();
                switch (AktuTrend)
                {
                    case "up":
                        
                        {
                            double r = GetRandomNumber(1.00,1.1);
                            foreach (double Item in T)
                            { 
                                double newItem = Item * r;
                                newItem = Math.Round(newItem, 2);
                                Z.Add(newItem);
                                Console.WriteLine(Item);
                                Console.WriteLine(newItem);
                            }
                            break;
                        }
                        
                    case "down": 
                        {
                            double r = GetRandomNumber(0.90, 1.00);
                            foreach (double Item in T)
                            {
                                double newItem = Item * r;
                                newItem = Math.Round(newItem, 2);
                                Z.Add(newItem);
                                Console.WriteLine(Item);
                                Console.WriteLine(newItem);
                            }
                            break;
                        }
                        
                    case "risky":
                        {
                            double r = GetRandomNumber(0.75, 1.25);
                            int t = rand.Next(2);

                            foreach (double Item in T)
                            {
                                double newItem = Item * r;
                                newItem = Math.Round(newItem, 2);
                                Z.Add(newItem);
                                Console.WriteLine(Item);
                                Console.WriteLine(newItem);
                            }
                            break;
                        }
                        
                }
                return Z;
            }

            

            void definePriceChange()
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
                
                if (Tag == NextTrendStart)
                { 
                    definePriceChange();
                    NextTrendStart = Tag + 7;
                }
                Tag += 1;
                Console.WriteLine("Tag: " + Tag);



                Items = priceChange(Items);

                int n = 0;
                foreach (double item in Items)
                {
                    n += 1;
                    Console.WriteLine("Item " + n + ": " + item);
                }

                Thread.Sleep(8000);
            }
            Console.ReadLine();


        }
    }
}
