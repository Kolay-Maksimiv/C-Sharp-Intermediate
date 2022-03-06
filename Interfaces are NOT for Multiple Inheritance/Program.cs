using System;

namespace Interfaces_are_NOT_for_Multiple_Inheritance
{
    public class TextBox: UiControl, IDraggable, IDroppable
    {
        public void Drag()
        {
            throw new NotImplementedException();
        }
        public void Drop()
        {
            throw new NotImplementedException();
        }
    }
    public class UiControl
    {
        public string Id { get; set; }
        public Size Size { get; set; }
        public Position Position { get; set; }

        public virtual void Draw()
        {

        }
        public void Focus()
        {
            Console.WriteLine("Received focus.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
