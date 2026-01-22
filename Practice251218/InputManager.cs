using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

// delegate의 치명적인 단점을 극복 > event
// delegate를 랩핑한 것이 event
// 아무데서나 호출되지 않도록 보호하는 것
namespace Practice251218
{
    internal class InputManager
    {

        public delegate void OnInputKey(); // 매개변수 0, 반환 0 > 이것을 덮어 씌우는 것
        public event OnInputKey? InputKey;

        // 체이닝
        // InputKey += Test - 구독
        // InputKey += Test - 구독해제

        public void Update()
      { 
       if(Console.KeyAvailable == false)
       {
                return;
       }     
        ConsoleKeyInfo info = Console.ReadKey(); // 누른 키가 무슨 키이다
        
        if(info.Key == ConsoleKey.A)
        {
                // 브로드캐스트
                // delegate를 구독 방식으로 > 단 의존성을 높여서 좋은 방식은 아님
                InputKey();// 이제 이 안에 함수를 걸어줄 수 있다. > 함수의 델리게이트를 걸어줬는데
                           // 이번엔 체이닝 방식으로
        }
        
      } 
    }


    class Program2 {


        delegate int Onclicked(); // 함수 자체를 타입화
                                  // 하지만 delegate 하나만 쓰기엔 치명적인 단점이 있다. 
                                  // 만약에 엄청 중요한 함수라 그 안에서만 호출되어야 한다면?
                                  // 아무대서나 호출이 가능하다는 것이 치명적인 단점

        static int Test()
        {
            Console.WriteLine("C#은 너무 쉬워");
            return 0;
        }


        static int ButtonEvent(Onclicked clickFunc/*어떠한 실행될 함수()*/)
        {
            return clickFunc();
        }

        static void OnInput()
        {
            Console.WriteLine("입력 받음!!!");
        }



        static void Main(string[] args)
        {
            Onclicked d = new Onclicked(Test); // 함수 변수
            int result = ButtonEvent(d); //체이닝 > 객체를 넘겨주지 않고 플러스로 연결하는 방식

            Console.WriteLine();
            //d(); // 이렇게 호출이 가능하다는 것이 단점
            //d();

            InputManager inputManager = new InputManager();
            inputManager.InputKey += OnInput;
            while (true)
            {
                inputManager.Update();
            }
            // 그러면 따로 호출이 불가능하냐?
            

            //OnInput d = new();

            //inputManager.InputKey(); // 이벤트는 외부에서 함수 호출을 막아서 호출이 불가능하다

        }


    }


    class Program3
    {
        delegate void Test(int a, int b);
        Action<int, string> Test2; // >  이 두개는 같다 > 오버로딩된 함수 > 외부에서 호출될 위험이 있다
        // 근데 문제는 event를 걸 수 없다.

        Func<int/*제네릭의 마지막에 있는 타입이 반환 타입이 됨*/> a; // 맨 마지막 부분이 반환형식 , 두 개 이상이면 먼저 것이 매개변수 , 한개만 있으면 매개변수 없이 반환형식만 존재
    }
    // 두번째 : delegate는 결국 함수의 타입화
    // event는 결국 delegate를 래핑해서 다른 클래스로 부터 실행을 보호
    // Action ==delegate와 똑같지만 반환형식이 없는 델리게이트를 말함 > 너무 길어지니까 슈거를 입힌 모양
    // Func ==delegate와 똑같지만 반환형식이 반드시 존재해야하는 델리게이트를 말함

}
