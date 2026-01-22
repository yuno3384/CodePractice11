using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice251223
{
    class Exception
    {
        // 예외 처리
        // try(뭔가를 시도) ~~ catch(에러가 나면 잡아) ~~

        
        class TestException : Exception 
        { 
            
        
        }
        [AttributeUsage(AttributeTargets.Class)]
        class TestAttribute : Attribute
        {
            public TestAttribute(string val) { Value = val; }
            
            public string Value { get; set; }

        }
        [TestAttribute("메모")] //dll은 주석이 다 날아감 > metadata로 남기는 것
        // 주석을 대신해서 무언가를 남길때 사용
        // 그 외 사용처도 있지만 어차피 잘 안씀
        class Test { }

        class Player
        {

        }

        class Knight : Player
        {
            public int hp;
        }

        class Mage : Player
        {
            public float mp;
        }

        static void Makin()
        {

            //int a = 0;
            //int b = 0;
            //int c = a / b; // DevidedByZeroException

            Player player = new Knight(); // 이렇게는 가능
            // 근데 그 타입을 바꾼다면??
            Mage mage = (Mage)player;// 아주아주 안 좋은 습관, 아주아주 안 좋은 코드 // InvalidCastException
            mage.mp = 10.3f; // 이 문제를 해결하기 위해 나온 것이 is as
            // is : 명시적 형변환을 했을 경우 그 타입이 맞으면 bool을 반환

            if(player is Mage) // 타입비교 //getType으로는 가능하지만...
            {
                Mage mage2 = (Mage)player;
            }
            else
            {
                Console.WriteLine("메이지가 아닙니다");
            }
            if (player is Knight) // 타입비교 //getType으로는 가능하지만...
            {
                Knight knight = (Knight)player;
            }
            else
            {
                Console.WriteLine("메이지가 아닙니다");
            }

            Mage mage3 = player as Mage;
            // as : 명시적 형변환을 했을 경우 그 타입이 맞으면 그 형변환한 타입을 반환

            if(mage3 != null)
            {
                Console.WriteLine("Mage");
            }
            else
            {
                Console.WriteLine("Not Mage");
            }


                try
                {
                    Program p = null;
                    // 크래쉬 났다. >> 터졌다
                    int a1 = 0;
                    int b1 = 0;
                    int c = a1 / b1;

                    if(1 > 2)
                    {
                        //throw new TestException();// 예외를 만들어서 던진다
                    }
                }
                catch (System.Exception ex)
                 {

                    Console.WriteLine(ex);
                    //if(ex.GetType )
                    if(ex is DivideByZeroException)
                    {
                        Console.WriteLine($"{ex} 0으로 나눈 에러다");
                    }
                     if( ex is TestException)
                    {
                        Console.WriteLine("에러 발생");
                        // 게임에서는 이걸 쓰면 안된다 에러가 생겼는데 그냥 흘러가면 > 대참사
                        // 서버를 터뜨리고 다른 서버로 대체 시키지 
                        // web은 아니다 예외가 생겨도 작동해야하기 때문에
                    }

                 }
                finally
                {
                    Console.WriteLine("예외처리 끝"); // try가 있어도 없어도 무조건 실행됨
                }
            // try(에러가 날 수 있는 것) ~~ catch(에러를 확인하여 처리) ~~ finally(그러든 말든 실행)


            int a = 30;
            float? b = a as float?; //nullable로는 가능


            // xml 주석은 봐도 되고
            // linq는 일부 게임사에서 사용안한다 > 가독성이 안 좋아서
            // 계속 람다에 람다에 가독성이 안 좋다
            // 메소드 체이닝
            // this생성자로 다른 생성자 호출하기 > 이거 잘 모르는 분도 계심 > 잘 안씀
            // 튜플 많이 씀
            // 어트리뷰트 > 리플렉션
            // 실드 상속구조 상 나 이하로는 못 쓰게 > 잘 안씀
            // 딕셔너리 : 자료구조의 일종 KEY VALUE
            // 해쉬 셋
            // 응용력을 키우는 법은 많이 만드는 것이다
            // C#의 크롤러를 이용해서 프로그램 개발도 해봤고...
            // 무조건 완성은 시켜봐라
            // 그것이 구리더라도.. 덮으면 그냥 시간 날린 꼴이다
            // 시작 - 중간 - 끝
            // 허접하더라도 그걸 해보는 거다 >> 그것이 steam해봤냐고 물어보는 것

        }

    }
}
