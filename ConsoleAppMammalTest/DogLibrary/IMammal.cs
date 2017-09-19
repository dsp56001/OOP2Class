using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DogLibrary
{
    interface  IMammal
    {
        int Age { get; }
        string Name { get;  }
        string Sound { get; }
        int Weight { get; }

        void MakeSound();
        void HappyBirthday();
    }
}