namespace ConsoleApp1
{
    

    class Program
    {
        enum SRP
        {
        SCISSOR =1,
        ROCK =2,
        PAPER =3,
        }

        enum SRP2
        {
            SCISSOR = 1,
            ROCK = 2,
            PAPER = 3,
        }

        static void Main(string[] args)
        {
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

            Console.WriteLine("=========================================");
            Console.WriteLine("가위 바위 보 게임 (1.가위 2.바위 3.보)");
            Console.WriteLine("=========================================");
            Console.Write("선택하세요: ");
            string input = Console.ReadLine(); // 스트링값 > 숫자값
            int inputNum = Convert.ToInt32(input); // 그것을 받아 숫자로
            // int input = int.Parse(Console.ReadLine()); > 둘을 합친 방식 : 이 방식으로 바로 처리하는 것
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


            // 1. 컴퓨터 낸거 출력 > 1.5.형변환 > 2. 결과 출력

            // 가위바위보를 숫자로 >> 가위바위보의 원리에... 숫자를 문자열로.... 그걸 계산을 하고...
            // 지금은 한개지만 나중엔 cs문서가 여러개가 될건데
            // 상수를 쓰면 조금 간단해 질거다

            // 변수 : 변할 수 있는 값
            // 상수 : 변하지 않는 값 > 어떠한 값에 대해 앞으로 이런 이름으로 쓰겠다

            const int scissors = 1;
            const int rock = 2;
            const int paper = 3;

            // const로 상수화시키면 앞으로 이 변수는 수정이 더이상 불가능

            // 상수화를 시킬 때 값을 안 넣을 수가 없다 > 값을 무조건 한번은 넣어줘야 한다. > 초기화가 필요
            // 한번 초기화한 이후로는 더이상 수정이 안된다

            // readonly

            //readonly int a = 3; 

            switch (comChoice)
            {
                case rock:
                    
                    break;
                case scissors:
                   
                    break;
                case paper:
                   
                    break;
            }

            // enum : 상수들의 그룹 > 그룹만 교체하면 바로바로 쓸 수 있게 > 그룹의 이름 . 자식의 이름 >> 결국에는 숫자값 >> int로 형변환 시 정상작동
            // 만일 지정을 안 하면 기본은 0 , 하지만 값을 주면 그 다음 상수는 (전 상수의 값 + 1)을 값으로 설정


            switch (comChoice)
            {
                case (int)SRP.SCISSOR: 
                    Console.WriteLine($"컴퓨터는 {SRP.SCISSOR}를 냈습니다."); // WriteLine에서는 enum의 상수명이 나오게 된다
                    break;
                case (int)SRP.ROCK:
                    Console.WriteLine($"컴퓨터는 {SRP.PAPER}를 냈습니다.");
                    break;
                case paper:
                    Console.WriteLine($"컴퓨터는 {SRP.ROCK}를 냈습니다.");
                    break;
            }

            // ctrl + r + r : 상수의 이름을 전부 바꿔줌 >> 편하게 바꿀 수 있음 >> 최대한 변수화를 하는 게 좋다


            // 구조체 



        }
    }
}
