using System;

namespace ConsoleCommand 
{
    /// <summary>
    /// Fake class for GameComponent it fae moves by having a X and a Y int
    /// </summary>
    public class GameComponent 
    {
        int X, Y;

        public void MoveRight()
        {
            //move right
            X++;
        }

        public void MoveLeft()
        {
            //move left
            X--;
        }

        public void MoveUp()
        {
            //Move up
            Y++;
        }

        public void MoveDown()
        {
            //Move down
            Y--;
        }

        public string About()
        {
            string about = string.Format("location: {0}:{1}", X, Y);
            return about;
        }
    }
    }