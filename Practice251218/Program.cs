// Delegate => 대리자 (배우고 난 다음 잊어버리는 경우 top 1) 
// 사용법만 알면 어떻게 돌아가는지 관심이 사라진다.
// 사용 빈도는 굉장히 높다

// 게임을 만든다
// 공격버튼을 눌렀을때 플레이어가 공격을 시작해야함
//> 함수를 다른 함수에 넘겨받는다 > 함수 포인터, 함수의 타입화
// delegate -> 형식은 형식인데, 함수를 형식화한 느낌, 결국 매개 변수로 넘겨줄 수도 있음


namespace Practice251218
{
    class Program
    {
        delegate int Onclicked(); // 인트를 반환하고 매개변수가 없는 함수가 일종의 타입이 된 것 , 그 이름은 OnClick
                                  // 함수를 타입화 하겠다 > delegate 
                                  // 그럼 이걸 어떻게 사용?

        delegate void SortFunc(List<int> a);

        static List<int> ButtonEvent(SortFunc sortFunc/*어떠한 실행될 함수()*/)
        {
            List<int> ints = new List<int>();
            //배열이 있음, 정렬이 안되어 있는
            // 선택, 버블, 힙 등등등
            sortFunc(ints); //어떤 리스트를 받아서 함수로 보내서 거기서 정렬 하고
            // 어떠한 행동
            return new List<int>();// 난 후에 결과값 내보냄
        }
        static void ButtonEvent(Onclicked clickFunc/*어떠한 실행될 함수()*/)
        {
            // UI 로직 => 비쥬얼 , 코스메틱 로직

            //플레이어 공격 => 기능적 로직
            // 점프
            // >> 이 둘은 같이 있으면 안된다
            // >> 로직이 분리되어야한다 > 기능 로직은 따로 넘겨받자

            // 어떠한 실행될 함수()            
            //clickFunc(); // 함수 소환으로도 가능하고
            clickFunc.Invoke(); // deligate,action,func를 호출해라 > 델리게이트 방식은 Invoke로도 가능
        }
        
         //> 함수 소환 식으로 하면 
        // 그것이 콜백(CallBack) : 실행 주체는 따로 있고, 걔가 불러서 오는 방식
        // 퀵서비스 > 주소,연락처, 언제쯤 > 다시 연락 드릴게요 > 연락주면 택배를 받는
        // 연락처를 넘겨주고 약속을 잡고 약속에 따라 돌아오는 것
        static int Test()
        {
            Console.WriteLine("C#은 너무 쉬워");
            return 0;
        }
        static int Test2()
        {
            Console.WriteLine("C#은 너무 쉬워222222222222222");
            return 0;
        }
        static void M0in(string[] args)
        {
            Onclicked d = new Onclicked(Test); // 함수 변수
            d += Test2; //체이닝 > 객체를 넘겨주지 않고 플러스로 연결하는 방식
            
            ButtonEvent(d);
        }
    }
}
