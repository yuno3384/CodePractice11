using static System.Net.Mime.MediaTypeNames;

namespace Practice20251121
{
    /*internal < 이건 무시하자 */ class Program
    {
        static void Main(string[] args)
        {
            

            int hp = 100;
            int monsterAttack = 0;
            bool isDead = (hp - monsterAttack) <= 0;

            //isDead가 참이면
            if(isDead == true)
            {
                Console.WriteLine("YOU DIED");  //YOU DIED
            }
            else if(isDead != true)
            {
                Console.WriteLine("You Are Alive");
            }
            //else//isDead가 거짓이면
            //{
            //    Console.WriteLine("You Are Alive");      //You Are Alive
            //}

            // 위에가 출력되게 분기문을 작성해주세요

            // ReadLine >> 적을때까지 대기 > 한번 적으면 사라진다 > 그래서 변수가 필요 > String 
            //string memo = Console.ReadLine();

            //Console.WriteLine(memo);

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
            string job1 = "전사 (Warrior)";
            string job2 = "마법사 (Mage)";
            string job3 = "도적 (Rogue)";
            string job4 = "마법소녀 (Magical Girl)";

            Console.WriteLine("===================================");
            Console.WriteLine("         [ 직업을 선택하세요 ]        ");
            Console.WriteLine("===================================");
            Console.WriteLine("1. 전사 (Warrior)");
            Console.WriteLine("2. 마법사 (Mage)");
            Console.WriteLine("3. 도적 (Rogue)");
            Console.WriteLine("4. 마법소녀 (Magical Girl)");
            Console.WriteLine("===================================");

            Console.Write("번호를 입력하세요: " );
            string job = Console.ReadLine();
            if (job == "1") // string으로 숫자를 받아도 그건 문자다. 문자열로 나타내면 된다.
            {
                Console.WriteLine("전사를 선택하셨습니다.");
                Console.WriteLine($"{job1}를 선택하셨습니다.");
                Console.WriteLine("{0}를 선택하셨습니다.",job1);
            }
            else if (job == "2")
            {
                Console.WriteLine("마법사를 선택하셨습니다.");
                Console.WriteLine($"{job2}를 선택하셨습니다.");
                Console.WriteLine("{0}를 선택하셨습니다.", job2);
            }
            else if (job == "3")
            {
                Console.WriteLine("도적을 선택하셨습니다.");
                Console.WriteLine($"{job3}를 선택하셨습니다.");
                Console.WriteLine("{0}를 선택하셨습니다.", job3);
            }
            else if (job == "4")
            {
                Console.WriteLine("마법소녀를 선택하셨습니다.");
                Console.WriteLine($"{job4}를 선택하셨습니다.");
                Console.WriteLine("{0}를 선택하셨습니다.", job4);
            }
            switch(job){
                case "1":
                    Console.WriteLine("전사를 선택하셨습니다.");
                    Console.WriteLine($"{job1}를 선택하셨습니다.");
                    Console.WriteLine("{0}를 선택하셨습니다.", job1);
                    break;
                case "2":
                    Console.WriteLine("마법사를 선택하셨습니다.");
                    Console.WriteLine($"{job2}를 선택하셨습니다.");
                    Console.WriteLine("{0}를 선택하셨습니다.", job2);
                    break;
                case "3":
                    Console.WriteLine("도적을 선택하셨습니다.");
                    Console.WriteLine($"{job3}를 선택하셨습니다.");
                    Console.WriteLine("{0}를 선택하셨습니다.", job3);
                    break;
                case "4":
                    Console.WriteLine("마법소녀를 선택하셨습니다.");
                    Console.WriteLine($"{job4}를 선택하셨습니다.");
                    Console.WriteLine("{0}를 선택하셨습니다.", job4);
                    break;


                    return;

            }

            //char key;

            //key = Console.ReadKey().KeyChar;


            // 분기문 과 for문으로도 충분히 게임은 만들 수 있음 > 텍스트 게임이겠지만....
            // 변수명은 한글 로마자 쓰지말고 > 그냥 쳇GPT를 쓰자

            // 다음주 월요일에는 캐스팅(형 변환)
            // Shift + alt + 방향키 , alt + 드래그 : 한꺼번에 수정 / 삭제

            // 주말에 과제용으로 10문제를 만들 것 > 파일화시켜서 줄 것



        }
    }
}
// Console.WriteLine("Hello"); // 어? 이거 왜 시작돼? > 원래는 main을 써야만 하는데
                                // 그냥 끌어다 쓰게 되어있음 > 이것이 최상위문 생략
