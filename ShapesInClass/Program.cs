namespace ShapesInClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle myRectangle = new Rectangle();
            Rectangle r2 = new Rectangle(4, 6);
            
            myRectangle.Width = 12;
            myRectangle.Height = 5;
            Rectangle r3 = new Rectangle(myRectangle);

            Console.WriteLine("Perimeter of r1: " + myRectangle.CalculatePerimeter());
            Console.WriteLine($"Area: {myRectangle.CalculateArea()}");


            Console.WriteLine($"r2 width: {r2.Width}, r2 height: {r2.Height}");
            Console.WriteLine("Perimeter of r2: " + r2.CalculatePerimeter());
            Console.WriteLine($"Area: {r2.CalculateArea()}");

            Console.WriteLine($"r3 width: {r3.Width}, r3 height: {r3.Height}");
            Console.WriteLine("Perimeter of r3: " + r3.CalculatePerimeter());
            Console.WriteLine($"Area: {r3.CalculateArea()}");



        }
    }



}
