using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationObserver
{
    public class Ghost 
    {
        Pacman pacSub;
        
        public Ghost(Pacman pac)
        {
            this.pacSub = pac;
            this.pacSub.StateChanged += PacManUpdate;
        }
        
        
        public void PacManUpdate(object sender, PacManEventArgs e)
        {
            Console.WriteLine(string.Format("{0} state is {1}", sender, e.State));
        }
        

        public void Die()
        {
            this.pacSub.StateChanged -=PacManUpdate;
        }
    }
}
