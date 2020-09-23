using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*이벤트 사용방법
 * 1. 델리게이트 정의
 * 2. (접근제한자) (타입) (델리게이트) (이벤트) 순서대로 이벤트 정의
 * 3. 이벤트 발생
 * 4. Main함수에서 이벤트 핸들러 등록
 */
namespace ConsoleApp0923_1
{
    delegate void FindDelegate(int prime);  //이벤트 이용을 위한 델리게이트 정의
    class MyPrime
    {
        public event FindDelegate FindPrime; //(Delegate Name) (Event Name) -->> 이벤트 정의
        public void PrimeFormula(int maxNum)
        {
            //List<int> num = new List<int>();  //컬렉션
            //int[] num = new int[maxNum];
            //int cnt= 0;
            for(int i = 2; i <= maxNum; i++)
            {
                bool bPrime = true;
                for(int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        bPrime = false;
                        break;
                    }
                }
                //1. break가 되어 내려온 경우
                //2. 소수가 아닌 경우
                if (bPrime)
                {
                    FindPrime(i);   //이벤트 발생
                    /*
                    num[cnt] = i;
                    cnt++;
                    //num.Add(i);   //데이터 입력할 때마다 추가 할당
                    Console.WriteLine(i);
                    */
                }
            }
        }
    }
    class MyPrimeTest
    {
        static void Main()
        {
            Console.Write("소수를 구하고 싶은 범위의 최대 값을 입력 : ");
            int maxNum = int.Parse(Console.ReadLine());
            MyPrime pi = new MyPrime();
            pi.PrimeFormula(maxNum);
            pi.FindPrime += new FindDelegate(PrintPrime);   //-->>1.0문법 이벤트 핸들러 등록
            //pi.FindPrime += PrintPrime;  //-->> 2.0문법
           
        }

        private static void PrintPrime(int prime)   //델리게이트와 같은 유형의 이벤트 핸들러
        {
            Console.WriteLine("이벤트 출력 -->> " + prime);
        }
    }
}
