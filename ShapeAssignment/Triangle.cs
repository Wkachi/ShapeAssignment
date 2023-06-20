using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAssignment
{
    public class Triangle : Shapes
    {
      


        public  int CalculateSurface()
        {
            return (Height * Width) / 2;
        }

    }
}
