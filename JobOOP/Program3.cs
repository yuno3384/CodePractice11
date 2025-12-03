namespace JobOOP
{
    namespace Program3
    {
        class Program2
        {
            enum ClassType
            {
                None,
                Knight,
                Mage,
                Rogue
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

            static void CreatePlayer(ClassType choice, out int hp, out int atk)
            {
                // 기사(100/10), 마법사(50/15), 도둑(75/12)

                hp = 0;
                atk = 0;
                
                switch (choice)
                {
                    case ClassType.Knight:
                        hp = 100; 
                        atk = 10;
                        break;
                    case ClassType.Mage:
                        hp = 50;
                        atk = 15;
                        break;
                    case ClassType.Rogue:
                        hp = 75;
                        atk = 12;
                        break;
                }
            }

            //static void Main(string[] args)
            //{
            //    ClassType choice = ClassType.None;

            //    while (true)
            //    {
            //        choice = ClassChoice();
            //        if (choice != ClassType.None)
            //        {
            //            // 캐릭터 생성
            //            int hp;
            //            int atk;
            //            CreatePlayer(choice, out hp, out atk);

            //            Console.WriteLine($"HP {hp}, ATK {atk}");
            //        }





            // 올맨스타일 : 괄호를 넣는 스타일 C# C++ 게임 등
            // K&R 스타일 : 자바 , 웹 등
            //struct는 제발 데이터의 묶음 용도로만 사용 바란다.
            // struct에 init까지는 가능

            //struct는 값 형식이고, class는 참조 형식이다.
            //struct에 out 키워드를 쓴 이유가 바로 여기에 있다 > 값을 넘겨받기 때문이다
            // 반면에 class는 주소값이 전달되어 그 값 자체가 바뀐다
            // struct는 바이트가 타입에 따라 배수로 넘어간다 > 8바이트가 넘어가면 느려진다
            // >>그러면 그냥 class로 바꿔서 만들어라 


            // 구조체가 생기면 메모리는 
            /*
            -----------메모리--------------
            [   ][   ][ x ][ y ][   ][   ]
            [   ][   ][4 B][4 B][   ][   ]

            // 깊은 복사 얕은 복사

            
            // (class이름) (만들때 이름) = new (class명)(); // class형식의 객체가 생성됨
            // new (class명)();도 가능함

             */
            
            // 이너클래스 : 해당 클래스 안에서만 사용할 클래스
            // 함수안에서도 함수(지역함수)를 만들수는 있지만 하지 마라! > 가독성이 매우 떨어진다.

            // 생성자 : 객체를 생성할때 초기에 설정하는 것 > 따로 생성해서 사용
            // 생성자는 class내부에 있다. 따로 적어두면 생긴다
            // 기본 생성자(Constructor) > class와 동일한 class > 객체를 생성할때 기본생성자를 이용하여 생성한다.
            // 힙메모리를 00000000000000000000000000000으로 비우고
            // 그 class속 값을 넣고
            // return Knight 객체를 반환
            
            public class Knight
            {
                public Knight()
                {
                    // Knight타입의 객체를 heap에 생성
                    // 힙메모리

                    // 뒤에 따로 추가가 가능함 > 호출할때 이런 흐름을 타고 생성된다
                }

                // 매개변수가 있는 생성자, 사용자 지정 생성자 > 생성자 오버로딩
                public Knight(int hp) : this()
                {
                    //hp = hp;
                    this.hp = hp;
                }
                // this 
                // class내의 같은 이름을 가진 변수가 있을때 컴퓨터는 혼동에 빠진다
                // 이 경우 this를 사용하여 '해당하는 class'(나)를 나타낸다
                // 명시적으로 알려줌으로 오류를 막는다

                // 기본생성자도 같이 호출하고 싶다 > 생성자 체이닝 > 기본 생성자를 호출
                // 기본 생성자를 호출한 후 체이닝을 보고 오버로딩한 기본생성자가 호출되는 순으로 진행된다.
                //this(오버로딩된생성자> 인수갯수를 맞춰서 호출)
            }




            Knight knight = new Knight(); 




        }
    }
}
