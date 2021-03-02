using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleCommand.Commands
{
    public class MoveDownCommand : Command
    {
        public MoveDownCommand()
        {
            this.CommandName = "Move Down";
        }

        public override void Execute(GameComponent gc)
        {
            if (gc is IMoveable)
                gc.MoveDown();
            base.Execute(gc);
        }
    }

    
}
