using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace JobOOP
{

    class Program
    {
        /*

        문제)
        당신은 동물원 시스템을 만들고 있는 개발자입니다.
        동물들은 공통적으로 이름을 가지고 있으며, 각자 고유한 울음소리를 냅니다.
        부모 클래스 Animal은 추상 클래스이며, 모든 동물은 이 클래스를 상속받아야 합니다.

        구현 조건
        1. 추상 클래스 Animal을 만드세요.
        - string Name 필드를 가짐
        - 생성자에서 "안녕하세요, 저는 [이름]입니다" 출력
        - abstract void MakeSound(); 추상 메서드를 선언
    */
        public abstract class Animal
    {
        protected string name;
        public Animal() { 
            Console.WriteLine($"\"동물원에 새로운 가족이 왔어요\"");
          // 자식의 객체가 생성될때 부모에게 상속을 받기 위해 부모의 생성자가 먼저 생성, 이후에 자식의 생성자가 생성된다.
            }
        public abstract void MakeSound();
            
    }
    /*
    2. 다음 세 개의 클래스를 만들고 Animal을 상속받으세요.
    - Dog → "멍멍!" 출력
    - Cat → "야옹~" 출력
    - Cow → "음머~" 출력
    ※ 각 동물의 소리는 MakeSound() 메서드 오버라이딩을 통해 구현합니다.
    */
    
    public class Dog : Animal
    {
      public Dog() // 자식의 생성자에 인자를 추가하면 > 기본생성자가 가려짐 > : base(name)이라 적거나 부모에게 인자 추가한 생성자를 만들거나
            {
                name = "댕댕이";
                Console.WriteLine($"\"안녕하세요, 저는 [{name}]입니다\"");
            }
            
            public override void MakeSound()
        {
          Console.WriteLine("\"멍멍!\"");
        }
    }

    public class Cat : Animal
    {
        public Cat()
        {
            name = "나비";
            Console.WriteLine($"\"안녕하세요, 저는 [{name}]입니다\"");
        }

        public override void MakeSound()
        {
            Console.WriteLine("\"야옹~\"");
        }
    }

    public class Cow : Animal
    {
        public Cow()
        {
            name = "해피카우";
            Console.WriteLine($"\"안녕하세요, 저는 [{name}]입니다\"");
        }

        public override void MakeSound()
        {
            Console.WriteLine("\"음머~\"");
        }
    }
        /*
        3. Main() 함수에서 각각의 동물을 생성하고, MakeSound() 를 호출하세요.


        [출력예시]
        안녕하세요, 저는 댕댕이입니다
        멍멍!

        안녕하세요, 저는 나비입니다
        야옹~

        안녕하세요, 저는 해피카우입니다
        음머~

         */

        static void Main()
        {
            Dog dog = new Dog();
            dog.MakeSound();
            Cat cat = new Cat();
            cat.MakeSound();
            Cow cow = new Cow();
            cow.MakeSound();
        }
    }
}
