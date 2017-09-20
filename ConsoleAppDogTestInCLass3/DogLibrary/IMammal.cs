using System;
using System.Collections.Generic;
using System.Text;

namespace DogLibrary
{
    public interface IMammal
    {
        int Age { get; }
        int Weight { get; }

        string Name { get; }

        string Sound { get; set; }

        string MakeSound();
        string MakeSound(int HowMany);

        void HappyBithday();

    }
}
