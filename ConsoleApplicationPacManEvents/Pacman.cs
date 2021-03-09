using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplicationObserver
{
    public class Pacman 
    {

        PacState myState;

        public event EventHandler<PacManEventArgs> StateChanged;

        public PacState MyState
        {
            get { return myState; }
            set
            {
                this.myState = value;
                StateChanged?.Invoke(this, new PacManEventArgs(this.myState));
            }
        }

        public Pacman()
        {
            
            MyState = PacState.Spawning;
            
        }

        
        
    }



    public enum PacState { Spawning, Chomping, SuperChomp, Dying };

    public class PacManEventArgs : EventArgs
    {
        public PacState State { get; }

        public PacManEventArgs(PacState state)
        {
            this.State = state;
        }

        
    }
}
