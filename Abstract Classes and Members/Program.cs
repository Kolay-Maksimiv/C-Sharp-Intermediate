namespace Abstract_Classes_and_Members
{
    class Program
    {
        static void Main(string[] args)
        {
            //var shape = new Shape(); // abstract class

            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}
