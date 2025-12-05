namespace Practice20251205
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 배열 > 크기가 정해져야 함 > 고정배열
            //int[] (객체이름) = new int[]{};
            //int[] (객체이름) = new int[숫자];
            // 배열에는 값 추가가 불가능! > 변경이 불가능

            // 리스트 > 동적배열 > 배열이 늘어났다 줄었다
            // 원래는 고정배열인데 새로 선언하면서 덮어씌우는 방식임
            // List<타입명> (리스트 이름) = new List<int>()(생성자 호출 방식);
            int[] arr = new int[10];
            List<int> ints = new List<int>();
            // 이 꺽쇠 괄호는 뭘까 > 제네릭

            // 리스트의 특이점
            // 배열은 해당 인덱스에 값을 넣을 수 있다. 리스트는? 
            // 안에 배열이 없는데?
            // Unhandled exception. System.ArgumentOutOfRangeException: Index was out of range.
            
            arr[0] = 1;
            //ints[0] = 1;
            // 요소 추가
            ints.Add(0); //ints.Add(리터럴) > 처음에 Add를 해야만 함
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            ints.Add(4);

            ints[0] = 1; // 요소 수정 : 0번 인덱스 값을 바꾸겠다 > 이건 가능
            // 이러한 호출방식을 인덱서라 한다. 수정은 set
            Console.WriteLine(ints[2]); // 이렇게 출력 요청을 get이라 한다 
            ints.Add(ints[2]);

            // List는 Heap 메모리에 선언 > Add하는 순간 계속 갯수가 늘어나는 방식
            // 배열보다 리스트를 많이 쓰게 될 것

            // 요소 제거 Remove
            ints.Remove(3); //리스트내에서 괄호속 리터럴과 일치하는 요소를 찾아서 삭제하는 방식
            // 하나를 지우면 뒤에 있던 인덱스는 앞으로 당겨지고 
            // 단, 해당하는 요소가 없으면 해당 코드는 넘어간다. > 오류가 안 난다

            ints[2] = 5;

            // List의 또다른 기능
            //ints.AddRange(); // 범위추가
            ints.RemoveAt(3); // 요소삭제 > 해당 인덱스를 넣어서 그 인덱스 속 요소를 삭제
            //ints.RemoveAll(); // 전부 삭제 > Linq를 사용

            // 게임사가 아니어도 왠만한 중소기업 가면 이것을 구현하는 문제가 나온다 > 진짜 많이 나온다



        }

        class MyList
        {
            public int count; // 실제로 사용중인 데이터 개수
            public int capacity; // 메모리에 예약된 배열의 실제 크기
            int[] _data = new int[1];

            public void Add(int item)
            {
                // 방이 충분히 남았는지 확인
                if (count >= capacity)
                {
                    // 방이 남지 않았으면 이사
                    //  > 공간을 새로 만들고
                    int[] newArr = new int[count * 2];

                    //  > 새공간에 기존 데이터 복사
                    for (int i = 0; i < count; i++)
                        newArr[i] = _data[i];

                    // 새 배열로 주소 덮어 쓰기
                    _data = newArr;
                }

                // 새공간에 데이터 넣어주기
                _data[count] = item;
                // count == 5
                // _data[0] _data[1] _data[2] _data[3] _data[4] _data[count == 5]
                //   [0]      [1]      [2]      [3]      [4]         [item]

                count++;
            }
             //인덱서 > 인덱싱
            public int this[int index] 
            {
                get { return _data[index]; }
                set { _data[index] = value; }
            }

            public void RemoveAt(int index)
            {
                // 삭제하려는 대상 뒤에서 한칸씩 앞으로 떙겨주기
                for (int i = index; i < count - 1; i++)
                {
                    _data[i] = _data[i + 1];
                }

                count--;
            }
        }
    }
}
