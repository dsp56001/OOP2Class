using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCommand
{
    interface IMoveable
    {
        void MoveRight();
        void MoveLeft();
        void MoveUp();
        void MoveDown();
    }
}
