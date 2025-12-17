namespace PracticeUnity20251217
{

    // CRTP(자기 참조 제네릭 패턴) > GameManager<T> where T : class
    class Monster { }
   
    //class MyListFloat
    //{
    //    private float capacity = 1; /*{ get { return _list.Length; } }*/ // 메모리에 예약된 배열의 실제 크기 > 칸 수
    //    private float count = 0; // 실제로 사용중인 데이터 개수 > 사용된 칸 수
    //    private float[] _list/*아파트의 주소를 담고있음*/ = new float[1]; // 1칸짜리 아파트 >  0번 인덱스 > 1개 

    //    // 인덱서는 일단 제외
    //    public float this[float index2]
    //    {
    //        get { return _list[index2]; }
    //        set { _list[index2] = value; }
    //    }

    //    public void Add(float item)
    //    {
    //        // 배열이 있다 > 뭔가를 넣어야 하는데 넣을 칸도 없다 > 어떻게 해야할까? 
    //        // 한 칸이 있다고 가정하자 > 데이터는 들어갈 수 있다
    //        // 근데 그다음부터는 안된다 > 칸을 늘려줘야한다 > 2배짜리 칸을 만들고 > 그걸 덮어씌우면 되는 것
    //        // 그럼 지금 몇칸을 가지고 있고, 몇칸을 사용했는지
    //        if (count == capacity) // 사용칸 수가 현재 전체 칸수와 같은지
    //        {
    //            // 방이 남지 않았다
    //            // > 새로운 아파트가 필요하다
    //            // 새로운 아파트는 강사가 '2배'로 늘리라 했다. > 보통 C#은 2배

    //            float[] newArr/*새 아파트 담을 공간 > 주소가 온다*/ = new float[(capacity * 2.0f)/* 현재 크기의 2배*/];
    //            // 왜 2배일까? 배열을 새로 만들고 새로운 배열을 남기고 > 그걸 GC가 계속 지우고 
    //            //>> 만일 2배라면 덜 자주 만들거니까 그래서 2배 물론 어느언어는 1.5배 하기도 한다만...
    //            // 여기까지는 아무도 없는 아파트 > 기존 아파트에 담아야 한다. > 이주작업 하자
    //            newArr[0] = _list[0]; // list 0번방 주민 이전
    //            // 문제는 앞으로 계속 커질건데 > 몇칸짜리인지 보고 그냥 다 이주시키면 되니까
    //            for (int i = 0; i < count; i++) // 사용한 만큼 이주
    //            {
    //                newArr[i] = _list[i]; // 새 아파트에 기존 아파트에 있던 데이터를 전부 복사
    //            }// 기존 아파트에서 새아파트로 이주완료

    //            _list = newArr;  // 기존 아파트의 주소를 새 아파트 주소로 바꿔서 마무리

    //        } // 기존 아파트의 거주민을 들고있는 새 아파트 
    //        _list[count] = item; // 아직 꽉 차 있지 않다면 > 여기에 넣자
    //        count++; // 사용갯수가 하나 늘었다 / 기존 : 0 > 0+1 > 1개로 늘었다.
    //        // 중간삽입 : 배열에 중간에 삽입 > 정해진 배열에서는 불가
    //        // 선형으로 계속 밀어줘야 함 > 시간 복잡도가 O(N)
    //        // 단, 공간이 남는다는 가정 하에서 Add는 O(1) > 늘릴때는 조금 다르다

    //    }

    //    public void RemoveAt(int index) // 한 칸씩 당겨오는 것 > 시간 복잡도 :O(N)
    //    {
    //        // 특정 인덱스 삭제
    //        _list[index] = 0;
    //    }
    //}
    
    class MyList<T>
    {
        private int capacity = 1; /*{ get { return _list.Length; } }*/ // 메모리에 예약된 배열의 실제 크기 > 칸 수
        private int count = 0; // 실제로 사용중인 데이터 개수 > 사용된 칸 수
        private T[] _list/*아파트의 주소를 담고있음*/ = new T[1]; // 1칸짜리 아파트 >  0번 인덱스 > 1개 

        //인덱서는 일단 제외
        public T this[int index] 
        {
            get { return _list[index]; }
            set { _list[index] = value; }
        }

        public void Add(T item)
        {
            // 배열이 있다 > 뭔가를 넣어야 하는데 넣을 칸도 없다 > 어떻게 해야할까? 
            // 한 칸이 있다고 가정하자 > 데이터는 들어갈 수 있다
            // 근데 그다음부터는 안된다 > 칸을 늘려줘야한다 > 2배짜리 칸을 만들고 > 그걸 덮어씌우면 되는 것
            // 그럼 지금 몇칸을 가지고 있고, 몇칸을 사용했는지
           if(count == capacity) // 사용칸 수가 현재 전체 칸수와 같은지
           {
                // 방이 남지 않았다
                // > 새로운 아파트가 필요하다
                // 새로운 아파트는 강사가 '2배'로 늘리라 했다. > 보통 C#은 2배
                 
                T[] newArr/*새 아파트 담을 공간 > 주소가 온다*/ = new T[capacity * 2/* 현재 크기의 2배*/];
                // 왜 2배일까? 배열을 새로 만들고 새로운 배열을 남기고 > 그걸 GC가 계속 지우고 
                //>> 만일 2배라면 덜 자주 만들거니까 그래서 2배 물론 어느언어는 1.5배 하기도 한다만...
                // 여기까지는 아무도 없는 아파트 > 기존 아파트에 담아야 한다. > 이주작업 하자
                //newArr[0] = _list[0]; // list 0번방 주민 이전
                // 문제는 앞으로 계속 커질건데 > 몇칸짜리인지 보고 그냥 다 이주시키면 되니까
                for(int i = 0; i < count; i++) // 사용한 만큼 이주
                {
                    newArr[i] = _list[i]; // 새 아파트에 기존 아파트에 있던 데이터를 전부 복사
                }// 기존 아파트에서 새아파트로 이주완료
               
                _list = newArr;  // 기존 아파트의 주소를 새 아파트 주소로 바꿔서 마무리

            } // 기존 아파트의 거주민을 들고있는 새 아파트 
            _list[count] = item; // 아직 꽉 차 있지 않다면 > 여기에 넣자
            count++; // 사용갯수가 하나 늘었다 / 기존 : 0 > 0+1 > 1개로 늘었다.
            // 중간삽입 : 배열에 중간에 삽입 > 정해진 배열에서는 불가
            // 선형으로 계속 밀어줘야 함 > 시간 복잡도가 O(N)
            // 단, 공간이 남는다는 가정 하에서 Add는 O(1) > 늘릴때는 조금 다르다

        }

        public void RemoveAt(int index) // 한 칸씩 당겨오는 것 > 시간 복잡도 :O(N)
        {
            // 특정 인덱스 삭제
            for (int i = index; i < count - 1; i++)
            {
                _list[i] = _list[i + 1];
            }
            count--;
        }
    }
    // 나이트가 생성될 때 마다 ID를 부여하고 싶다.
    // 0부터 쭉 증가하면서
    // 제일 먼저 생성된 ID는 0
    class Knight
    {
        // Static : 정적
        // 멤버변수(필드) :  클래스 스코프 바로 밑에 바로 속한 변수
        //                 메소드 스코프가 아닌 클래스 스코프에 어느 스코프에도 속해있지 않은 변수
        // 지역변수 : 멤버 함수 밑에 있는 변수 
        // 멤버 함수 : 클래스 스코프에 있는 함수
        // 지역 함수 : 멤버 함수 안에 있는 함수
        void Test() // <- 멤버함수
        {
            int a = 1;

            void Test2(){ //<- 지역함수

            }
        }

        public int hp; // <- 멤버변수, 필드
        public int atk;
        public string name;
        public int id; // 객체들은 각각 id를 가질 것이다

        public Knight()
        {
            this.id = count; // id를 생성해 주세요
            count++; // 횟수는 늘려주세요
        }

        // 멤버변수를 가져오는 방법
        // 1. 인스턴스를 만들고 그 변수를 가져온다
        // 2. static을 사용 > 인스턴스가 필요없는 변수

        public static int count; // 설계도에 그냥 있어서 > 클래스 종속 관계임 > 인스턴스가 필요없음
        // 이 변수는 다 공유하는 것 > 단일화된 변수를 만드는 이유

        // 스태틱 함수
        // 스태틱 클래스 : 인스턴스를 만들 수 없는 클래스 > 스태틱 함수와 스태틱 변수를 넣는다
        // >> 이것이 utils

    }

    static class Utils
    {
        static int hp;
        static void Add()
        {

        }
    }

    



    // 자 이번엔 float버전으로 만들고 싶다, Monster를 만들고 싶다 > 아 일일이 만들어야해 > 제일 근본것으로 바꾸자
    // object로 바꾸면 되겠네 > 문제는 박싱 > stack에 있는 객체를 heap에 저장 했다가 다시 Stack으로 가져오는 방식
    // 참조형식이 주로 이런 방식 >>> 그래서 개발된 것이 제네릭!
    // <T : 이 자리엔 어떤 타입으로 할지 선언> 타입은 나중에 지정하겠다


    // where : 아무거나 들어오면 안된다 > class(모든 참조형식), struct(모든 값 형식)등으로 제한 가능
    // :  이 부분에 들어가는 것은 그 타입의 성격을 표현 > 그래서 그것을 대표하는 전체 타입으로 표현
    // 단 강제하는 방식으로도 가능 > 상속받은 녀석만 가능하게 하는 
    // 그리고 자기 것 형태가 아니면 못 들어오게 할 수도 있다. > 상속받아서 들어와라
    //  : new() 이 형식도 있음 > 새로 형성하고자 할 때 > 참조형식에 대한 조건에서 생성자를 포함한 것은 아님
    //  그래서 class, new()방식으로 작성해야 생성자가 가능해짐
    // 
    // Singleton Class는 T 자리에 자기 자식을 재귀적으로 넣어준다
    // 목적 : 캐스팅을 안 해도 됨
    // CRTP방식

    class Program
    {

        void Test2()
        {

        }

        static void Main(string[] args)
        {
            #region 배열 > 리스트 > 함수 구현 > 제네릭 

            // 배열
            int[] arr = new int[10];
            // 값 형식의 배열의 이름은 stack에  실제 모습은 heap에 > stack에 있는 것은 바로가기 같은 것  
            // 하지만 인스턴스형식의 배열에는 heap에도 주소값이 들어있음 그걸 통해 실제 내용으로 이동
            Monster[] list = new Monster[10];
            // 문제는 배열은 크기가 고정되어 있음 > 비유하자면 콘크리트 아파트 같은
            // 그래서 그 배열을 늘리는 것 > 배열을 늘리고 새로운 것을 넣고 그걸 그 아파트로 덮어씌우는 것
            List<int> ints = new List<int>();
            ints.Add(1); 
            ints.Add(2);
            ints.Add(3);
            ints.Add(4);
            ints.Add(5);

            // 큐 함수 만들기
            // 스택 함수 만들기

            // 리스트 만들기
            // 1. 리스트는 동적 배열이다
            // 방식 : 
            #region obj > var > 제네릭
            MyList<int> myList = new MyList<int>();
            myList.Add(1);
         

            // var : 타입 추론 > 리터럴 값에 대하여 그 타입을 확인하여 컴파일 시 치환할 것을 체크하는 것
            // 실존하는 타입이 아님 > C#개발자들이 타입 일일이 가져오기 귀찮으니까 그래서 개발됨
            // 그래서 배열이나 list를 var로 쓸 수 없음
            var a = 99;
            var s = "sjdjd";
            //var ddd = new MyList();
            // 제네릭 : 꺾쇠괄호 안에 있는 객체로 지정하겠다. > 나중에 형식을 받아서 그걸 사용하겠다.
            // >> 싱글톤 , 범용적 사용
            MyList<string> list2 = new MyList<string>();

            // 제네릭은 주로 <T>형식으로 작성 > 제네릭은 여러개도 작성이 가능하다.
            // 보통 두개면 Key, Value 이렇게 적혀있기도
            // 제네릭이 여러개 썼으면 > 알아보기 어렵기 때문에 그냥 써라.(가독성)
            MyClass<int> t = new MyClass<int>();
            t.a = 1;

            MyClass<string> t2 = new MyClass<string>();
            t2.a = "2";

            MyList<int> list3 = new MyList<int>();
            list3.Add(1);


            Test<int> num = new Test<int>();
            num.a = 1;

            Test<string> str = new Test<string>();
            str.a = "YOU";
            #endregion

            MyList2<int> _newList = new MyList2<int>();
            _newList.Add(2);

            //MyList<int> mylist = new(); // 안 받아준다
            #endregion

            #region 실습(1)
            // int버전 - 10, 20 추가 후 갯수와 인덱스 1의 값을 출력
            // string버전 - "Sword", "Potion"을 추가한 뒤, 갯수와 인덱스 0의 값을 출력
            Inventory<int> inventoryInt = new Inventory<int>();
            inventoryInt.Add(10);
            inventoryInt.Add(20);
            Console.WriteLine($"인벤토리 속 아이템 갯수 : {inventoryInt.Count()}");
            Console.WriteLine($"{inventoryInt[1]}를 사용하셨습니다.");
            Inventory<string> inventoryString = new Inventory<string>();
            inventoryString.Add("Sword");
            inventoryString.Add("Potion");
            Console.WriteLine($"인벤토리 속 아이템 갯수 : {inventoryString.Count()}");
            Console.WriteLine($"{inventoryString[0]}를 사용하셨습니다.");
            #endregion

            
            Knight knight = new Knight();
            knight.hp = 10;
            //knight.id //? >작동안함 
            //Knight.id = 10; // 이렇게 써야함

            Knight knight1 = new Knight();
            Knight knight2 = new Knight();  
            Knight knight3 = new Knight();

            Console.WriteLine(knight.id);
            Console.WriteLine(knight1.id);
            Console.WriteLine(knight2.id);

            Program p = new Program();
            p.Test2();

            const int a2= 10; // 전역변수는 가급적 자제한다 > 사라지지 않고 계속 메모리를 차지하기 때문이다
            
        }
        #region

        static int b2 = 20; // 계속 메모리에 남는다

        class MyClass<T>
        {
            public T a;

        }
        
        class Test<T>
        {
            // 제네릭 변수
            //Test<int> = 객체
            // 그 객체에 int값 넣기
            public T a;

            //Test<string> = 객체
            // 그 객체에 string값 넣기

            static void Test2<T> (T value)
            {
                Console.WriteLine($"입력된 값은 {value}");
            }

        }

        class protram
        {  
            
            // 제네릭 함수 > 어떤 타입인지는 모르지만, 일단 들어오고 해보자
            

            

        }
        // list를 다시 만들어라 > 제네릭 방식으로
        // Add, RemoveAt, 
        class MyList2<T>
        {
            private int currentAvailable = 1;
            private int usedSpace = 0;
            private T[] _list = new T[1];
            
            public void Add(T value){

                if(usedSpace == currentAvailable)
                {
                    T[] _newList = new T[currentAvailable * 2];

                    for(int i = 0; i < usedSpace; i++)
                    {
                        _list[i] = _newList[i];
                    }

                    _list = _newList;

                }

                _list[usedSpace] = value;
                usedSpace++;

            }

            public int RemoveAt(int index)
            {
                return -1;
                 
                

            }



        }

        #endregion
        // 인벤토리라는 이름의 제네릭 클래스, 3개의 함수 구현
        // int Count() - 현재 인벤토리에 아이템 갯수를 반환
        // void Add(T item) -> 인벤토리에 아이템을 추가
        // T Get(int index) > 인벤토리에서 해당 위치(index)의 아이템을 가져오기 <= 인덱서와 같음
        // 인덱서를 따로 만들자
        class Inventory<T>
        {
            private int available = 1;//남은 자리 갯수
            private int used = 0;//쓴 자리 총 갯수
            private T[] inventory = new T[1]; //인벤토리 장소

            public int Count() 
            { 
                 return inventory.Length;
            }
            public void Add(T item)
            {
                if(used == available)
                {
                    T[] _inventory = new T[available * 2];

                    for(int i = 0; i < used; i++)
                    {
                        _inventory[i] = inventory[i];
                    }
                    inventory = _inventory;
                }

                inventory[used] = item;
                used++;

            }

            public T this[int index]
            {
                set { }
                get { return inventory[index]; }
            }
            
            

        }

    }
}
