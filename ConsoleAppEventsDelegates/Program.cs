using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEventsDelegates
{
    class Program
    {
        public delegate void Log(string message);


        static void Main(string[] args)
        {
            // Instantiate the delegate.
            Log handler = LogToConsole;

            Log anotherHandler = LogToConsole;

            // Call the delegate.
            handler("Hello World");
            anotherHandler("Hello Again!");

            DogEvent dog = new DogEvent();

            dog.PropertyChanged += delegate (object sender, PropertyChangedEventArgs e)
            {
                handler(e.PropertyName);
            };

            dog.Name = "Fido";
            dog.Name = "roover";

            DogDelagate dd = new DogDelagate();
            //dd.Bark(5);
            
            dd.BarkAsync(BarkedMethod);

            Console.WriteLine("Done!!! Press any Key to exit.");

            Console.ReadKey();

        }

        // Create a method for a delegate.
        public static string BarkedMethod(string message)
        {
            Console.WriteLine(message);
            return message;
        }

        // Create a method for a delegate.
        public static void LogToConsole(string message)
        {
            System.Console.WriteLine(message);
        }


    }
}
