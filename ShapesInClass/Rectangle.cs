using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ShapesInClass
{
    internal class Rectangle
    {
        //Attributes (or feilds)
        public double Width;
        public double Height;
       
        //Constructors
        public Rectangle()  //Default Constructor
        {
            Width = 0;
            Height = 0;
        }

        public Rectangle(double h, double w) //Paramaterized constructor
        {
            Width = w;
            Height = h;
        }


        public Rectangle(Rectangle r) //Copy Constructor
        {
            Width = r.Width;
            Height = r.Height;
        }

        //Methods

        //Calculate Area
        public double CalculateArea()
        {
            return Width * Height;
        }

        //Calculate Perimeter
        public double CalculatePerimeter()
        {
            return (2 * Width) + (2 * Height);
        }


    }
}
