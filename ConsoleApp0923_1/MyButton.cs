using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0923_1
{
    delegate void ClickDelegate();  //델리게이트 정의
    class MyButton
    {
        public event ClickDelegate Click;   //이벤트 정의

        public void ButtonClick()
        {
            Click();    //이벤트 발생
        }
    }

    class ButtonTest
    {
        static void Main()
        {
            MyButton btn1 = new MyButton();
            btn1.Click += Button1_Click;

            MyButton btn2 = new MyButton();
            btn2.Click += Button2_Click;

            btn1.ButtonClick();
            btn2.ButtonClick();
        }

        private static void Button2_Click() //버튼2 이벤트핸들러
        {
            Console.WriteLine("btn2 버튼 클릭!!");
            //throw new NotImplementedException();
        }

        private static void Button1_Click() //버튼1 이벤트핸들러
        {
            Console.WriteLine("btn1 버튼 클릭!!");
            //throw new NotImplementedException();
        }
    }
}
