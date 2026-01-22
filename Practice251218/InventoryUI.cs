using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Practice251218
{
    class InventoryUI
    {
        // 이 클래스 내부에 인벤토리가 존재한다고 가정 > 배열이든 리스트든
        public static void FindItem(Action hook)
        {
            // 전처리
            hook?.Invoke(); // 아이템을 각각 찾는 방식
            // 후처리
        }
    }


    public class InputManager
    {
        // 기존 방식 : Update에서 지속적으로 확인하는 방식
        // 단점 : 모든 인풋 다 모일 건데.. 굉장히 리소스를 많이 먹어서 점점 느려짐
        // >> 콜백을 이용해서 키를 눌렀을때 어떤 함수가 실행되게 해보자

        public static Action Getevent = null; // 아무것도 등록되어있지 않다 > null
                                        // 옵저버 패턴, 리스너 패턴 : 우리는 구독되어있는 걸 들고 있다가 누군가 눌렀을때 그걸 알려주겠다
        public void Start()
        {
            // 한 30초 뒤에 Broadcast() 실행시킴
        }
        
        // 비유하자면 이것이 방송국같은 것

        public void BroadCast()// 이걸 호출하게 하면 안된다
        {
            
             Getevent.Invoke(); // 그럼 KeyAction을 브로드캐스트 하자!!
            
        }
    }

    class Prog0ram
    {

        static void Test()
        {

        }


        static void M0ain(string[] args)
        {
            InventoryUI.FindItem(() => Console.WriteLine("포션 찾기"));
            InventoryUI.FindItem(() => Console.WriteLine("검 찾기"));
            InventoryUI.FindItem(() => Console.WriteLine("방패 찾기"));
            // 얘를 왜 쓸까? 함수 포인터를 왜 받아왔을까? 
            // 함수가 고정되어 버림 > 한가지 기능만 넣어놨다면
            // 함수를 어떻게 넘겨 받을까 > 그래서 필요한 것이 델리게이트
            // 2. dll파일로 만들었다. 그걸 함수를 호출할 수는 있다. > 내부의 기능을 바꿀 수 있다 > 그래서 델리게이트
            // 남들은 못 고치는데 함수는 호출해서 안에서 고칠 수 있는 방식

            // 유니티에서 자주 쓰는 방식

            InputManager inputManager = new InputManager();

            InputManager.Getevent += Test; // 구독을 신청해놓고, 브로드캐스트 되면 Test를 실행하겠다
            // 구독 +
            // 구독취소 -

        }



    }
    class Player
    {
        static void PlayerLog()
        {

        }

        static void M0ain(string[] args)
        {
            InventoryUI.FindItem(() => Console.WriteLine("포션 찾기"));
            InventoryUI.FindItem(() => Console.WriteLine("검 찾기"));
            InventoryUI.FindItem(() => Console.WriteLine("방패 찾기"));
            // 얘를 왜 쓸까? 함수 포인터를 왜 받아왔을까? 
            // 함수가 고정되어 버림 > 한가지 기능만 넣어놨다면
            // 함수를 어떻게 넘겨 받을까 > 그래서 필요한 것이 델리게이트
            // 2. dll파일로 만들었다. 그걸 함수를 호출할 수는 있다. > 내부의 기능을 바꿀 수 있다 > 그래서 델리게이트
            // 남들은 못 고치는데 함수는 호출해서 안에서 고칠 수 있는 방식

            // 유니티에서 자주 쓰는 방식

            InputManager inputManager = new InputManager();

            InputManager.Getevent += PlayerLog; // 구독을 신청해놓고, 브로드캐스트 되면 Test를 실행하겠다


        }

    }


    // event
    class Wrapping
    {
        static Action Test2;
        delegate void Test();
        event Test test;

        event Action ea;

        Func<int> test3;

        event Func<int> ef;

        static event Action tttt
        {
            add => Test2 += value;

            remove => Test2 -= value;
        }

        static void Moon()
        {
            //tttt += Test;
        }



        class PopupMenu
        {
            public static event Action<string> notified;

            public static void Notify(string id)
            {
                Console.WriteLine("[Popup] : " + id);
                if (notified != null)
                    notified.Invoke(id);
            }

            // 파괴될때 구독취소도 동시 진행 > 명시적으로 구독취소하기 전까지는 구독은 취소안됨 > 메모리 누수 유의

        }

        class Prugram
        {
            static void Log(string id)
            {
                Console.WriteLine("[Log] "+ id);
            }


            static void Marin()
            {
                PopupMenu.notified += Log;
                PopupMenu.Notify("Setting");
                PopupMenu.Notify("shop");
            }


        }




    }
}
