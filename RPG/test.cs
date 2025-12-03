namespace RPG
{
    internal class Program
    {
        /*
             📘 구현 문제: 콘솔 몬스터 사냥 게임 만들기
            아래 조건을 만족하는 간단한 콘솔 RPG 전투 게임을 구현하세요.

            ✅ 1. Character 클래스 만들기
            다음 속성과 기능을 가진 Character 클래스를 만드세요.
            ■ 멤버 변수
            public string Name → 이름


            public int Hp → 체력


            public int Atk → 공격력


            ■ 생성자
            public Character(string name, int hp, int atk)

            ■ 메서드
            public virtual void Attack(Character target)


            target의 Hp를 Atk만큼 감소시키기


            HP가 0 미만이면 0으로 설정


            public bool IsDead()


            HP가 0 이하이면 true 반환


            */
        class Character
        {
            public string Name; //→ 이름
            public int Hp; //→ 체력
            public int Atk; //→ 공격력
            public Character()
            {

            }
            public Character(string name, int hp, int atk)
            {

            }
            public virtual void Attack(Character target)
            {
                //target의 Hp를 Atk만큼 감소시키기
                //Console.WriteLine($"[Trace]Before Attack Hp : {this.Hp}, {target.Hp}");
                //Console.WriteLine($"[Trace]Before Attack Atk : {this.Atk}, {target.Atk}");
                this.Hp -= target.Atk;
                //Console.WriteLine($"[Trace]After Attack Hp : {this.Hp}, {target.Hp}");
                //HP가 0 미만이면 HP를 0으로 설정

                if (this.Hp < 0)
                {
                    this.Hp = 0;
                }


            }



            public bool IsDead()
            {
                // HP가 0 이하이면 true 반환
                if (Hp <= 0)
                {
                    return true;
                }
                return false;
            }



        }

        /*
            ✅ 2. Player 클래스 구현 (Character 상속)
            추가 변수: public int Exp = 0


            생성자:


            public Player(string name, int hp, int atk)

            경험치 증가 함수:

            public void GainExp(int amount)

        */

        class Player : Character
        {
            public int Exp = 0;


            public Player(string name, int hp, int atk) : base(name, hp, atk)
            {
                this.Name = name;
                this.Hp = hp;
                this.Atk = atk;
            }

            public void GainExp(int amount)
            {

                Exp += amount;

            }




        }

        /*
            ✅ 3. Monster 클래스 구현 (Character 상속)
            랜덤 체력: 20~50


            랜덤 공격력: 2~6


            생성자에서 랜덤값으로 설정


            몬스터 이름은 메인에서 제공되는 랜덤 이름 사용
         ✅ 5. 제공 함수
            아래 함수는 반드시 사용하세요:
            static string RandomName()
            {
                string[] names = { "슬라임", "고블린", "늑대", "박쥐" };
                return names[new Random().Next(names.Length)];
            }


           */

        class Monster : Character
        {

            public Monster() : base()
            {
                Random rand = new Random();
                this.Hp = rand.Next(20, 51);
                this.Atk = rand.Next(2, 6);
                this.Name = RandomName();
            }


        }

        static string RandomName()
        {
            string[] names = { "슬라임", "고블린", "늑대", "박쥐" };
            return names[new Random().Next(names.Length)];
        }


        static void Main(string[] args)
        {


            /*

            ✅ 4. Main()에서 게임 구현
            ■ 기본 흐름
            Player 생성 > 이름 받고


            while 문 안에서 몬스터 계속 등장


            플레이어와 몬스터가 한 턴씩 서로 공격


            몬스터 사망 시 경험치 +10


            플레이어 HP가 0 이하이면 게임 종료


            전투 후 “계속 싸우시겠습니까?(y/n)” 입력받기



           
            */
            // init input -------------------------------------------
            Console.SetCursorPosition(30, 17);
            Console.WriteLine("플레이어님의 이름은 어떻게 되십니까?");
            Console.SetCursorPosition(30, 20);
            string read = Console.ReadLine();
            Player player = new Player(read, 50, 6);

            string answer = string.Empty;

            while (true)
            {
                Monster monster = new Monster();

                while (!monster.IsDead())
                {

                    // Render ------------------------------------ 
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.SetCursorPosition(30, 0);

                    // Update ----------------------------------------
                    Console.WriteLine($"몬스터가 나타났다. {monster.Name},{monster.Hp},{monster.Atk}");
                    Console.WriteLine($"공격력 {player.Name}님{player.Atk} vs {monster.Atk}적");
                    Console.WriteLine($"{player.Name}님 공격 차례입니다");
                    player.Attack(monster);
                    Console.WriteLine($"player : {player.Hp},monster : {monster.Hp}");
                    Console.WriteLine($"몬스터가 반격했습니다");
                    monster.Attack(player);
                    Console.WriteLine($"player : {player.Hp},monster : {monster.Hp}");

                    if (player.Hp == 0)
                    {
                        Console.WriteLine("Game Over");
                    }
                    else if (monster.Hp == 0)
                    {
                        player.GainExp(10);
                        Console.WriteLine($"{player.Name}가 경험치 {player.Exp}를 획득했다.");

                    }

                }
                Console.WriteLine("“계속 싸우시겠습니까?(y/n)”");
                answer = Console.ReadLine();

                if (answer == "y" || answer == "yes" || answer == "예" || answer == "응")
                {
                    player.Hp = 100;

                }
                else if (answer == "n" || answer == "no" || answer == "아니")
                {
                    Console.WriteLine("나중에 다시 봐요");
                }
            }








            /*

            📌 최종적으로 완성해야 하는 전체 기능 요약
            클래스 상속 구조 구현 (Character → Player/Monster)


            공격 로직 처리


            HP·EXP 증가 감소 처리


            무한 전투 루프


            게임 종료 조건 처리




             
             
             */
        }
    }
}
