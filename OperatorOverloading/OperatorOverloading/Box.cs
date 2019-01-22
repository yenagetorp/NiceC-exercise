using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloading
{
    class Box
    {
        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Volume => Length * Width * Height; 

        public static bool GreaterThan(Box a, Box b)
        {
            return a.Volume > b.Volume;
        }


        public static bool LessThan(Box a, Box b)
        {
            return a.Volume < b.Volume;
        }

        //operator overloading
        public static bool operator >(Box a, Box b)
        {
            return a.Volume > b.Volume;
        }


        public static bool operator <(Box a, Box b)
        {
            return a.Volume < b.Volume;
        }

        //equa and unequal 

        public static bool operator ==(Box a, Box b)
        {
            return (a.Length == b.Length)&&(a.Width==b.Width)&&(a.Height==b.Height);
        }
        public static bool operator !=(Box a, Box b)
        {
            return (a.Length != b.Length) || (a.Width != b.Width) || (a.Height != b.Height);
        }

        public override bool Equals(object obj)
        {
            if (obj is Box)
            {
                return this == (obj as Box);
            }
            else
            {
                return false;
            }
            //if (obj is Box)
            //{
            //    Box box = (obj as Box);//skapa loka variabel
            //    return (Length == box.Length) && (Width == box.Width) && (Height == box.Height);
            //}
            //else
            //{
            //    return false;
            //}
        }

        public override int GetHashCode()
        {
            return Length.GetHashCode() + Width.GetHashCode() + Height.GetHashCode();
        }

    }

}
