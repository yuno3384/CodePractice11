using System.Collections;
using System.Linq;
using System.Runtime.InteropServices;

namespace Practice251215
{
    internal class Program
    {
        #region IEnumerator
        class MyArrayEnumerator : IEnumerator // 인터페이스 멤버를 구성하지 않으면 오류
        {
            public int Current => throw new NotImplementedException();// 현재 위치에 

            object IEnumerator.Current => Current;

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public bool MoveNext() //다음 위치로 이동 > 없으면 false
            {
                throw new NotImplementedException();
            }

            public void Reset() // 초기 상태로
            {
                throw new NotImplementedException();
            }
        }
        
        // 인터페이스(무언가를 조작하기 위한 방법 예)스위치 > 메소드만을 모은 것) 상속 
        class MyArray : IEnumerable // 오버라이딩 : 상속관계에서 부모의 함수를 재정의 vs 오버로딩 : 함수 시그니쳐를 변경
        {

            
            // 접근 한정자 : 접근하는 것
            // private : 클래스 내에서만 가능
            // public : 외부에서도 접근 가능
            // 우리 타입 내부에 있는 _container 순회
            private int[] _container = { 1, 2, 3, 4, 5 }; // 외부에서 접근 불가능
                                                          // public으로 변경? > 그러면 노출되니까 > X
                                                          // >> 정보를 노출하지 않고 그걸 제공하는 메소드를 만들자.
                                                          // 정보에 접근할 수 있는 객체
                                                          // > 그 화살표 역할을 하는 것이 바로 IEnumerator
                                                          // 절차지향 : 필드랑 메소드가 분리되는 문제 > 그걸 묶자 class로 
                                                          //          >> 조작 맘대로 못하게 하자 >>> 이것이 캡슐화

            //Gets the element in the collection at the current position of the enumerator.
            // > 오버라이딩

            // MyArray를 순회할 수 있는 열거자를 반환한다. > Enumerator 반환 필요
            public IEnumerator GetEnumerator()
            {
                // Inumerator 타입의 객체를 반환한다.
                throw new NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
        #endregion
        #region LinkedListNode를 실제로 구현
        class MyLinkedListNode
        {
            // 자료구조를 정의해보자
            // 노드를 정의하자
            private int _value; // 실제 데이터

            // 이전, 다음 자료로 갈 수 있는 주소값을 정의
            //private List<string> BeforeValueAddress;
            //private List<string> NextValueAddress;

            private MyLinkedListNode? beforeNode; //  노드를 저장 > 주소를 저장
            // ? : 널러블 > 참조타입 > C# 8.0때 등장 > null로 피해가 막심하여...
            // null 안전성 검사가 언제나 필요 > 아, 그냥 좀 만들어줘! > ㅇㄱㅇ
            private MyLinkedListNode? AfterNode;
        }
        #endregion

        
        /// <summary>
        /// 사용처 : linear List속 어떤 값을 이진검색
        /// </summary>
        /// <returns>찾았다면 true, 못 찾으면 false</returns>
        /// <remarks>사전조건 : list는 정렬되어야 한다</remarks>
        public static bool BinarySearch(List<int> list, int key)
        {
            // 탐색단계 > [시작 , 끝] or [시작, 끝)
            //bool isCorrect = false;
            int endIndex = 0;
            int startIndex = list.Count;
            
            // 1. 범위의 중앙값을 찾는다 > 모든 값 / 모든 갯수(X)
            // 가장 낮은 수 + 가장 낮은 수 / 2
           
            
            Console.WriteLine();
            int midValue = (startIndex + endIndex) / 2;
            int tryCount = 0;
            // 2. 중앙값과 key를 비교하여 범위를 조정한다
            // 유효한 범위 : start < end
            while (startIndex < endIndex)
            {
                if (midValue == key)
                {
                    Console.WriteLine($"{tryCount}회 시도 끝에 찾았습니다.");
                    return true;
                }
                else if (list[midValue] > key)
                {
                    startIndex = midValue + 1;
                }
                else if (list[midValue] < key)
                {
                    endIndex = midValue;
                }

                midValue = (startIndex + endIndex) / 2;
            }
            
           return false; 
        }

        /// <summary>
        /// list에서 key보다 크거나 같은 첫번째 원소의 인덱스를 반환한다.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="key"></param>
        /// <returns>key보다 같거나 큰 첫 인덱스 원소의 인덱스, 찾지 못했다면 list의 마지막 인덱스를 </returns>   
        /// <remarks>사전조건 : list는 정렬되어야 한다</remarks>
        public static int LowerBound(List<int> list, int key)
        {
            int startIndex = 0;
            int endIndex = list.Count;

            int midIndex = (startIndex + endIndex) / 2; // 이 공식은 오버플로우가 발생할 수도 있다.
            midIndex = startIndex + (endIndex - startIndex) / 2;
            // 시작지점에서 중간지점까지를 더한다.

            int result = list.Count;

            while (startIndex < endIndex)
            {
                if (list[midIndex] < key)
                {
                    startIndex = midIndex + 1;
                }
                else if (list[midIndex] > key)
                {
                    result = Math.Min(result,midIndex); //정답일 수도 있으니 저장 
                    // 작은 값을 찾는 이유 > 맨 첫값이니까
                    endIndex = midIndex;
                }
                
            }// 하지만 이진검색은 찾으면 끝이지만 lowerBound는 그 첫번째 값이라 계속 찾아야 한다.
            return result;
        }
        // UpperBound : 범위 중 특정 값 보다 큰 첫번째 원소 >> 중복된 값이 얼마나 있는지 범위를 알게 된다
        /// <summary>
        /// list에서 key 보다 큰 첫번째 원소
        /// </summary>
        /// <param name="list"></param>
        /// <param name="key"></param>
        /// <returns>int index</returns>
        /// <remarks>사전조건 : list는 정렬되어야 한다</remarks>
        public static int UpperBound(List<int> list, int key)
        {
            int startIndex = 0;
            int endIndex = list.Count;

            int midIndex = (startIndex + endIndex) / 2; // 이 공식은 오버플로우가 발생할 수도 있다.
            midIndex = startIndex + (endIndex - startIndex) / 2;
            // 시작지점에서 중간지점까지를 더한다.

            int result = list.Count;

            while (startIndex < endIndex)
            {
                if (list[midIndex] < key)
                {
                    startIndex = midIndex + 1;
                }
                else if (list[midIndex] > key)
                {
                    result = Math.Max(result, midIndex); //정답일 수도 있으니 저장 
                    // 작은 값을 찾는 이유 > 맨 첫값이니까
                    endIndex = midIndex;
                }

            }// 하지만 이진검색은 찾으면 끝이지만 lowerBound는 그 첫번째 값이라 계속 찾아야 한다.
            return result;
        }

        static void Main(string[] args)
        {
            #region 1.IEnumerator를 사용한 foreach
            //MyArray myArray = new MyArray();
            //List<int> fibNumbers = new() { 0, 1, 1, 2, 3, 5, 8, 13 }; //IEnumerable을 구현했다.
            ////for(int i =0; i)
            //foreach (int element in fibNumbers)
            //{
            //    Console.Write($"{element} ");
            //}
            //// Output:
            //// 0 1 1 2 3 5 8 13



            //// foreach statement cannot operate on variables of type 'type1'
            //// because 'type2' does not contain a public definition for 'identifier'

            //IEnumerator<int> fibEnumerator = fibNumbers.GetEnumerator();
            // current : 지금 가리키고 있는 데이터, 위치                                      
            // moveNext : 다음 요소로 넘어가니? > 성공하면 true, 끝까지 가면 false > 직접 구현


            //// foreach (element - variable in Enumerable-type){ body }


            //IEnumerator enumerator = myArray.GetEnumerator();
            //#region 구조(1) - 단문 작성법
            ////int fibNumber = (int)enumerator.Current; //이것이 박싱과 언박싱 > 타입이 object이다.
            ////Console.WriteLine(fibNumber); // 값은 1이겠지?
            ////enumerator.MoveNext();
            ////fibNumber = (int)enumerator.Current; //이것이 박싱과 언박싱 > 타입이 object이다.
            ////Console.WriteLine(fibNumber);
            ////enumerator.MoveNext();
            //#endregion
            //#region 구조(2) 반복부 파악 및 반복문화
            //// >> 이거 세개 반복중이니 > 반복문으로 가자
            //while (true)
            //{
            //    int fibNumber = (int)enumerator.Current; //이것이 박싱과 언박싱 > 타입이 object이다.
            //    Console.WriteLine(fibNumber); // 값은 1이겠지?

            //    if (enumerator.MoveNext() == false) // 이것이 Coroutine과 연결된다
            //    {
            //        break;
            //    }
            //}
            //#endregion
            //// GetEnumerator에 들어가서 확인 후 시작하기 때문에 그 메소드가 없으면 쓰지를 못한다
            //foreach (int fibNumber in fibNumbers)
            //{
            //    Console.WriteLine(fibNumber);
            //}

            //foreach (int numbers in myArray)
            //{
            //    Console.WriteLine(numbers);
            //}
            #endregion
            #region 1. List<T>
            // <int> : Generic
            // int의 List
            // int[]와 유사
            // List는 참조타입 
            List<int> myList; // null이 저장됨 
            myList = new List<int>(); // 생성자를 호출 > 타입을 파악하기 어려움 > 가급적 이것을 사용토록
            myList = new(); // 축약형  > 객체의 정의와 동시에 > 타입이 보이니까 
            #region 강사님 조언 : 개발자로써의 자세(4) 무조건적 수용을 경계
            // 뭐가 더 가독성있는지 
            // 놀랍게도 모두가 설명하는 것은 다 다르다 > 무조건적인 수용은 결국 지식충돌이 일어난다.
            // 초급자면 이 미묘한 차이를 독파하기 어렵다. 멘토가 필요하다 > 명확한 자신의 기준이 필요하다.
            // 이 이후부터는 이 모든 것을 혼자서 해나가야 한다.
            // 학습의 방법을 수련해 나가라
            #endregion
            #region 내장타입의 한계와 구조체의 등장 
            // 구조체 : struct(값 타입 / 여러개의 내장타입, 내가 만든 타입을 섞은 것) > 내장타입 하나로는 구현하기 어렵다.
            // 예) 던전앤파이터 - 캐릭터 - 귀검사  > 내장타입들 이걸로는 표현이 어려움
            // 그걸 구현해보자 > struct(구조체) >> class로 이것이 확장 
            // 귀검사 -
            // (현재체력(int)/최대체력(int)),
            // 물리공격력(int),
            // 마나(현재마나(int)/ 최대마나(int)),
            // 물리방어율(float),
            // 이동속도(float),
            // 공격속도(float), > 부동소수점의 오류에 의해 115/10으로 저장될수도
            // 스킬(스스로 개발)
            // 이것을 시스템 기획자가 개발 > 데이터 테이블로
            // 레벨 시스템 > 기본 스탯양이 달라진다
            // 현재체력치와 최대체력치가 다름
            // 필요 요구 경험치량 > 요구치를 초과시 레벨업 > 그다음 레벨의 요구치로 리셋
            #endregion

            // 읽기 : 특정위치를 읽는법 > []
            //Console.WriteLine(myList[2]); //10
            // 검색 :
            // Find() / FindAll() / FindIndex() / FindLast() / FindLastIndex / 
            // IndexOf() : 인덱스를 알려줌 / 
            Console.WriteLine(myList.IndexOf(14)); // 3 > 세번재 인덱스니까
            Console.WriteLine(myList.IndexOf(21)); // -1 > 없으면 -1을 반환

            // 삽입 > 데이터가 있어야 읽지!
            // - Insert() : 어느 인덱스에 어떤 값을 추가 / Add() : 마지막 인덱스에 어떤 값을 추가
            //- InsertArray() : 어느 인덱스에 어떤 List를 추가 / AddArray() : 마지막 인덱스에 어떤 List를 추가
            myList.Add(3);//[3]
            myList.Add(2);//[3][2]
            myList.Add(14);//[3][2][14]

            // [3][2][10][14][20]
            myList.Insert(2, 10);
            myList.Add(20);

            // 삭제
            // Remove() : 특정값을 찾아 지움 / RemoveAll() / RemoveAt(): 인덱스를 기반으로 삭제 / RemoveRange()
            Console.WriteLine(myList.Remove(21)); //false
            myList.RemoveAt(2); //false// [3][2][14][20] > [10]이 날아감

            //성능 
            // 읽기 : O(1) > 그냥 찾아가면 되어서 상수시간
            // 자료를 모를 때 검색 : O(N) > 일일이 찾아야 해서 비례 최선 : 맨 앞 / 최악 : 맨 뒤 / 평균 : 그 안에
            // 이진 검색 > O(logN)으로 낮출 수 있다
            // 삽입 : Insert() - O(N) > 있으면 값을 복사 후 대입해야하므로 최선 : 맨 뒤 / 최악 : 맨 앞 / 평균 : 그 안에
            //       Add() - O(1) > 이미 어디가 끝인지 알기 때문에 >> 가장 많이 사용되므로 개발
            // 삭제 : O(N) > 없애려면 모든 이후 값을 복사 후 대입해야하므로 > 이동시켜야하므로
            myList.RemoveAt(0); //[X][2][14][20] >> [2][14][20]
            #endregion
            #region 2.LinkedList<T>
            // 연결리스트
            // - 단일 연결 리스트 : 다음 원소로만 
            // - 이중 연결 리스트 : 이전과 다음원소 둘 다 // LinkedList (C++에서는 원형으로 구현)
            // - 원형 연결 리스트 : 마지막과 처음이 연결 , 단일과 이중 두가지 다 존재 

            // LinkedListNode : 다음 데이터의 주소값을 저장
            // nullable처리(타입명? 변수명) > null 안전성 검사를 하기 위해
            //  ㄴ string? s = Console.ReadLine(); //null이 들어갈 수 있다 > nullable

            // 성능
            // 읽기 : O(N) : 몇번째 위치/ 몇번째 원소에 있는 것을 반환
            //              > 연속적이지 않아서 주소를 계산할 수 없음 > 다 찾아봐야
            //  ㄴ 최선 : 맨 앞 / 최악 : 맨 뒤
            // 검색 : O(N) : 몇번째 위치/ 몇번째 원소에 있는 원소를 찾아서 반환
            //               > 연속적이지 않아서 주소를 계산할 수 없음 > 다 찾아봐야
            // 삽입 : O(N) : 몇번째 위치/ 몇번째 원소에 넣어야할 지를 파악
            //               > 연속적이지 않아서 주소를 계산할 수 없음 > 다 찾아봐야
            // 위치를 알고 있을 경우에는 O(1)
            // 선형과는 다르다(선형은 복사비용이 있어서 O(N))
            // 삭제 : O(N) : 몇번째 위치/ 몇번째 원소를 지워야할 지를 파악
            //               > 연속적이지 않아서 주소를 계산할 수 없음 > 다 찾아봐야
            #endregion
            Console.WriteLine("");
            #region 백준 - 에디터
            /* 이러한 문제는 기획서와 유사하다
             한 줄로 된 간단한 에디터를 구현하려고 한다. 
            이 편집기는 영어 소문자만을 기록할 수 있는 편집기로, 
            최대 600,000글자까지 입력할 수 있다. -- 제한사항(1)

            이 편집기에는 '커서'라는 것이 있는데, 
            커서는 문장의 맨 앞(첫 번째 문자의 왼쪽), 문장의 맨 뒤(마지막 문자의 오른쪽), 
            또는 문장 중간 임의의 곳(모든 연속된 두 문자 사이)에 위치할 수 있다. 
            ㄴ-커서의 정의(도메인 용어 정의)
            길이가 L인 문자열이 현재 편집기에 입력되어 있으면, 커서가 위치할 수 있는 곳은 L+1가지 경우가 있다.

            이 편집기가 지원하는 명령어는 다음과 같다.

            L	커서를 왼쪽으로 한 칸 옮김 (커서가 문장의 맨 앞이면 무시됨)
            D	커서를 오른쪽으로 한 칸 옮김 (커서가 문장의 맨 뒤이면 무시됨)
            B	커서 왼쪽에 있는 문자를 삭제함 (커서가 문장의 맨 앞이면 무시됨)
                삭제로 인해 커서는 한 칸 왼쪽으로 이동한 것처럼 나타나지만, 
                실제로 커서의 오른쪽에 있던 문자는 그대로임
            P $	$라는 문자를 커서 왼쪽에 추가함

            초기에 편집기에 입력되어 있는 문자열이 주어지고, 그 이후 입력한 명령어가 차례로 주어졌을 때, 
            모든 명령어를 수행하고 난 후 편집기에 입력되어 있는 문자열을 구하는 프로그램을 작성하시오. 
            ㄴ 에디터를 구현하라
            단, 명령어가 수행되기 전에 커서는 문장의 맨 뒤에 위치하고 있다고 한다.

            입력
            첫째 줄에는 초기에 편집기에 입력되어 있는 문자열이 주어진다. 
            이 문자열은 길이가 N이고, 영어 소문자로만 이루어져 있으며, 
            길이는 100,000을 넘지 않는다. 
            둘째 줄에는 입력할 명령어의 개수를 나타내는 정수 M(1 ≤ M ≤ 500,000)이 주어진다. 
            셋째 줄부터 M개의 줄에 걸쳐 입력할 명령어가 순서대로 주어진다. 
            명령어는 위의 네 가지 중 하나의 형태로만 주어진다.
             */
            #region myTry
            /*
            abcd           abcdyx
            3
            P x
            L
            P y
            */

            List<string> editor = new List<string>();
            editor.Add("a");
            editor.Add("b");
            editor.Add("c");
            editor.Add("d");

            editor.Add("x"); // abcdx
            editor.Remove("x");
            editor.Add("y");
            editor.Add("x"); // abcdyx

            foreach(string i in editor)
            {
                Console.Write(i);

            }

            /*
             abc              yxabc
             9
             L // ab_c
             L // a_bc
             L // _abc 
             L // 무시
             L // 무시
             P x // xabc
             L // _xabc
             B // 초기화
             P y // yxabc
             
             */
            Console.WriteLine("");

            editor.Clear();
            editor.Add("a");
            editor.Add("b");
            editor.Add("c");
            editor.Insert(0, " ");
            //editor.Insert(0, " ");
            //무시
            //무시
            editor.Insert(0,"x");
            int index = editor.IndexOf("x");
            Console.WriteLine(index);
            index = index + 1;
            editor[index] = "x";
            editor[0] = ""; // B
            editor.Insert(0, "y");
            foreach (string i in editor)
            {
                Console.Write(i);

            }
            /*
             dmih
             11
             B // dmi
             B // dm
             P x // dmx 
             L // dm<-x
             B // dx 
             B // x
             B // 무시
             P y // yx
             D // yx<-
             D // 무시
             P z // yxz

             */
            Console.WriteLine();
            editor.Clear();
            editor.Add("d");
            editor.Add("m");
            editor.Add("i");
            editor.Add("h");
            editor.Remove("h");
            editor.Remove("i");
            editor.Add("x");
            editor.Remove("m");
            editor.Remove("d");
            editor.Insert(0, "y");
            editor.Add("z");
            foreach (string i in editor)
            {
                Console.Write(i);

            }

            // 일반화 > node에는 그 전 노드의 값과 주소가 들어있다.
            LinkedList<string> list = new LinkedList<string>();
            // 1. 받은 문자열을 List에 담는다.
            #endregion

            //프로그램 : 데이터를 조작
            // 에디터는 문자열을 조작
            // 읽기/ 검색/ 삽입 / 삭제
            // 여러개의 문자를 저장한다 > List > List / LinkedList
            // 펄어비스) 당신은 멜론이라는 프로그램을 구현하기 위해 어떤 자료구조를 이용할 것인가

            // 종류 : 선형(리스트,스택,큐) / 비선형(그래프,트리)
            // 구현 : 순차, 연결
            // ㄴ 선형 리스트와 연결 리스트를 어떻게 구분할 것인가
            // 성능기준 > 복사 : 끝에 있으면 O(1) / 연결 : 위치를 알면 O(1)
            // 삽입과 삭제는 아무래도 문자의 중간에서 자주 일어나므로 > 선형 리스트가 낫다
            // 최악 : 10만자의 문자에서 50만번 삽입하는 것
            // > 이럴경우 LinkedList(위치를 알고 있을 경우에는 O(1))
            // linearList면 계속 복사가 일어나므로 비효율적이다.


            // 입력 : 문자열을 입력받아 연결리스트에 저장
            Console.WriteLine(" ");
            string? input = Console.ReadLine();
            LinkedList<char> container = new(input);

            int M = int.Parse(Console.ReadLine());


            // 처리 : 명령어에 다라 문자열을 편집한다
            // ㄴ 연결 리스트를 어떻게 조작할 것인가
            // ㄴ 커서 기능을 어떻게 구현할 것인가 > LinkedListNode
            // P ?	?라는 문자를 커서 왼쪽에 추가함 => container 에 삽입 > 
            // AddFirst() : 시작위치 / AddLast() : 마지막위치
            // AddBefore() / AddAfter() >> LinkedListNode 타입의 객체 => 커서
            #region 강사님의 조언 (6) Data 유형 파악의 중요성
            //앞으로 우리가 할 것은 자연어로 쓰여있는 글을 컴퓨터가 알아들을 수 있게 해석
            // Logic이란 어떤 Data(종류,유형,반환유형등등)을 파악하여 연산만 하면 된다
            #endregion
            // ㄴ 커서는 LinkedListNode 타입이겠구나 >  시작은 마지막에 > Last를 사용
            // 출력 : 편집된 문자열을 출력한다.
            LinkedListNode<char> cursor = container.Last; // 초기 커서 데이터
            // P ?	?라는 문자를 커서 왼쪽에 추가함 => AddAfter()호출 후 커서를 갱신

            char ch = 'x';
            cursor = container.AddAfter(cursor, ch); // 값을 넣었다 > 노드 위치가 바뀐다 > 그 값을 다시 받아 갱신


            // *yxz
            // *[y][x][z]
            #endregion

            #region 선형 List내에서의 검색 방법
            // 
            // 선형 검색 : 하나하나 찾는 것 > 시간복잡도 : 갯수가 늘어나면 계속 찾을 것도 비례 증가 > O(N)
            //                            공간복잡도 : 메모리는 추가로 필요하지 않으므로 O(1)
            // 이진 검색 : 검색할 범위를 '절반씩' 줄여가는 방식 > 정렬된 선형 리스트내에서만 사용 가능
            // 시간복잡도 : 갯수가 늘어도 계속 절반으로 줄여가니까 O(logN) 
            // 공간복잡도 : 메모리는 추가로 안 필요하므로 O(1)
            // 오름차순 : 작은 인덱스에 작은 값이 들어가 점점 값이 커지는 정렬 
            // 내림차순 : 작은 인덱스에 큰 값이 들어가 점점 값이 작아지는 정렬
            int[] fiboArray = { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 143, 232 };
            List<int> fibo = new();
            fibo.AddRange(fibo);
            // 피보나치 수열을 예로 들면 찾는 수 - 21
            // 선형 검색이면 9번
            // 이진 검색이면
            // 범위의 중간값과 일치하지 않으면 > 그 왼편은 그것보다 작을 것이고, 오른편은 그것보다 클 것이니
            // 중간값 - 8 > 찾는 값보다 작다 > 이전 값 전부 제외
            // 시작위치가 13으로 이동 > 중간값 : 55 > 찾는 값보다 크다 > 이후 값 제외 > 끝값이 55로 이동
            // 중간값 - 21 찾았다 (3번만에 > log9) 
            // 

            BinarySearch(fibo, 13);
            // 어떤 값이 어느위치에 있는지 범위를 나타낼 수 있다
            // LowerBound : 특정 값보다 '크거나 같은' 첫번째 원소
            // UpperBound : 범위 중 특정 값 보다 큰 첫번째 원소 >> 중복된 값이 얼마나 있는지 범위를 알게 된다

           Console.WriteLine(LowerBound(fibo, 12));
            #endregion

           

        }
    }
}
