//#define DOG //<-[Conditional("이 부분이 맨 위에 #define되어야 작동")]
//#define SPEAK


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PracticeUnity20251217
{

    class Test
    {
        //Dog가 실행됐을때 Speak가 실행되게 한다 > Speak가 실행되면 멍멍이 나온다
        //  [Conditional("이 부분이 #define되어야 작동")]
        [Conditional ("DOG")]
        public static void Dog()
        {
           Speak();
        }
        [Conditional("SPEAK")]
        
        public static void Speak()
        {
            Console.WriteLine("멍멍!!");
        }

        [Obsolete]
        public static void TestFunc1() { }
        [Obsolete("하지마")]
        public static void TestFunc2() { }

        [Obsolete("하지말라면 하지마", true)]
        public static void TestFunc3() { }


        // 채용공고 - 외부 DLL(외부에서 만든 꽁꽁 싸맨 프로그램, 볼 수 없게 만든) 사용해보신 경험이 있으신 분
        // .NET CORE도 dll이다 > 못 보게 하려고
        // 이걸 사용하는 방법
        // 특정 dll이 호출이 안되는 경우
        //[DllImport("dll의 주소")]
        [DllImport("User32.dll")] //윈도우의 dll
        public static extern int MessageBox(int h, string s, string m, int type);
        // extern int MessageBox( , 내용 , 제목 , )
        // 해당 클래스까지만 사용 가능


    }




    class Knight2
    {

        //private int hp; // 다른 클래스에서 얘는 수정하면 안됨
                             //얘를 그냥 읽어올 수만 있게

        public int HP // 이 둘을 합한 것이 프로퍼티
        {
            get{ return HP; }
            // C#7.0부터 가능한 문법 > set을 private으로 막을 수 있다.
            private set { HP = value; }
        }

        // 컴파일러 -> IL코드로 변환 : 하는 행동 > 내부적으로 함수를 만든다
        // -> get_PropertyHP() / set_PropertyHP() >> 내부에서 저 두 함수를 만들어 줄 것이다.
        // 뿐만 아니라 PropertyHP라는 변수도 하나 만들어진다.
        //protected void SetHp(int hp) // Setter 함수
        //{
        //    this.hp = hp;
        //}
        //public int GetHp() //Getter 함수
        //{
        //    return this.hp;
        //}

        void Test()
        {
            int a = 10;
        }

    }



    
    internal class New
    {
        static void Main()
        {
            Knight2 k = new Knight2();
            int a = k.HP;

            Test.Dog();

            Test.TestFunc1(); // 디프리케이티드 > 바꿔달라 요청 하는 것
            Test.TestFunc2(); // 추가적인 메시지
            //Test.TestFunc3();  // true까지 오면 에러까지 발생

            Test.MessageBox(0, "hello world", "Test", 0);
            
        }

    }
}
