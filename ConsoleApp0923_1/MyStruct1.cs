using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0923_1
{
    struct Point3D
    {
        public int x, y, z;

        public Point3D(int x, int y, int z) //기본생성자 사용불가
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return $"(x, y , z) = ({x}, {y}, {z})";
        }
    }

    class MyStruct1
    {
        static void Main()
        {
            Point3D point1;
            point1.x = 20;
            point1.y = 10;
            point1.z = 5;
            Console.WriteLine(point1.ToString());

            Point3D point2;
            point2.x = 13;
            point2.y = 21;
            point2.z = 5;
            Console.WriteLine(point2.ToString());

            Point3D point3 = new Point3D(3, 5, 13);
            Console.WriteLine(point3.ToString());

            Point3D point4 = point3;
            point4.z = 900;
            Console.WriteLine(point3.ToString());   //
            Console.WriteLine(point4.ToString());   //
        }
    }
}
