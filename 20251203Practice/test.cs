using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20251203Practice
{
    internal class test
    {
        //    New Scene은 File에서 해도 되고, Cntl+n으로도 된다
        //    GameObject에 MonoBehaviour는 inspector에 넣어도 되고,
        //    Hierachy에서 넣어도 되고, Add Component에 넣어도 된다


        //메인 루프 :

        // 초기화

        // 업데이트
        //무한루프
        // input
        //로직
        // 랜더링

        // 유니티도 이와 동일

        // 게임 프레임: 무한루프를 1초에 몇번 도냐 > 1초동안 몇번 아래 행동을 반복
        // 1초에 60번 돌면 : 60프레임
        // 1초에 200번 돌면 : 200프레임

        // 프레임 드랍 : 점점 도는 것이 느려지는 것

        // 클래스
        // 가위바위보게임
        // Main함수도 Stack에 올린다
        // 런 타임 : 실행중에
        // 컴파일 타임 : 빌드되는 중에

        // 커널공간 - 운영체제
        // 커널공간이 RAM에 지시 > 명령
        // 운영체제를 통해서 프로그램을 실행할 공간이 잡힌다
        // 사용자 공간 : 코드 > 데이터 > 힙(프로그램이 실행되는 과정에서 계속 늘어남) > 스택(일정부분 크기가 정해져있음)
        //          낮은<------------------------------------------------------------------------------->높은
        // 크기는 고정되어있고, 사용이 끝나면 사라진다
        // 스택오버플로우 : 스택의 영역을 초과했다. > 스택은 늘어나지 않는다
        // 참조 전달 / 값 전달
        // ref
        static void Test(int a) // a는 값이 필요해요
        {
            a++;/*a의 값인 99라는 값을 연산하시오*/
        }

        static void Add(ref int a) //ref a는 주소값이 필요해요
        {
            a++; /*0xfff999s의 주소 속 값을 가지고 연산하시오 */
        }

        // 값형식 - 대부분의 기본 형식
        // 참조형식 - 클래스 배열 등....
        // 이 두형식을 사용하여 함수의 인자로 사용할 시 차이점이 있다
        // 값 형식 > 값 전달(값 복사 - 짝퉁 , 사본)
        // 참조 형식 > 참조 전달(주소 공유 - 진퉁 , 진본)
        // ref가 붙게 되면 값 형식 조차도 값 전달로 바뀌게 된다
        // 왠만하면 값 전달로 하길바람.
        // 정 필요하면 주소값 전달하더라도...

        //static void Swap(ref int a , ref int b) 
        //{

        //    //a = b; // a에 b값으로 받는다.
        //    //b = a; // b는 a값을 넣어도, b값이므로 오류>  임시 저장소가 필요 

        //    int temp = a; //임시 저장소
        //    a = b; // a에 b값으로 받는다.
        //    b = temp;

        //}
        //static void Swop(int a, int b)
        //{
        //    // 임시 저장소가 필요 
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}


        //static void Swap(out int a, out int b)
        //{

        //    //a = b; // a에 b값으로 받는다.
        //    //b = a; // b는 a값을 넣어도, b값이므로 오류>  임시 저장소가 필요 

        //    //int temp = a; //임시 저장소
        //    //a = b; // a에 b값으로 받는다.
        //    //b = temp;

        //}
        // ref의 짝꿍 => out : 한꺼번에 리턴받기 좋은 방식
        // 사용법이 다르다 > out은 값을 반드시 쓰고 나서 읽을 수 있다.
        // 본래 타입은 하나씩 밖에 못 받는다. > 그래서 out이 있다.
        // 한꺼번에 리턴을 받는 방법
        //ref는 처음부터 값이 있어야 한다 , 반드시 초기화를 해야한다.
        /*
                                [ref]       [out]
         주소전달방식이냐?          [O]        [O]
         함수안에서 읽기 가능       [O]        [X]
         함수 호출전 반드시 초기화  [ O ]        [X]
         함수 내에서 반드시 값쓰기  [ X ]        [O]

         */
        //static void OpenSrankBox(out int gold, out int exp, out string item)
        //{
        //    gold = 0;
        //    exp = 50;
        //    item = "포션";
        //}
        //// 오버로딩 : 함수 이름 재사용 > 매개변수의 '갯수' 아니면 '형식'만 달리 해주면 된다(**면접문제 필수)
        //static void Add(int a) // a는 값이 필요해요
        //{
        //    a++;
        //}

        //static void Add(int a, int b) //ref a는 주소값이 필요해요
        //{
        //    int temp = a + b;
        //}

        //// 선택적 매개변수 > 원래는 각 매개변수마다 값을 따로 넣어야 하는데 매개변수에 값을 대입해 놓으면
        //// 원래는 대입해야하지만, 대입 안해도 그것을 그 처음 선언한 값을 사용한다 > 기본값 미리 지정
        //static void Add(int a, int b, int c = 10) //ref a는 주소값이 필요해요
        //{
        //    int temp = a + b;
        //}
        //// 게임을 예시로 들자면
        //static void Attack(int attackAmount = 10) //ref a는 주소값이 필요해요
        //{
        //    int monsterHp =100;
        //    monsterHp -= attackAmount; // 어차피 값이 정해져 있다면 그냥 이렇게 미리 정해두면
        //}
        // 아니면 매개변수가 너무 많아서 > 일일이 넣기 어려워질때 > 일부값을 미리 지정해서 사용

        // 좋은 점
        //static void Add(int a, int b, int c = 0, int d = 0, int e = 1) //ref a는 주소값이 필요해요
        //{
        //    Console.WriteLine(a);
        //    Console.WriteLine(b); Console.WriteLine(a); Console.WriteLine(a); Console.WriteLine(a);
        //}

        // 유니티에서도 레이트레이싱(무언가 맞았을때 정보) > 한꺼번에 받는 방법 > out키워드로 받는 방식으로 되어있다

        //int a = 10;// a는 10이다
        int a/*0xfff999s*/ = 99; //a는 99이다

        //Test(a/*a의 값인 99라는 값*/);// 그냥 10이라는 값만 준 것 > 끝나면 사라지는 값

        //Console.WriteLine(a/*a의 값 자체*/);// 이거 10일까 11일까? > 10이 나온다
        //                                      // 이거 99일까 100일까 > 99이다

        //    Add(ref a/*0xfff999s*/);// 이건 a의 주소값을 준 것 > a속 값을 바꾼다

        //Console.WriteLine(a/*a의 값*/);// 이거 10일까 11일까? > 11이 나온다
        //                                  // 이거 99일까 100일까 > 100이다

        ////x와 y의 값을 서로 바꿔라 > 값이 바뀌어도 원본에는 변경이 없음 > ref필요
        //int x = 10;
        //int y = 20;
        //Swap(ref x , ref y );// 이상태로 값이 바뀌려면? 진본을 바꾸겠다 > 주소값을 바꾸겠다. > ref필요
        //Console.WriteLine($"{x},{y}");

        ////out
        //int gold;
        //int exp;
        //string item;

        //int a = 10;
        //int b = 20;
        //int c = 30;
        //// 순서가 뒤죽박죽이어도 대입이 된다 > 쓸 일은 없어것 같지만
        //Add(a, b, e: 4, d: 3, c: 30);
        /*
         static void Main() // 아 여기서부터 시작되는구나...
        {
        //int a = 10;// a는 10이다
         //int a/*0xfff999s = 99;*/ //a는 99이다

        //    Test(a/*a의 값인 99라는 값*/);// 그냥 10이라는 값만 준 것 > 끝나면 사라지는 값

        //Console.WriteLine(a/*a의 값 자체*/);// 이거 10일까 11일까? > 10이 나온다
        //                                      // 이거 99일까 100일까 > 99이다

        //    Add(ref a/*0xfff999s*/);// 이건 a의 주소값을 준 것 > a속 값을 바꾼다

        //Console.WriteLine(a/*a의 값*/);// 이거 10일까 11일까? > 11이 나온다
        //                                  // 이거 99일까 100일까 > 100이다

        ////x와 y의 값을 서로 바꿔라
        //int x = 10;
        //int y = 20;
        //Swap(ref x , ref y );
        //Console.WriteLine($"{x},{y}");

         
         

    }
}
