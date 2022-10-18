using System.Runtime.CompilerServices;

namespace RectSquareConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //TODO Write some tests
        }
    }

    class Rectangle
    {
        int Width, Height;

        public int GetHeight()
        {
            return Height;
        }
        public virtual void SetHeight(int height)
        {
            this.Height = height;
        }
        public int GetWidth()
        {
            return this.Width;
        }
        public virtual void SetWidth(int width)
        {
            this.Width = width;
        }

        public bool IsSquare()
        {
            return this.Width == this.Height;
        }

    }

    class Square : Rectangle
    {
        public override void SetWidth(int width)
        {
            this.SetHeight(width);
            base.SetWidth(width);
        }

        public override void SetHeight(int height)
        {
            this.SetWidth(height);
            base.SetHeight(height);
        }
    }
}