using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobOOP
{
    class Class
    {

        public class Wizard
        {
            public int mp;
            public int intelligence;

            public Wizard(int mp , int intelligence)
            {
                this.mp = mp;
                this.intelligence = intelligence;
            }
        }
       

        //추상 클래스
        abstract class Player // 모태클래스에 정의해두자
        {
            protected int hp;
            int mp;

            public void move()// 추상함수는 반드시 구현해야함 > 아니면 추상클래스  
            {
                Console.WriteLine("이동하라");
            }
            public abstract void useSkill();// 다형성 : 상속받은 것을 여러가지로 변형이 가능하다
                                        // 오버라이드 > 부모함수 재정의 > 너 무조건 이거 구현해
                                        // 추상함수를 만드려면 > 클래스도 추상클래스로 바꿔야함
                                        // 객체를 만들 수 없음 > 부모가 보호됨

            public virtual void Attack()//가상함수 : 너 이거 구현안해도 되는데, 일단 만들어는 둘게
            {
                Console.WriteLine("공격");
            }
        }



        //class Player // 모태클래스에 정의해두자
        //{
        //    int hp;
        //    int mp;

        //    public void move()
        //    {
        //        Console.WriteLine("이동하라");
        //    }
        //}
        class Knight : Player // 상속 클래스 : 부모가 가진 int hp를 나도 사용이 가능하다. > 물려받음
        {
            //int hp;

            public override void Attack() // 가상함수도 계승하려면 override를 쓴다.
            {
                base.Attack(); // base : 부모
                Console.WriteLine("전사의 공격!!");
            }
            public override void useSkill() {
                Console.WriteLine("전사의 특별 스킬!!");
            }
            // 부모로 부터 추상함수가 있다면
            // 자식은 그 함수를 '무조건' 만들어라 설계(이를 상속,오버라이드라 한다) 받았으므로
            // >그 함수에는 override라 적는다
        }
        class Mage : Player
        {
            //int hp;
            public override void useSkill()
            {
                Console.WriteLine("마법사의 특별 스킬!!");
            }
        }
        class Archer : Player
        {
            //int hp;
            public override void useSkill()
            {
                Console.WriteLine("궁수의 특별 스킬!!");
            }
        }
        // 어라? 둘 다 같은디 > 모태클래스를 만들자


        // 상속 : 부모클래스에 있는 속성,기능을 자식클래스도 사용이 가능하다
        // 1. 같은 거 쓰면 귀찮아 2. 기능 적다 실수 할 수도 있고 3. 줄이 길어지는 기능을 줄이려고 

        // 캡슐화(은닉성) 1. 기능적인 부분에서의 캡슐화 : 어떤 기능적인 부분에서 동일한 부분을 처리하는 것
        //              2. 은닉적인 부분에서의 캡슐화 : 

        // 은닉성 :  public - 공공의 > 모두한테 열어준다 > 모두가 이용 가능 > 변형이 쉽다
        //          private - 나(이클래스)만 이용가능해 > 아무도 이용이 불가 > 값을 못 갖고 온다
        //          protected - 둘의 중간 버전. 상속받은 클래스까지만 수정이 가능함
        // 그래서 은닉성은? 위험한 행동같은 것을 외부에 알려주지 않는다. > 대신 Getter로 해


        // >> 우리는 앞으로 전부 private로 막아두기로 하자. 일단 쓸때마다 public으로 바꾸자


        static void Main_()
        {
            // 깃의 오류?
            // 선문강사님 : 깃을 먼저 형성하자, 그리고 그 자리에서 만들자
            // 영훈강사님 : 깃보다 일단 유니티를 개발하자, 나중에 공유가 되면 그때 하자(현언에서 주로 함)
            // 유니티에서 git을 올리는 방법
            // 프로젝트를 먼저 만들고 
            // =======================================
            // 1. Wizard 클래스를 만들어 다음 조건을 만족하세요:
            // 
            // - 멤버 변수: mp, intelligence (둘 다 int형)
            // - 생성자에서 각각 50, 20으로 초기화
            // - Main()에서 Wizard 객체를 생성하고 두 값을 출력
            //
            // [실행 결과]
            // 마법사의 MP: 50, 지능: 20
            // =======================================

            Wizard wizard = new Wizard();
            Console.WriteLine($"마법사의 MP: {wizard.mp}, 지능: {wizard.intelligence}");



            /*
             * OOP의 4대 원칙
               캡슐화 (Encapsulation): 관련 있는 변수와 함수를 하나로 묶어 객체라는 하나의 단위로 만들고, 내부의 정보를 외부에 공개하지 않고 은닉하는 것입니다.
                 상속 (Inheritance): 상위 클래스의 속성과 메서드를 하위 클래스가 물려받아 재사용하고 확장하는 것입니다.
               다형성 (Polymorphism): 하나의 객체나 메서드가 상황에 따라 여러 가지 다른 형태를 가질 수 있는 성질을 말합니다.
               추상화 (Abstraction): 여러 객체들이 공통적으로 가지는 본질적인 특징이나 기능을 추출하여 정의하는 것입니다. 
             >> 이런 식으로 외우기만 하면 안돼!! > 뭐가 유기적으로 연결되는지를 알아야지


             */

            // 추상화 : 공통 속성을 뽑아서 하나의 개념을 묶는것 > 클래스들의 공통된 속성, 기능을 차라리 하나의 클래스로 묶어서 나머지는 그냥 계승시키는


            Player player = new Player();
            player.hp = 10; // 어? 이거 접근이 가능하네? 
            Knight knight = new Knight();
            knight.hp = 10; // 부모가 가지고 있으면 자식도 같은 변수를 사용이 가능하다
            knight.move();
            knight.Attack();

            //Player plyer = new Knight(); 이건 불가능하다 > 부모는 자식을 상속하지만, 자식은 부모를 상속하지 않기 때문이다.

            Player plyer = new Player(); // 이것도 불가능하다. 추상클래스는 new를 못 쓰기 때문이다.

            // 숙제


        }

        

    }
        
        
    


    
}
