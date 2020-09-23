using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0923_1
{
    delegate void Sample(int value);    //델리게이트 형태에 맞춰서 정의

    public class MyClass
    {
        private int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public void Plus(int val)
        {
            number += val;
        }
        public void Minor(int val)
        {
            number -= val;
        }
        public void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        public static void PrintHello(int val)
        {
            for(int i = 0; i < val; i++)
            {
                Console.WriteLine("Hello...{0}", i+1);
            }
        }
    }
    class Delegate1
    {
        static void Main()
        {
            MyClass c1 = new MyClass();
            //직접 메서드 호출
            c1.Plus(100);   //Number -->> 100
            c1.Minor(10);   //Number -->> 90
            c1.Add(21, 13); //34출력
            Console.WriteLine(c1.Number);   //90출력

            Sample s1 = new Sample(c1.Minor);    //델리게이트 메서드 변수 선언
            s1(100);
            Console.WriteLine(c1.Number);   //90 - 100 = -10출력
            s1(-10);    //c1.Number = 0

            s1 += new Sample(c1.Plus);  //델리게이트 메서드 추가
            s1 -= new Sample(c1.Minor); //델리게이트 메서드 제거
            s1(100);    //Minor메서드 호출 후 Plus메서드 호출
            Console.WriteLine(c1.Number);   //c1.Number = 100

            s1 = c1.Minor;
            s1 += c1.Plus;
            s1 += c1.Plus;
            s1(200);    //Minor +
            Console.WriteLine(c1.Number);   //c1.Number = 300

            s1 += MyClass.PrintHello;   //static메서드도 가능
            s1(5);  //Minor(5), Plus(5), Plus(5), PrintHello(5)
            Console.WriteLine(c1.Number);
        }
    }
}
