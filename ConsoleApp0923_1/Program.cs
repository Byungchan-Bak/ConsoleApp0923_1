using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0923_1
{
    class Singer : IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int AlbumCnt { get; set; }

        public Singer(string name, int age, int albumCnt)
        {
            Name = name;
            Age = age;
            AlbumCnt = albumCnt;
        }

        public override string ToString()
        {
            return $"{Name} - {Age}세 - {AlbumCnt}집 앨범";
        }

        public int CompareTo(object obj)    //정렬기준을 선정하기 위한 Comparable Interface정의
        {
            //나이가 크면 1, 작으면 -1, 같으면 0
            Singer sing = obj as Singer;
            if (this.Age < sing.Age)    return 1;
            else if (this.Age > sing.Age)   return -1;
            else
                return 0;
            //throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Singer[] singers = new Singer[5] {
                    new Singer("아이유", 28, 8),
                    new Singer("자우림", 40, 5),
                    new Singer("거미", 35, 5),
                    new Singer("이승철", 50, 15),
                    new Singer("태진아", 65, 5)
            };

            foreach (Singer sing in singers)
            {
                Console.WriteLine(sing.ToString());
            }

            Array.Sort(singers, );
            Console.WriteLine("======================================");
            Console.WriteLine();
            foreach (Singer sing in singers)
            {
                Console.WriteLine(sing.ToString());
            }
        }
    }
}
