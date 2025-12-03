namespace JobOOP
{
    namespace Program2
    {
        class Program5
        {
            enum ClassType
            {
                None,
                Knight,
                Mage,
                Rogue
            }

            struct Player
            {
                public int hp;
                public int atk;
            }

            // 몬스터 구조체를 만들어주세요(hp, atk) 

            struct Monster
            {
                public string name;
                public int hp;
                public int atk;
            }




            static ClassType ClassChoice()
            {
                Console.WriteLine("직업을 선택하세요!");
                Console.WriteLine("[1] 기사");
                Console.WriteLine("[2] 마법사");
                Console.WriteLine("[3] 도둑");

                ClassType choice = ClassType.None;
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        choice = ClassType.Knight;
                        break;
                    case "2":
                        choice = ClassType.Mage;
                        break;
                    case "3":
                        choice = ClassType.Rogue;
                        break;
                }

                return choice;
            }

            static void CreatePlayer(ClassType choice, /*out int hp, out int atk,*/ out Player player)
            {
                // 기사(100/10), 마법사(50/15), 도둑(75/12)

                player.hp = 0;
                player.atk = 0;

                switch (choice)
                {
                    case ClassType.Knight:
                        player.hp = 100; 
                        player.atk = 10;
                        break;
                    case ClassType.Mage:
                        player.hp = 50;
                        player.atk = 15;
                        break;
                    case ClassType.Rogue:
                        player.hp = 75;
                        player.atk = 12;
                        break;
                   
                }

            }

            static void CreateRandomMonster(out Monster monster)
            {

                monster.name = "";
                monster.hp = 0;
                monster.atk = 0;


                Random random = new Random();
                // Random.Next(int min, int max) :minValue보다 크거나 같고 maxValue보다 작은 '부호 있는 32비트 정수(=int)'이므로
                                               // 반환 값의 범위에는 minValue가 포함되지만 maxValue는 포함되지 않습니다.
                                               // minValue가 maxValue와 같은 경우에는 minValue가 반환됩니다.
                int monsterRand = random.Next(1, 4);

                // 랜덤한 몬스터 생성
                // Slime(20/2), Orc(40/4), Skeleton(30/3)

                switch (monsterRand)
                {
                    case 1:
                        monster.name = "Slime";
                        monster.hp = 20;
                        monster.atk = 2;
                        break;
                    case 2:
                        monster.name = "Orc";
                        monster.hp = 40;
                        monster.atk = 4;
                        break;
                    case 3:
                        monster.name = "Skeleton";
                        monster.hp = 30;
                        monster.atk = 3;
                        break;
                    default:
                        Console.WriteLine($"{monsterRand}에서 잘못된 값이 입력되었습니다.");
                        break;
                }



            }

            static void Main(string[] args)
            {
                ClassType choice = ClassType.None;

                Player player;

                while (true)
                {
                    choice = ClassChoice();
                    if (choice != ClassType.None)
                    {
                        //// 캐릭터 생성
                        //int hp;
                        //int atk;

                        CreatePlayer(choice, /*out hp, out atk,*/ out player);

                        Console.WriteLine($"HP {player.hp}, ATK {player.atk}");

                        // 필드에서 싸울 몬스터
                        //Monster monster;
                        //CreateRandomMonster(out monster);
                        CreateRandomMonster(out Monster monster); // 이때부터 몬스터가 나타날 수 있음 > 생성과 동시에 전달
                        Console.WriteLine($"{monster.name}이 나타났다. HP {monster.hp}, ATK {monster.atk}");
                        // 공격을 넣을 거면 struct말고 class써라





                    }
                }
            }





        }
    }
}
