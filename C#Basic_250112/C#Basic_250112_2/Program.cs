namespace C_Basic_250112_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 솔루션 파일 > 프로젝트를 여러개 만들 수 있다
            // 시작 프로젝트로 설정 > 콘솔에서 시작될 프로젝트가 무엇인지 정하는 것
            // 만약에 동시에 시행되어야 한다면? > 시작 프로젝트 구성

            // CPU -> RAM -> SSD / HDD
            // 연산 > 주기억 > 보조기억
            // 요리사 > 조리대 > 창고
            //     프로세스 <- 프로그램 

            //타입
            //  int ,   float,    string,   bool
            // 정수형, 부동소수점형, 문자열형,  논리형
            // 099-11  3.14 0.0f "shshdshd" true/false
            //uint / int : unsigned -> 2의 보수법

            int a = 10;
            // = 대입 연산자 : 오른쪽에 있는 것을 왼쪽에 넣겠다
            int b = a;
            // 오른쪽에 있는 a의 값을 b에 넣겠다

            // 변수 선언, 대입, 값을 꺼내는 것
            int a5 = 10;//초기화
            int b5 = a; // 대입
            int c5; // 선언

            //이진법
            //10 = 1010(2)
            //     8421
            // 8 + 2 10
            //16진법
            // 100 > 0110 0100
            //        6432    4  
            //       8421 8421
            //          6    4(16) = 100

            //2의 보수법을 통한 signed를 표기하는 법(pass)

            //변수에 2진수 담는 법
            int d = 0b01100100;// 0b: 2진수
            int f = 0x64; //0x : 16진수


            //float : 실수형
            //값을 입력할 때 f를 넣어야한다
            // 현재 double이 기본이므로 d는 안붙인다
            // 참고로 리트럴접미사는 대문자도 가능
            // float :약 7자리 
            // double : 약 15~16자리
            // 이 자릿수를 넘어가는 그 타입은 그 수를 기억하고 있다고 볼 수 없다

            // decimal : 그 두배이지만  넘어가자

            string s = "ssssss";
            char ch = 'a'; // char가 모인 것이 string

            char cha = s[1]; // 하나씩 분리 가능

            bool bo = true;
            bool fo = false;
            //int 0/1으로도 되지만 > 논리형으로 많이 쓰니까 분리한 것

            // ***캐스팅(형변환)<엄청 중요!!>
            // 면접에서 자주 나옴
            // 암시적 : '데이터 손실,유실'이 일어나지 '않는' 캐스팅
            // 명시적 : '데이터 손실,유실'이 일어날 '우려가 있는' 캐스팅
            // 박싱/ 언박싱
            // 사용자 정의 변환
            // dynamic 변환
            // Convert class
            // .Parse
            int a2 = 30;
            short b2 = (short)a;
            int c2 = b2;

            float f2 = a;
            //int g = f2; //소수점이 날아감 > 데이터 유실

            int a3 = 2_100_000_000;
            float b3 = a;// 예외적인 상황 : ms에서 받아줌

            //Convert class
            //Convert.ToInt32()
            // Parse 
            string s2 = Console.ReadLine();// 한줄 입력
            int char2 = Console.Read();// 아스키코드 입력, 한글자 입력
            int a4 = int.Parse(s2);

            Console.WriteLine("");//줄바꿈 입력
            Console.Write("");// 줄바꿈 없는 입력
            //string format 
            int at = 10;
            int bt = 20;
            Console.WriteLine("엄마가 오이를 {0} ~ {1}개 사오라고 했음", at, bt);
            //서버에서 패킷 제너레이터, 자동 코드 작성 프로그램() 작성시
            // string interpolation
            Console.WriteLine($"엄마가 오이를 {at} ~ {bt}개 사오라고 했음");

            // 사칙연산
            int ap = 10;
            int bp = 20;
            int cp = ap + bp;
            cp = ap - bp;
            cp = ap * bp;
            cp = ap / bp; // bp를 ap로 0이 될 때까지 나눈 횟수
            cp = ap % bp; // bp를 ap로 나누고, bp보다 작은 값이 남은 것
            cp = ap++;
            //후위(postfix) : a의 값을 그냥 꺼내고 cp에 넣고 그 후에 값이 증가
            Console.WriteLine(cp);// 10 > ap가 11이 됨

            cp = ++ap;
            //전위(prefix) : a의 값이 증가한 후 그 값을 꺼내서 넣는다



            // 비교 연산  < / > / <= / >= / == / !=


            // 논리 연산 && / || / !
            //         AND  OR NOT
            // 논리곱 (모든 조건이 true이면 true)
            // 논리합 (둘 중 하나라도 true면 true)
            // 논리부정(참이면 거짓, 거짓이면 참)

            // 비트 연산 : & | 
            // & : 둘 다 1이어야 1 
            // | : 둘 중 하나라도 1이면 1


            // 디버깅
            //F9 : 중간점 > 실행하다가 이 코드를 만나면 실행해주세요

            int a7 = 10;
            int b4 = 10;

            // 조건 , 적중횟수(for문의 횟수 중 일정횟수 이상부터 중단)
            // 

            //RAM : 휘발성 > 컴퓨터를 끄면 다 날아간다 
            // HDD : 비휘발성

            // var : 리터럴 값에 따라 컴퓨터가 유추하여 타입을 부여 > 실재하는 타입이 아니다
            // 선언만 할 수 없다, 초기화가 필요
            // object : 실재하는 타입 , 모든 타입의 부모

            // 코드의 흐름 제어 > 분기문
            //if / switch
            // if - 조건이 참이면 아래 명령문이 실행
            // 보통은 조건에는 논리문을 쓴다

            bool isDead = false;
            if (isDead && !isDead)
            {
                Console.WriteLine("죽음");
            }
            else
            {
                Console.WriteLine("안죽음");
            }
            //continue; : 

            //삼항 연산자 > 결과의 리트럴 값에 따라
            // 중첩이 가능
            string s_if = isDead ? "죽음" : "안죽음";
            Console.WriteLine(s_if);
            string s_if2 = isDead ? "죽음" : !isDead ? "안죽음" : "죽음";


            //switch(//정수 / string / enum)
            // case "어떤 값":
            //   break;
            // default(= else문과 유사)
            int af = 10;

            switch (af)
            {
                case 0:
                    break;
                default:
                    break;
            }


            // 별찍기
            /*
              *
              * *
              * * *
              * * * *
              * * * * *
             */
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // 누적합 과 재귀함수
            int result = SumBetween(1, 6);
            Console.WriteLine($"결과 : {result}");
            int result2 = SumBetween2(1, 6);
            Console.WriteLine($"결과 : {result2}");




            Position pos = new Position();
            pos.X = result;
            pos.Y = result2;
            //public으로 안 열어두면 접근이 불가능
        }

        // 모든 if문은 switch로 바꿀 수 없다
        // 모든 switch문은 if로 바꿀 수 있다

        // 직업 선택 게임
        // 홀짝
        //int number = 3;
        //int oddOrEven = number % 2 != 0 ? 1 : 0;

        // 가위바위보 게임

        // 상수 : const > 보통 변수 컨벤션을 완전 대문자로 쓴다
        // 상수는 컴파일 때 정해져야함 > 미리 써져야함 > 초기화가 반드시 필요
        // readonly : 컴파일 시가 아니어도 
        private readonly int am;// 런타임때 지정이 가능하다

        // enum  : 상수의 모임
        // 다음 원소는 그 전 원소의 값의 +1이다.
        // 순서대로 안해도 가능하다

        // 반복문 :
        // while : 조건이 참이면 계속 반복, 조건이 참인 동안에 반복
        // do-while : 일단 실행 후 조건을 보고 참이면 무한 반복
        // for - 변수선언 ; 조건부 ; 조건 변경부
        //for( ; ; ){} // while(true){}
        // for문의 증감부는 아무런 차이가 없다
        // continue; : 그 코드 아래 부분은 전부 실행안하고 다음 반복문을 실행
        // break; : 그 코드 아래 부분은 전부 실행안하고 이 반복문을 종료

        // 함수(fuction/method/procedure) 
        // f11 :
        // f10 :
        //Test();
        // 호출 스택 : 실행되었던 모든 함수의 순서를 담은 리스트
        // 함수 만드는 법
        // "한정자" "타입" "변수이름";
        // "한정자: 접근지정자" "반환타입(void/다른 타입)" "함수이름" (매개변수타입 매개변수이름);
        //public void Test(sbyte sa, int b0)
        //{

        //}
        //public string Test2(sbyte sa, int b0)
        //{
        //    return null;
        //}
        // 스택 메모리 : 함수를 만들었다. > data
        //             함수가 호출되었다. > stack
        // 매개변수는 값의 복사본 > 반환안되면 끝남과 동시에 사라짐
        // Test() 프레임
        // Main() 프레임
        // 값 형식 / 참조형식
        // 값 전달 / 참조 전달
        // ref : 반드시 초기화가 먼저 이뤄져야 > 값이 있어야함
        // out : 초기화가 안되어있어도 들어갈 수는 있음, 단, 함수내에서 쓰기를 해야함
        //       값을 쓰기 전에서 값을 읽을 수 없음 > 맨 먼저 값을 초기화해야함

        // 재귀함수 : 
        // foreach
        /*
                                     [ref] [out]
            주소 전달 방식인가?         [ Y ] [ Y ]
            함수 안에서 읽기 가능?      [ Y ] [ N ](먼저 써야함)
            함수 호출 전 반드시 초기화?  [ Y ] [ N ]
            함수 내에서 반드시 값쓰기?   [ N ] [ Y ](써야 읽을 수 있음)
         */
        

        

        static int SumBetween(int a, int b)
{
    int sum = 0;

    for (int i = a; i <= b; i++)
    {
        sum += i;

    }
    return sum;
}

static int SumBetween2(int a, int b)
{


    int sum = 0;

    if (a > b)
    {
        sum += 0;
        return sum;
    }

    sum += a;
    ++a;


    return sum + SumBetween2(a, b);
}



// 구조체 : 데이터의 모임
// 값 타입
struct Player
{
    public int hp;
    public int atk;
}

// 구조체 이름 : position , x,y를 가짐
struct Position
{
    public int X;
    public int Y;
}

    }
}

