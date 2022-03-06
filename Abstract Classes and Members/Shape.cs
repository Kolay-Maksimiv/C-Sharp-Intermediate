using System;

namespace Abstract_Classes_and_Members
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Heigth { get; set; }

        public abstract void Draw();
        public void Copy()
        {
            Console.WriteLine("Copy shape into clipboard.");
        }

        public void Select()
        {
            Console.WriteLine("Select rhe shape.");
        }
    }
}
