namespace ShapesInClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle myRectangle = new Rectangle();
            Rectangle r2 = new Rectangle();

            
            myRectangle.Width = 12;
            myRectangle.Height = 5;
            Console.WriteLine("Perimeter of rectangle: " + myRectangle.CalculatePerimeter());
            Console.WriteLine($"Area: {myRectangle.CalculateArea()}");

        }
    }



}
