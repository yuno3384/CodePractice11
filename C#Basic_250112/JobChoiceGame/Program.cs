namespace JobChoiceGame
{
    public class Program
    {
        enum ClassType
        {
            None,
            Warrior,
            Mage,
            Rogue,
            //남이 만든 코드를 내가 뜯어 고치는 것은 당일 퇴사에 해당. 반드시 조심해야함
            // 남의 코드에 내 코드를 끼워 맞춰라
        }
        enum MonsterType
        {
           None,
           Slime,
           Orc,
           Skeleton,
            //남이 만든 코드를 내가 뜯어 고치는 것은 당일 퇴사에 해당. 반드시 조심해야함
            // 남의 코드에 내 코드를 끼워 맞춰라
        }

        struct Player
        {
            public int hp;
            public int atk;
        }
        struct Monster
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

        static ClassType ClassChoice()
        {
            //ClassType choice;

            Console.WriteLine("직업을 선택하세요");
            Console.WriteLine("[1] 전사");
            Console.WriteLine("[2] 마법사");
            Console.WriteLine("[3] 도둑");
            string number = Console.ReadLine();
            switch (number)
            {
                case "1":
                    //choice = ClassType.Knight;
                    return ClassType.Warrior;
                //break;
                case "2":
                    //choice = ClassType.Mage;
                    return ClassType.Mage;
                //break;
                case "3":
                    //choice = ClassType.Rogue;
                    return ClassType.Rogue;
                //break;
                default:
                    //choice = ClassType.None;
                    return ClassType.None;
                    //break;
            }

            //return choice;
        }

        static void CreatePlayer(ClassType choice, out Player player)
        {
            //player = new Player();// 이미 만들어져 있음. 값에 default를 넣어줌 > new를 안 해도 됨

            switch (choice)
            {
                case ClassType.Warrior:
                    player.hp = 100;
                    player.atk = 100;
                    break;
                case ClassType.Mage:
                    player.hp = 50;
                    player.atk = 150;
                    break;
                case ClassType.Rogue:
                    player.hp = 75;
                    player.atk = 125;
                    break;
                default:
                    player.hp = 0;
                    player.atk = 0;
                    break;
            }

            //return player;
        }

        

        static void Main(string[] args)
        {
            ClassType choice = ClassType.None;

            while (true)
            {
                choice = ClassChoice();
                if(choice != ClassType.None)
                {
                    Player player;
                    CreatePlayer(choice, out player);

                    Console.WriteLine($"\nClassType : {choice}, HP: {player.hp}, ATK: {player.atk} ");
                    
                    break;
                }
            }
        }
    }
}
