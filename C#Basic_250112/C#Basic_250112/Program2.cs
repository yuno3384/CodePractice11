using System.Runtime.CompilerServices;

namespace C_Basic_250112
{
    internal class Program2
    {
        class Player// 속성(field == 멤버변수) 기능(멤버함수)
        {

        }

        sta class Knight
        {
            public int hp;
            public int atk;

            static public void Move()
            {
               
            }
            public void Test()
            {

            }

        }

        

        static void Main(string[] args)
        {


            //2장. 객체지향
            // 클래스 

            // 절차지향 > 함수지향(procedure programming)
            // 함수 중심으로 돌아가는 것
            // 함수의 순서가 중요해진다  > 순서가 어그러지면 다 망가진다
            // 알아서 원하는 것에 따라서 해줘

            // 객체 지향 : OOP
            // 모든 게 다 객체다.
            // class 중심으로 돌아가는 방식
            // class 만드는 법
            // class class명

            // 나는 Knight를 받아서 객체를 만들거야
            Knight k = new Knight(); // Stack에서 생성 > Heap에서 그 주소에 요소가 생김 > 인스턴스를 Heap의 참조(주소의 첫번째 값)를 담게 됨 > k는 주소값을 갖게 됨
            // 담아주지 않으면 그냥 heap에서 사라짐
            // object는? Stack에서 생성 > Heap에서 그 주소에 그 요소가 생김 > 인스턴스를 Heap의 참조(주소의 첫번째 값)를 담게 됨 > o는 주소값을 갖게 됨
            int a = 0;//int는 stack에서 형성, 값을 가지고 있음
            //k.Move(); //객체의 참조로 heap에 접근 > 안에 들어있는 함수를 실행
            k.hp = a;
            // static은 heap에 생기는 것이 아닌 다른 방식임
            Knight.Move();
            // static을 붙여야하는 이유
            Program2 p = new Program2();
            p.Test();
            //static이 있으면 그 class로 직접 접근하는 것
            // 그 이외는 반드시 객체를 만들고 그 안에 됨
            
            Knight knight = new Knight();
            Knight knight2 = knight;//주소도 일종의 값 > 그 둘이 복사된 것 : 참조 복사

            int a2 = 10;
            int b = a2;

            // 주소도 일종의 값 > 그 둘이 복사된 것 : 참조 복사 > 
            // 얕은 복사 : Object.MemberwiseClone > 값 형식은 복사됨 / 변수가 객체일 경우 그 주소를 복사해서 새로운 객체에 똑같이 전달
            // 깊은 복사 : other.IdInfo = new IdInfo(IdInfo.IdNumber); 객체를 새로 만들어서, 그 주소가 서로 다름


            // 생성자
            Knight2 k1 = new Knight2();
            Knight2 k2 = new Knight2(10,20);

            // struct도 생성자가 가능

            // 멤버함수,변수 : class 내부에 있는 함수,변수
            // 지역함수,변수 : 멤버함수 속 함수,변수

            // static
            // 정적 > 객체가 필요없는 변수/ 함수 > 객체를 만들면 오류
            Knight2.count++;

            // 싱글톤  : 객체 한곳에서만 처리
            Knight2 k3  = Knight2.Instance;
            Knight kt = new Knight();
            kt.Test(); // Util

            //public static class : 유틸성 클래스

            // 추상 클래스도 역시나 객체 형성 불가 - 추상화 함수가 하나라도 존재함
            // 1. 추상 함수 - 완성이 안되어 있는 함수, 구현이 안됨 > 구현이 불가
            // 2. 가상 함수 - 

            // OOP : 
            // 추상화 - 복잡한 시스템에서 핵심적인 개념이나 기능만을 모델링하고, 불필요한 세부 사항은 감추어 단순화하는 객체 지향 프로그래밍의 중요한 원칙이다
            // 캡슐화 -  데이터(속성)와 그 데이터를 처리하는 메서드(기능)를 하나의 단위인 클래스로 묶고, 실제 구현 내용 일부를 외부에 감추어 보호하는 객체 지향 프로그래밍(OOP)의 핵심 원칙
            // 다형성 - 하나의 인터페이스나 클래스가 다양한 형태로 동작할 수 있도록 하는 객체 지향 프로그래밍(OOP)의 핵심 원칙
            // 상속 - 기존 클래스(부모 클래스)의 속성과 기능을 그대로 물려받아 새로운 클래스(자식 클래스)를 만드는 객체 지향 프로그래밍(OOP)의 핵심 원칙
        }



        struct Position
        {
            public Position()
            {

            }
            public void Test()
            {
                //복잡한 함수를 하지 말아달라. 다만, 가능은 하다
            }
        }

        class Knight2
        {
            int hp;
            int atk;
            public static int count = 10;

            private static Knight2 instance = new Knight2();

            public static Knight2 Instance { get { return instance; } }

            public Knight2() : this(10, 20)// Constructor(기본 생성자)
            {
                // Knight 타입의 객체를 힙에 생성
                // return Knight타입의 객체의 주소를 반환
                Console.WriteLine("SJDSJDFJFJF");//이렇게 들어간다고 기본 생성자가 불가능한 게 아니다.
            }

            // 생성자 오버로딩 - 사용자 정의 생성자 
            // 생성자 체이닝 : 체이닝한 생성자가 있으면 그것을 거쳐서 그 다음 것을 실행
            public Knight2(int hp, int atk)
            {
                // 기본 생성자를 생성해야만 사용가능 > 명시적으로 정의해야함
                // 만일 생성을 안하면 this는 오로지 오버로딩된 생성자를 가리킨다
                this.hp = hp;
                this.atk = atk;
                Console.WriteLine("StttttttF");
            }

            public Knight2(int hp) : this()
            {
                // 기본 생성자를 생성해야만 사용가능 > 명시적으로 정의해야함
                // 만일 생성을 안하면 this는 오로지 오버로딩된 생성자를 가리킨다
                this.hp = hp;
                this.atk = atk;
                Console.WriteLine("StttttttF");
            }
        }


    }



}

