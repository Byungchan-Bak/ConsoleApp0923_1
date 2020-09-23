using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0923_1
{
    class CPoint3D
    {
        public int x, y, z;

        public CPoint3D(){ }
        public CPoint3D(int x, int y, int z) //기본생성자 사용불가
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
    class MyClass1
    {
        static void Main()
        {
            /*
            CPoint3D point1;
            point1.x = 20;
            point1.y = 10;
            point1.z = 5;
            Console.WriteLine(point1.ToString());

            CPoint3D point2 = new CPoint3D;
            point2.x = 13;
            point2.y = 21;
            point2.z = 5;
            Console.WriteLine(point2.ToString());
            */
            CPoint3D point3 = new CPoint3D(3, 5, 13);
            Console.WriteLine(point3.ToString());
            
            CPoint3D point4 = point3;
            point4.z = 900;
            Console.WriteLine(point3.ToString());   //

            Console.WriteLine(point4.ToString());   //
        }
    }
}
