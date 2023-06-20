using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAssignment
{
    public class Rectangle : Shapes
    {
     


        public int CalculateSurface() 
        { 
            return Height * Width;
        }
    }
}
