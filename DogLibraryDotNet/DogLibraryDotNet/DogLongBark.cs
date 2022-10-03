using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DogLibrary;

namespace DogLibraryDotNet
{
    public class DogLongBark : Dog
    {



        public override string Bark()
        {
            Console.WriteLine("Sleep for 5 seconds.");
            Thread.Sleep(5000);

            return base.Bark();
        }

        public async void BarkAsync()
        {
            await System.Threading.Tasks.Task.Delay(5000);
        }



        public async void BarkTask()
        {
            Task taskA = Task.Run(() => Thread.Sleep(2000));
            Console.WriteLine("taskA Status: {0}", taskA.Status);
            try
            {
                taskA.Wait();
                Console.WriteLine("taskA Status: {0}", taskA.Status);
            }
            catch (AggregateException)
            {
                Console.WriteLine("Exception in taskA.");
            }

        }
    }
}

