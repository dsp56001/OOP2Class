using System;
using System.Diagnostics;

namespace ConsoleAppInlinePerformance
{
    class Program
    {
        static TimeSpan cts, its;
        static DogInline[] dogsI;
        static Dog[] dogs;

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            int iterations = 10000000;
            int testtimes = 5;
            cts = new TimeSpan();
            its = new TimeSpan();
            for (int i = 0; i < testtimes; i++)
            {
                cts += ConstuctorLoop(sw, iterations);
                its += InlineLoop(sw, iterations);
            }
            Console.WriteLine($"Constructor Average\t{cts/testtimes}");
            Console.WriteLine($"Inline Average\t{its/testtimes}");

        }
        
        private static TimeSpan InlineLoop(Stopwatch sw, int iterations)
        {
            //////////////////////////////////////////////////////////////////////////
            ///Inline
            
            sw.Reset();
            sw.Start();
            DogInline[] dogsI = new DogInline[iterations];
            sw.Stop();
            Console.WriteLine($"Inline[{iterations}]\tDeclare\t\t{sw.Elapsed}");
            its += sw.Elapsed;
            sw.Reset();
            sw.Start();
            for (int i = 0; i < iterations; i++)
            {
                dogsI[i] = new DogInline();
            }
            sw.Stop();
            Console.WriteLine($"Inline[{iterations}]\tInitalize\t{sw.Elapsed}");
            its += sw.Elapsed;
            return its;
        }

        private static TimeSpan ConstuctorLoop(Stopwatch sw, int iterations)
        {
            /////////////////////////////////////////////////////////////////////////////////
            ///Constructor
            sw.Reset();
            sw.Start();
            Dog[] dogs = new Dog[iterations];
            sw.Stop();
            Console.WriteLine($"Constructor[{iterations}]\tDeclare\t\t{sw.Elapsed}");
            cts += sw.Elapsed;
            sw.Reset();
            sw.Start();
            for (int i = 0; i < iterations; i++)
            {
                dogs[i] = new Dog();
            }
            sw.Stop();
            Console.WriteLine($"Constructor[{iterations}]\tInitalize\t{sw.Elapsed}");
            cts += sw.Elapsed;
            return cts;
        }
    }
}
