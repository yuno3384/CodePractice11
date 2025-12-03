namespace _251121Ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // dll : 실행프로그램이 돌아가기 위한 코드의 장소 , exe : 실행프로그램
            // exe는 바로 꺼져서 안보임 > cmd
            // json > 이건 부산물, 디버그 기호 > 오류나면 찾기 위해서 > 삭제해도 됨
            /* 는 A fatal error was encountered. The library 'hostpolicy.dll' 
             * required to execute the application was not found in 
             * 'C:\Program Files\dotnet\'.
                Failed to run as a self - contained app.
            //  - The application was run as a self - contained app 
            because 
            'C:\CodePractice\Practice20251121\bin\Debug\net8.0\
            Practice20251121.runtimeconfig.json' was not found.
              - If this should be a framework-dependent app, 
            add the 'C:\CodePractice\Practice20251121\bin\Debug\net8.0
            \Practice20251121.runtimeconfig.json' file and specify the appropriate framework.
            */

            // 변수는 숫자로 시작할 수 없다 > 문자로만 시작이 가능 > 다만 한글은 '제발!' 쓰지마시길
            // 오류날 수도 있다. > _로 시작하는 경우도 있고, 대문자로 시작하고... 그건 회사나름이고
            int hp = 100; // main이 실행되면 hp라는 바구니에 숫자 10이라는 데이터를 넣겠다.
            // ; : 끝마침 > 여러번 쓰면? 
            // int a = 1009; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ;
            // 명령문이 종료된 걸로 보기는 함 > 무시는 안함 > 멸령 끝났다를 여러번 한 것일뿐
            Console.WriteLine(hp); // 메모리에 들은 hp바구니 속에 들어있는 값을 콘솔창에 출력해줘

            // 프로그래밍에서 = 과 == 은 다르다
            // =은 오른쪽에 있는 걸 왼쪽에 넣겠다 / == : 둘은 같다

            //int mp = hp;

            int Maxhp = 100; //절대 변하게 하지 않게 고정
            //hp = 80;
            //hp = Maxhp;

            // 정수형 타입의 종류
            // byte(0부터 255까지) sbyte(음수부터 255칸 되게) : 8비트 
            // short ushort : 16비트
            // int uint : 32비트
            // long ulong : 64비트
            // nint nuint : 32 아니면 64 
            // unsigned : 음수가 없는 
            // 32개의 전구로 표현할 수 있는 꺼졌다 켜졌다 방식 > 2^32 > 가장 맨 위에 있는 것을 부호로 하자 
            // > 즉 uint는 2^32을 다 쓰는 거고, int는 32번째는 1은 음수 0은 양수로 두고 2^31을 기준으로 나눈다
            // float은 범위가 총 7자리를 표현한다, 기억한다.
            // double 까지는 쓴다  => 15~16자리를 기억한다 / decimal까지는 잘 안 쓴다.
            // int float bool 은 기본형

            // 문자열 > 큰쌍따옴표
            // // sring은 class로 되어있음
            string name = "sdjdjdj";
            Console.WriteLine(name);

            // 문자 > 작은따옴표 > 문자들이 모여서 문자열이 된다
            char t = 'T';

            // bool > 참, 거짓을 담는 기본형
            //bool isAlive = true;
            //isAlive = false;

            //int isDead = 0;
            //isDead = 1; // 이렇게 써도 되는데 많이 쓰니까 마소가 따로 만든 것

            float number = 10.3f; // float은 숫자에 리트럴 f(F) > double이 기본값이라 굳이 d(D)를 안 넣어도됨
            // 리플랙션 > single이 원래 float의 정체

            int a = 10;
            float b = 3.14f;
            string c = "C# 엄청 쉽다";
            bool d = true;

            // 스트링 포맷
            Console.WriteLine("{0} {1}", a, b); // {}속의 숫자와 뒤의 변수 순서대로 가능
                                                // a띄고 b띄고 c띄고 d 를 출력하게 끔 만들어주세요

            // Console.WriteLine(); // 출력
            // Console.ReadLine(); // 입력도 가능하다 > 한줄 입력이 가능하다

            string input = Console.ReadLine(); // 초록색 물결은 null이라 그럼


            Console.WriteLine(input);

            // Console.Read() => 글자 하나 받는다. 근데 글자는 아스키코드로 되어있어 숫자로 지정되어있음
            // 그래서 int로 받는다
        }
    }
}
