using System.ComponentModel.Design;
using System.Windows.Input;

namespace Practice251124
{
    internal class Program
    {
        static void Main()
        {
            ///*
            // 1. 리터럴 : 데이터 값
            //     int a = 10; 
            //     int b = 15;
            //     a = 15; // 리터럴임
            //     a = b; // 리터럴이 아님 > 변수값은 바뀔 수 있기 때문 > 변수 대입
            //     string s = "d";
            //     char c = 'a';
            //     float f = 3.14f;
            //     대입이 되는 값 > 빌드를 끝내면 변경이 불가능 값
            //     그럼 리터럴이 아닌 것은?
            //     대입값(변수도 포함) < 리터럴(변수가 아닌 순수값)

            //     2. char : 문자
            //        string : 문자열

            //     배열 > 문자열도 배열
            //     문자열 => [h][e][l][l][o][w][o][r][l][d](10칸 0 ~ 9) > 컴퓨터는 항상 0부터 시작(첫번째가 0)
            //     문자 => [h]
            //     문자열에 하나를 빼면 문자
            //     문장 > 단어 > 글자

            //     3. 스트링포맷 과 스트링인터폴레이션
            //     스트링인터폴레이션을 요즘은 많이 씀
            //     스트링포맷 > 코드를 자동 생성하게 하는 포로그램을 개발할때 그 자리에 이 값을 넣어라 할 때 주로 사용 

            //     4. 증감연산자

            //     int a = 10;
            //     int b = 10;
            //                                                             IL이 컴파일
            //     Console.WriteLine(a++); > int temp = a;(a의 값을 temp에 넣고) a = a + 1;(a는 1을 더하고) Console.WriteLine(temp);(temp값을 보여준다) > temp = 10
            //     Console.WriteLine(++b); > b = b+1;(1을 더하고) Console.WriteLine(b);(그냥 보여준다)

            //     1dloc a : a로드
            //     dup : 스택에 복제
            //     ldc.i4.1 : 1로드
            //     add : a+1
            //     stloc a : a에 저장
            //     call WriteLine : 복사해둔 값 출력

            //     이건 값형식 표현방식 > 포인터에서 나오는 방식이니.. 일단은 패스
            //     주요 사용처 : a++의 예시 >
            //     캐릭터 생성 후 ID 매기기 
            //     캐릭터(ID) > 캐릭터++; > 0번
            //     캐릭터(ID) > ++캐릭터; > 1번
            //     i++ (후위): 현재 값을 사용하거나 반환해야 할 때. (대부분의 for 루프, 현재 인덱스 사용 시)
            //     ++i (전위): **새로운 값 (증가된 값)**을 즉시 연산에 사용하거나 반환해야 할 때. (고유 ID 생성, 1부터 시작하는 카운터) 

            //     5. 세 수 중 큰 수 찾기 > int result = Math.max(a,b);
            //                                   result = Math.max(result, c);
            //                                   Console.WriteLine(result)



            // */


            ////변수 = 값을 담는 바구니
            ////     캐릭터
            ////     컴퓨터야 HP라는 값을 기억해줘 > 어떻게 ? > 변수로
            ////     HP = 100;
            ////변수 = 100;

            ////사용법) 컴퓨터에게 hp 100 이라는 값을 기억시키기
            ////     int(형식 - 컴퓨터야 이건 정수형 리트럴이야) hp(그 바구니 이름은hp야) = (거기에 담아) 100(100을);(알겠지?)
            //     // int a = 15;
            //     // int hp = 100;
            //     // int b = a; // (변수에 값을 뽑아와서 다른 변수에 대입하기)

            //// 형식(타입)
            //// 정수 int  99 -99 0 122
            //// 실수 float 3.14 5.0 0.0
            //// 문자열 string "월요일 싫어"
            //// 불리언 bool  true false

            //// 작은 숫자면(0 ~ 255내) > byte > 메모리를 아낄 수 있으니 좋지 > 문제는 오버플로우가 자주 발생해요
            //// >> -값으로 가는거지.... > 그냥 int , long으로 선언하자 > 최적화는 나----중에 > 생각도 하지 말자...

            //// byte / sbyte를 제외하고는 다 u를 쓰는데 > unsigned(부호가 붙지 않은 > -가 없는 > 0부터 시작)
            //// 그래서 sbyte는 signed byte 즉, 음수가 적용된 byte다(0기준으로 반반 나눈)

            ////// 산술 연산
            ////int a = 10;
            ////int b = 5;
            ////int c = 0;
            ////// c 에다가 a - b의 값을 넣고싶다면?
            ////c = a - b;
            ////// c 에다가 a + b의 값을 넣고싶다면?
            ////c = a + b; // 세미콜론 여러개는 그냥 끝났어 강조만 할 뿐 오류는 안난다

            ////c = a * b;

            ////c = a / b;

            ////c = a % b; // 둘을 나눠 나머지값을 주세요

            ////타입은 키워드 이므로 변수명으로 사용할 수 없다

            //// 네임스페이스 : 변수명 충돌방지를 위해 만든 공간

            //// 모든 C#은 main이 하나만 가능 > 둘은 불가

            //// string[] args :매개변수 > 없어도 됨

            //int a3 = 10;
            //Console.WriteLine(++a3); // 11
            //Console.WriteLine(a3++); // 11 > 12아님
            //Console.WriteLine(a3);

            //int a = 10;
            //int b = 20;

            //bool c = false; // 초기화를 안 시켜놓으면 > default값으로 bool은 false가 들어간다 > 형식의 기본값
            //// int : 0
            //// bool : false
            //// string : null

            //// a가 b보다 크다
            //c = a > b;// false

            //c = a < b; // true

            //// 비교연산을 하면 트루 혹은 펄스의 값이 나온다

            //// 같다 > 이퀄 2개
            //// c에 a와 b의 값이 같다
            //c = a == b; // false

            //// 다르다 !=
            //c = a != b; // true

            ////  논리연산 > 두개를 쓴다(!만 하나) > 하나씩 쓰면 비트연산
            ////&&
            //// ||
            //// !
            //// a가 b보다 작고 b가 a보다 크다
            //c = a < b && b > a; // true
            //// a가 b보다 작거나 b가 a보다 크다
            //c = a < b || b > a;
            //// c의 결과값을 뒤집겠다 > 반대값을 넣는다 > 아니다를 쓴다
            //c = !c;

            //// 분기문
            //// int a = 10;

            //// a 가 5보다 크면 true 작으면 false
            //if(a > 5)
            //{
            //    Console.WriteLine(true);
            //}
            //else if (a == 4)//if조건이 거짓일때
            //{
            //    Console.WriteLine(4);
            //}
            //else //모든 조건이 거짓일때
            //{
            //    Console.WriteLine(false);
            //}
            //// 중첩 if문
            //if (a > 5)
            //{// {} < 이것을 스코프라 부른다
            //    if (a == 6)
            //    {
            //        Console.WriteLine(4);
            //    }
            //    else
            //    {
            //        Console.WriteLine(false);
            //    }
            //}

            //// 축약문 > 삼항연산자 > 다른 회사들이 지양 > 코드가 길어지면 가독성이 떨어져서...
            //// a++ >  a = a + 1
            //// ++a > a = 1 + a

            //string s = a > 5 ? "커" : "작어";
            //// 비교연산(if괄호속 조건) ?(이라면) 참(참일 경우의 답변) : 거짓(거짓일 경우의 답변)
            //bool b2 = a > 5 ? true : false;
            //Console.WriteLine(s);
            //// 남이 이해하는 코드가 제일 좋은 코드다


            ////1. 정수형(int) 변수 hp(현재 체력 100), maxHp(최대 체력 100), potion(포션 회복량 2)을 선언한다.
            //int hp = 100;
            //int maxHp = 100;
            //int potion = 2;
            //Console.WriteLine($"Your Hp is {hp}.");

            ////2. 체력이 1 감소하는 상황을 증감연산자(--hp 또는 hp--) 를 활용하여 표현한다.
            //--hp; // 증감연산자를 사용시에는 굳이 초기화 안 해도 된다 > hp-- 의 경우는 값이 달라지기 때문이다
            //Console.WriteLine("Attcked. hp: "+ hp);

            ////3. 포션을 마셔 산술연산(hp = hp + potion) 으로 체력을 회복한다.
            //hp = hp + potion;
            //Console.WriteLine("Potion. hp :" + hp);

            ////4. 회복된 체력이 최대 체력을 넘지 않도록 비교연산(hp > maxHp) 을 사용해 조절한다.
            //// 1번 방식 : 불리언을 선언하고 거기에서 비교연산하기
            //bool isOverMax = (hp > maxHp);

            //if (isOverMax) {
            //    hp = maxHp;
            //    Console.WriteLine("Hp can't over maxHp.");
            //}
            //else
            //{
            //    Console.WriteLine("Current Hp : "+ hp);
            //}

            //// 2번 방식 : 불리언 사용 안하기
            //if(hp > maxHp) hp = maxHp; // if문을 한줄로도 가능은 하다...

            ////5. 체력이 0 이하인지 확인하여  사망 여부를 판단하는 분기문을 작성한다.

            //bool isZero = (hp <= 0);
            //if (isZero) {
            //    Console.WriteLine("You Died");

            //}
            //else
            //{
            //    Console.WriteLine("You need Care Current Hp: " + hp);
            //}

            ////6. 체력이 0 초과라면 "생존", 0 이하라면 "사망" 을 출력하는 삼항연산자를 추가한다.
            //string isAlive = (hp > 0) ? "You are alive" : "You Died" ;

            //// 나중에는 그룹스터디를 하면 좋다
            //// 알려주면서 늘어나는 것도 많았고 > 찾아보고 하는 것을 통해 많이 배운다
            //// ctrl + / 로 한줄주석으로 바꿀 수 있다



            //// 캐스팅(형 변환) 주요!!! <- 면접 기초 문제로 자주 나옴 (문법)
            //// int float string bool
            //int a1 = 2100000000;
            //// 형변환을 자주 하게 될것
            //// 명시적 형변환
            //// 암시적 형변환
            //// 이 두가지는 외워야 한다

            //short b1;

            ////b1 = a1; //어라 못 넣네? > 암시적으로는 못 넣는다고?? 
            ////b
            ////[     ]
            ////a
            ////[     ]                          ] >> 값이 잘릴건데? 상관없어! >> 명시적
            ///*
            // sbyte	-128 ~127	부호 있는 8비트 정수	System.SByte
            // byte	0~255	부호 없는 8비트 정수	System.Byte
            // short	-32,768 ~ 32,767	부호 있는 16비트 정수	System.Int16
            // ushort	0에서 65,535까지	부호 없는 16비트 정수	System.UInt16
            // int	-2,147,483,648 ~ 2,147,483,647	부호 있는 32비트 정수	System.Int32
            // uint	0~4,294,967,295	부호 없는 32비트 정수	System.UInt32
            // */
            //// 명시적 : (변환하려는타입)변수명

            //b1 = (short)a1; // >> 데이터의 유실이 일어날 수 있음

            //Console.WriteLine(b1); //29952
            //// 명시적 : 작은 박스에 큰바구니의 값을 넣으려 할때
            //// 데이터 유실 위험이 있을때 선언해서 컴퓨터에게 알려주는 방식

            //// 암시적 : 큰 바구니에서 작은 바구니의 값을 넣으려할 때
            //// 데이터의 유실 위험이 없을때 컴퓨터가 자동으로 해주는 방식
            //short c1 = 100;
            //int d = (int)c1; // 굳이 이렇게 해야겠니? > 데이터가 안 없어지니까 그냥 넣어줄게
            //// 물론 이것은 암시적이지만...
            //// 근데 이걸 어디에 사용해? > player라는 class > 거기서 세분화 > 물려받아 knight > 이 두개를 형변환해야하는데
            //// class가 사용자 정의 데이터 타입 이라서
            //// 그런 식으로 형식적으로 형변환해야하고

            //// 실수형 > 
            //float e = (float)a1;// 어라 되네? >  문제없이 진행됨
            //// 7자리까지는 안정적이다 > 내부적 로직이 또 있어서 > 만일 소수점 위는 날리지 않기 때문에
            //// 실제 정밀도는 손상이 있겠지만 자릿수는 같으니까
            //// 이정도는 편의성을 위해서 그냥 암시적으로 하자
            //// 이런 경우가 얼마나 있겠어
            //a1 = (int)e; // int는 소숫점을 못 받으니 > 에러 >> 명시적으로 허용하는

            //// string s1 = (string)a1;//어 근데 이건 왜 안돼?
            //string s1 = a.ToString(); // a+" " 방식으로 string으로 만든 방식

            //// parse > 
            //int a4 = 100;
            ////string b5 = (string)a4; // string은 기본 형식이 아니다
            //string b5 = a1.ToString();  // >> a+" " 숫자에서 스트링으로 가는 방식

            //// 문자열 -> 숫자
            ////a1 = (int)s1; 
            //string s2 = "hello";
            //a1 = int.Parse(s2); // Unhandled exception. System.FormatException:
            //                    // The input string 'hello' was not in a correct format. >> 숫자 넣는다며!!
            //                    // 주의) 그 문자열이 숫자여야 한다.

            ////Convert class에 있는 To매소드
            //Convert.ToInt32(a1); // int.Parse > int는 원래 Int32다
            //Convert.ToString(s1);
            //Convert.ToChar(s2);
            //Convert.ToDouble(a4);
            string playerHp = "70";
            int hp = Convert.ToInt32(playerHp);
            Console.WriteLine(hp);
            playerHp = "T";
            Console.WriteLine(Convert.ToString(playerHp));
            // Switch문
            // if문으로 > 전사선택 마법사 선택

            // 콘솔창에 아래와 같은 화면이 출력되도록 만들어 주세요
            // 번호 입력시 무조건 1, 2, 3, 4 중 하나만 입력 한다고 가정합니다.

            //===================================
            //         [ 직업을 선택하세요 ]        
            //===================================
            // 1. 전사 (Warrior)
            // 2. 마법사 (Mage)
            // 3. 도적 (Rogue)
            // 4. 마법소녀 (Magical Girl)
            //===================================
            //번호를 입력하세요: 2
            //마법사를 선택하셨습니다.
            //string input = Console.ReadLine();
            //if (input == "1") // if문이 더 넓은 범위내에서 가능 >> switch로 만든 모든 문장은 다 if문으로 전환이 가능
            //{
            //    Console.Write("전사를 선택하셨습니다.");
            //}
            //else if (input == "2")
            //{
            //    Console.Write("마법사를 선택하셨습니다.");
            //}
            //else if (input == "3")
            //{
            //    Console.Write("도적을 선택하셨습니다.");
            //}
            //else if (input == "4")
            //{
            //    Console.Write("마법소녀를 선택하셨습니다.");
            //}
            //else
            //{
            //    Console.Write("번호를 잘 못 입력하셨습니다.");
            //}
            //// 어우 길어 >> 가독성을 높일 방법이 없을까?

            //switch (input) // 변수에 대하여 case를 찾아 해당하는 값을 찾는 문
            //               // switch로 될 것을 if문으로 만들지 마라 > 안될때만 if문으로
            //               // > string이면 case도 string으로, int여야 case가 int
            //               // switch로 가능한 것 => string , int , enum(내부적으로는 숫자값임)
            //               // >> (나머지는 의미없음) 원래는 숫자로 값찾기는 안되었는데... 하지말 것
            //{
            //    case "1": // else if
            //        {
            //            Console.Write("전사를 선택하셨습니다.");
            //            break; // 이 스위치 문을 빠져나가겠다. > 해당 케이스의 종료
            //        }
            //    case "2": // else if
            //        {
            //            Console.Write("마법사를 선택하셨습니다.");
            //            break;
            //            Console.Write("마법사를 선택하셨습니다.");
            //        }
            //    case "3": // else if
            //        {
            //            Console.Write("도적을 선택하셨습니다.");
            //            break;
            //        }
            //    case "4": // else if

            //        {
            //            Console.Write("마법소녀를 선택하셨습니다.");
            //            break;
            //        }
            //    default:// else와 같은 역할을 한다 > 모든 조건이 일치하지 않을때
            //        Console.Write("번호를 잘 못 입력하셨습니다.");
            //        break;


            //}

            // switch : switch 문 선언
            // case : 경우의 수
            // break : 이 case를 끝으로 switch문을 나갈거다 > break 다음에 쓴 문장은 전부 무시됨




            // 밥은 같이 모여서 먹어서 얘기 좀 나눠라
            // 어디 오류 났을때는 가만히 그걸 보고만 있지말고, 나가서 커피타임좀 갖고 와라 > 보일 수도



            // 아래에 추가로 코드를 작성하여 프로그램을 완성해 주세요.
            // 결과 화면 예시
            /*
                ========================================
                가위 바위 보 게임 (1:가위, 2:바위, 3:보)
                ========================================
                선택하세요: 1
                컴퓨터는 보를 냈습니다.
                당신이 이겼습니다!

                ========================================
                가위 바위 보 게임 (1:가위, 2:바위, 3:보)
                ========================================
                선택하세요: 2
                컴퓨터는 보를 냈습니다.
                컴퓨터가 이겼습니다!

                ========================================
                가위 바위 보 게임 (1:가위, 2:바위, 3:보)
                ========================================
                선택하세요: 3
                컴퓨터는 보를 냈습니다.
                비겼습니다!

                ========================================
                가위 바위 보 게임 (1:가위, 2:바위, 3:보)
                ========================================
                선택하세요: 5
                컴퓨터는 보를 냈습니다.
                잘못된 입력입니다. 1~3 중 하나만 입력해주세요.
             */

            // 가위 바위 보 게임을 만듭니다 문자열을 숫자로 바꿔서...
            // 1. 가위는 보를 이겨(1>3) = false
            // 2. 주먹은 보에게 져(2<3) = true
            // 3. 바위는 가위를 이겨(1<2) = true
            // input과 rand가 같으면 > 비김
            // 그 외는 설계가 필요

            Console.WriteLine("===================================");
            Console.WriteLine("가위 바위 보 게임 (1.가위 2.바위 3.보)");
            Console.WriteLine("===================================");
            Console.Write("선택하세요: ");
            string input = Console.ReadLine();
            int inputNum = Convert.ToInt32(input);
            //int inputNum = int.Parse(input);
            // Console.WriteLine(inputNum);
            // 여기서 우리가 네트워트를 할 수는 없으니 > Random을 써서 해보자
            Random rand = new Random();
            int comChoice = rand.Next(1, 4); // 1부터 4전값 사이에 랜덤하게 아무값이나 넣어주세요 >> 1 2 3
                                             //string comRand =" ";

            //switch (comChoice)
            //{
            //    case 1:
            //        comRand = "가위";
            //        break;
            //    case 2:
            //        comRand = "바위";
            //        break;
            //    case 3:
            //        comRand = "보";
            //        break;
            //}// switch문은 무조건 default가 필요하지는 않다
            //switch (input)
            //{
            //    case "1":
            //        input = "가위";
            //        break;
            //    case "2":
            //        input = "바위";
            //        break;
            //    case "3":
            //        input = "보";
            //        break;
            //    default:
            //        Console.WriteLine($"컴퓨터는 {comRand}를 냈습니다.");
            //        Console.WriteLine("잘못된 입력입니다. 1~3 중 하나만 입력해주세요.");
            //        break;

            //}

            //// C#은 들여쓰기로 오류가 안남 > 파이썬은 오류가남
            //// 모든 클래스 다음에 main이 없으면 실행이 안됨 > main쪽에 class를 붙일 것

            //// if문 설계 > string으로 처리하는 법
            //if (comRand == input)
            //{// 비긴 경우
            //    Console.WriteLine($"컴퓨터는 {comRand}를 냈습니다.");
            //    Console.WriteLine("비겼습니다!");
            //}
            //else if (comRand == "가위")
            //{
            //    if (input == "바위")
            //    {
            //        Console.WriteLine($"컴퓨터는 {comRand}를 냈습니다.");
            //        Console.WriteLine("당신이 이겼습니다!");
            //    }
            //    else if (input == "보")
            //    {
            //        Console.WriteLine($"컴퓨터는 {comRand}를 냈습니다.");
            //        Console.WriteLine("컴퓨터가 이겼습니다!");
            //    }

            //}
            //else if (comRand == "바위")
            //{
            //    if (input == "가위")
            //    {
            //        Console.WriteLine($"컴퓨터는 {comRand}를 냈습니다.");
            //        Console.WriteLine("컴퓨터가 이겼습니다!");
            //    }
            //    else if (input == "보")
            //    {
            //        Console.WriteLine($"컴퓨터는 {comRand}를 냈습니다.");
            //        Console.WriteLine("당신이 이겼습니다!");
            //    }

            //}
            //else if (comRand == "보")
            //{
            //    if (input == "가위")
            //    {
            //        Console.WriteLine($"컴퓨터는 {comRand}를 냈습니다.");
            //        Console.WriteLine("당신이 이겼습니다!");
            //    }
            //    else if (input == "바위")
            //    {
            //        Console.WriteLine($"컴퓨터는 {comRand}를 냈습니다.");
            //        Console.WriteLine("컴퓨터가 이겼습니다!");
            //    }

            //}



            // int로 비교  1이고 2이면 > 이거다
            if (inputNum <= 3)
            {
                if (inputNum == 1)
                {
                    if (comChoice == 1)
                    {
                        Console.WriteLine("컴퓨터는 가위를 냈습니다.");
                        Console.WriteLine("비겼습니다!");
                    }
                    else if (comChoice == 2)
                    {
                        {
                            Console.WriteLine("컴퓨터는 가위를 냈습니다.");
                            Console.WriteLine("당신이 이겼습니다!");
                        }
                    }
                    else if (comChoice == 3)
                    {
                        Console.WriteLine("컴퓨터는 보를 냈습니다.");
                        Console.WriteLine("컴퓨터가 이겼습니다!");
                    }
                }
                else if (inputNum == 2)
                {
                    if (comChoice == 1)
                    {
                        Console.WriteLine("컴퓨터는 가위를 냈습니다.");
                        Console.WriteLine("당신이 이겼습니다!");
                    }
                    else if (comChoice == 2)
                    {
                        Console.WriteLine("컴퓨터는 바위를 냈습니다.");
                        Console.WriteLine("비겼습니다!");
                    }
                    else if (comChoice == 3)
                    {
                        Console.WriteLine("컴퓨터는 보를 냈습니다.");
                        Console.WriteLine("컴퓨터가 이겼습니다!");
                    }
                }
                else if (inputNum == 3)
                {
                    if (comChoice == 1)
                    {
                        Console.WriteLine("컴퓨터는 가위를 냈습니다.");
                        Console.WriteLine("컴퓨터가 이겼습니다!");

                    }
                    else if (comChoice == 2)
                    {
                        {
                            Console.WriteLine("컴퓨터는 바위를 냈습니다.");
                            Console.WriteLine("당신이 이겼습니다!");
                        }
                    }
                    else if (comChoice == 3)
                    {
                        Console.WriteLine("컴퓨터는 보를 냈습니다.");
                        Console.WriteLine("비겼습니다!");
                    }
                }
            }
            else if (inputNum > 3)
            {
                if (comChoice == 1)
                {
                    Console.WriteLine("컴퓨터는 가위를 냈습니다.");
                    Console.WriteLine("잘못된 입력입니다. 1~3 중 하나만 입력해주세요.");
                }
                else if (comChoice == 2)
                {
                    {
                        Console.WriteLine("컴퓨터는 바위를 냈습니다.");
                        Console.WriteLine("잘못된 입력입니다. 1~3 중 하나만 입력해주세요.");
                    }
                }
                else if (comChoice == 3)
                {
                    Console.WriteLine("컴퓨터는 보를 냈습니다.");
                    Console.WriteLine("잘못된 입력입니다. 1~3 중 하나만 입력해주세요.");
                }

            }

            // 솔루션을 이용하는 방법
            // 프로젝트 안에는 다수의 js를 넣을 수 있다
            // 오른쪽 버튼 a > 시작프로젝트로 설정
            // 프로젝트를 만들고 > cs만 제출하는 방법

            // 디스코드를 안쓰고 git을 써보자 > 설치후 cmd에서 git --version > 버전정보가 나오면 정상

            // main > branch > 병합 >> 소스트리에서는 저 그림이 그려짐

            // 깃 : 내 컴퓨터
            // 깃허브 : 그 걸 웹사이트에

            // 깃허브에서 

            // 최선문 강사님 C#강의 꼼꼼하게 잘 들어둬야 유니티에서 안 헤맨다

            // 유니티는 C#이 전부다



            
            
        }
    }
}
