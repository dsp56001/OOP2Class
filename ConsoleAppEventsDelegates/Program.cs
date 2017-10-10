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

            Console.ReadKey();

        }

        // Create a method for a delegate.
        public static void LogToConsole(string message)
        {
            System.Console.WriteLine(message);
        }


    }
}
