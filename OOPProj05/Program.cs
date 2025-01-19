using OOPProj05.FirstProject;
using OOPProj05.SecProject;
using OOPProj05.ThirdProject;

namespace OOPProj05
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region First Project


            #region 2 - Override the ToString Function to produce this output


            //Point3D P = new Point3D(10, 10, 10);

            //Console.WriteLine(P);

            #endregion



            #region 3 - Read from the User the Coordinates for 2 points P1, P2 (Check the input using try Pares, Parse, Convert).

            //Console.WriteLine("Input First Point");

            //int x1;
            //int y1;
            //int z1;
            //bool flag = false;

            //do
            //{
            //    Console.WriteLine("Enter X1");
            //    flag = int.TryParse(Console.ReadLine(), out x1);

            //}
            //while (flag == false);

            //flag = false;
            //do
            //{
            //    Console.WriteLine("Enter Y1");
            //    flag = int.TryParse(Console.ReadLine(), out y1);

            //}
            //while (flag == false);
            //flag = false;
            //do
            //{
            //    Console.WriteLine("Enter Z1");
            //    flag = int.TryParse(Console.ReadLine(), out z1);

            //}
            //while (flag == false);


            //Point3D p1 = new Point3D(x1, y1, z1);

            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Input Second Point");

            //int x2;
            //int y2;
            //int z2;


            //try
            //{
            //    Console.WriteLine("Enter X2");
            //     x2 = int.Parse(Console.ReadLine()??"0");
            //    Console.WriteLine("Enter Y2");
            //     y2 = int.Parse(Console.ReadLine()??"0");
            //    Console.WriteLine("Enter Z2");
            //     z2 = int.Parse(Console.ReadLine() ?? "0");


            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //    x2 = 0;
            //    y2 = 0;
            //    z2 = 0;
            //}
            //Point3D p2 = new Point3D(x2,y2, z2);    

            //Console.WriteLine(p1);
            //Console.WriteLine(p2);

            #endregion


            #region 4 -    Try to use == If(P1 == P2)   Does it work properly? 

            // It Dosn't Work 


            //Console.WriteLine(p1==p2);


            #endregion


            #region 5- Define an array of points and sort this array based on X & Y coordinates.



            //Point3D[] points = new Point3D[] { new Point3D(10, 50, 10), new Point3D(10, 30, 30), new Point3D(20, 20, 20)  };

            //Array.Sort(points);

            //for (int i = 0; i < points.Length; i++)
            //{
            //    Console.WriteLine(points[i]);
            //}


            #endregion

            #region 6- Implement ICloneable interface to be able to clone the object. To implement more than one interface.class Point3D : IComparable, ICloneable


            //Point3D p = new Point3D(10, 50, 20);

            //Point3D p2 = (Point3D)p.Clone();



            #endregion

            #endregion

            ///////////////////////////////////////////////////////////////////////////////////////////////////////


            #region Second Project

            #region 1 - Call each method in Main ().

            //Maths m = new Maths();

            //Console.WriteLine(m.Add(10, 10));
            //Console.WriteLine(m.Subtract(10, 10));
            //Console.WriteLine(m.Multiply(10, 10));
            //Console.WriteLine(m.Divide(10, 10));
            #endregion

            #region 2 - Modify the program so that you do not have to create an instance of class to call the four methods.
            //Console.WriteLine(Maths.Add(10, 10));
            //Console.WriteLine(Maths.Subtract(10, 10));
            //Console.WriteLine(Maths.Multiply(10, 10));
            //Console.WriteLine(Maths.Divide(10, 10));
            #endregion


            #endregion




            //////////////////////////////////////////////////////////////////////////////////////////////////////

            #region Third Project

            #region 3- Define All Required Constructors to Produce this output

            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1);
            //Duration D2 = new Duration(3600);
            //Console.WriteLine(D2);
            //Duration D3 = new Duration(7800);
            //Console.WriteLine(D3);
            //Duration D4 = new Duration(666);
            //Console.WriteLine(D4);
            #endregion



            #region 4- Implement All required Operators overloading to enable this Code


           // D3 = D1 + D2;
           // D3 = D1 + 7800;
           // D3 = 666 + D3;
           // D3 = ++D1;
           // D3 = --D2;
           // D1 = D1 - D2;

           // if (D1 > D2)
           // {
           //     Console.WriteLine("True");
           // }
           // else { Console.WriteLine("False"); } 
           // if (D1 <= D2)
           // {
           //     Console.WriteLine("True");
           // }
           // else { Console.WriteLine("False"); }

           // if(D1) { Console.WriteLine("True"); }

           //DateTime Obj = (DateTime)D1;

            #endregion




            #endregion






        }
    }
}
