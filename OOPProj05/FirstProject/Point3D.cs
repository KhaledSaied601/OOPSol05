using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProj05.FirstProject
{
    internal class Point3D : IComparable<Point3D>, ICloneable
    {
        #region 1 - Define 3D Point Class and the basic Constructors (use chaining in constructors).

        public Point3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        #endregion


        #region 2 - Override the ToString Function 
        public override string ToString()
        {
            return $"Point Coordinates:({X},{Y},{Z})";
        }

        #endregion

        #region 6- Implement ICloneable interface to be able to clone the object. To implement more than one interface.class Point3D : IComparable, ICloneable

        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }

        #endregion

        #region 5- Define an array of points and sort this array based on X & Y coordinates.

        public int CompareTo(Point3D? other)
        {
            if (other == null)
            {

                return 1;

            }
            int xComp = X.CompareTo(other.X);

            if (xComp != 0)
            {
                return xComp;
            }
            return Y.CompareTo(other.Y);

        }
        #endregion
    }
}
