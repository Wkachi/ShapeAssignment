using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAssignment
{
    public class Circle : Shapes
    {

        public int radius { get; set; }

        public double AreaOfCircle()
        {

            return 3.14 * (radius * radius);
        }
    }
}
