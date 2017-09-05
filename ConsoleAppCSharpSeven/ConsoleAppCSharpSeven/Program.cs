using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; //Don't need to write System.Console anymore from c# 6

namespace ConsoleAppCSharpSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello c# 7"); //Don't need to write System.Console anymore

            /*
             * String Interpolation c# 6
             * https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-6#string-interpolation
             */
            DateTime now = System.DateTime.Now;
            int Hours = now.Hour;
            int Minutes = now.Minute;
            Console.WriteLine( $"The time in {Hours}:{Minutes}" );
            //Console.WriteLine("The time in {0}:{1}", hours, minutes);


            /*
             * Local Functions
             * like java inner functions
             * https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7#local-functions
             */
            WriteLine(innerStringTenTimes("Hello"));

            string innerStringTenTimes(string s)
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 10; i++)
                {
                    sb.Append(s);
                }
                return sb.ToString();
            }

            //Pattern Matching
            int[] ints = new int[] { 1, 2, 3 };
            List<Object> ListwithFloats = new List<Object> { 1, 2.0f, 3.14f };
            var subLIst = new List<Object> { 1, 2, 3, new List<Object> { 1, 2, 3 } };
            WriteLine(DiceSum(ints));
            WriteLine(DiceSum2(ListwithFloats));
            WriteLine(DiceSum3(ListwithFloats));
            WriteLine(DiceSum4(subLIst));

            Console.ReadKey();
        }

        public static int DiceSum(IEnumerable<int> values)
        {
            return values.Sum();
        }


        public static int DiceSum2(IEnumerable<object> values)
        {
            var sum = 0;
            foreach (var item in values)
            {
                if (item is int val)
                    sum += val;
                else if (item is IEnumerable<object> subList)
                    sum += DiceSum2(subList);
            }
            return sum;
        }

        public static int DiceSum3(IEnumerable<object> values)
        {
            var sum = 0;
            foreach (var item in values)
            {
                switch (item)
                {
                    case int val:
                        sum += val;
                        break;
                    case IEnumerable<object> subList:
                        sum += DiceSum3(subList);
                        break;
                }
            }
            return sum;
        }

        public static int DiceSum4(IEnumerable<object> values)
        {
            var sum = 0;
            foreach (var item in values)
            {
                switch (item)
                {
                    case 0:
                        break;
                    case int val:
                        sum += val;
                        break;
                    case IEnumerable<object> subList when subList.Any():
                        sum += DiceSum4(subList);
                        break;
                    case IEnumerable<object> subList:
                        break;
                    case null:
                        break;
                    default:
                        throw new InvalidOperationException("unknown item type");
                }
            }
            return sum;
        }

        
    }
}
