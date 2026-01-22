using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Practice251223
{
    
    class Important : Attribute
    {
        public string message;

        public Important(string massage)
        {
            this.message = massage;
        }
    }
    
    
    
    class Monster
    {
        [Important("Important")]
        public int hp;
        protected int atk;
        private float speed;
    }// 어떤 변수를 가졌는지 어떠한 자료형, 어떠한 지시자 인지 다 알수 있는 방법
    
    
    
    
    class Reflaction
    {

        // Reflaction 
        // 개념적인 존재
        // 클래스용  X-ray촬영 > 클래스의 모든 정보(메타 정보)를 가져올 수 있음
        // 그중에 attribute로 선언된 것은 전부 가져올 수 있음
        // 이것으로 게임 코드를 까볼 수 있다. 수정도 가능하다...
        
        static void Main()
        {
            //List<Monster> list = new List<Monster>();// F12로 해도 보이는 애가 있는 반면 전혀 안보이는 경우도 있다.
            Monster monster = new Monster();
            Type type = monster.GetType(); // Object의 함수 > 모든 객체의 부모이므로 전부 가지고 있음
            var fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance); // 클래스에 있는 모든 정보를 얻을 수 있다. 
            //GetFields(플래그(조건명))
            foreach (var field in fields) 
            {
                // 지시자
               
                string access = "protected"; //Isprotected는 존재하지 않아서 먼저 진행

                if (field.IsPublic)
                {
                    access = "Public";
                }
                else if (field.IsPrivate)
                {
                    access = "private";
                }
                //변수이름
                Console.WriteLine($"{access} {field.FieldType.Name} {field.Name}");
                // Single - float
                // int32 - int
                // int64 - long
                //  이것을 이용하여 인스펙터 나 어트리뷰트로 넘어가는 것

                var attributes = field.GetCustomAttributes();

                foreach (var attribute in attributes) 
                { 
                
                    Important important = attribute as Important;

                    if(important != null)
                    {
                        Console.WriteLine($"meta data : {important.message}");// 유니티 인스텍터, 특정 정보를 이용한 묶어주고, 그 것이 나타나면 바꿔줘 하는 방식
                    }
                }


            
            }

        }


   


    }
}
