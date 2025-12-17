using System.Security.Claims;
using System.Text;

namespace Practice251216
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 백준 - 10816번 숫자 카드 2
            /*
           숫자 카드는 정수 하나가 적혀져 있는 카드이다. 상근이는 숫자 카드 N개를 가지고 있다. 
           정수 M개가 주어졌을 때, 이 수가 적혀있는 숫자 카드를 상근이가 몇 개 가지고 있는지 
           구하는 프로그램을 작성하시오.
            * 
            첫째 줄에 상근이가 가지고 있는 숫자 카드의 개수 N(1 ≤ N ≤ 500,000)이 주어진다. 
           둘째 줄에는 숫자 카드에 적혀있는 정수가 주어진다. 숫자 카드에 적혀있는 수는 -10,000,000보다 크거나 같고, 
           10,000,000보다 작거나 같다.

           셋째 줄에는 M(1 ≤ M ≤ 500,000)이 주어진다. 넷째 줄에는 상근이가 몇 개 가지고 있는 숫자 카드인지 구해야 
           할 M개의 정수가 주어지며, 이 수는 공백으로 구분되어져 있다. 이 수도 -10,000,000보다 크거나 같고, 
           10,000,000보다 작거나 같다.

           출력
           첫째 줄에 입력으로 주어진 M개의 수에 대해서, 각 수가 적힌 숫자 카드를 상근이가 몇 개 가지고 있는지를 
           공백으로 구분해 출력한다.

           예제 입력 1 
           10
           6 3 2 10 10 10 -10 -10 7 3
           8
           10 9 -5 2 3 4 5 -10
           예제 출력 1 
           3 0 0 1 2 0 0 2

            */
            /*
            // 상근이가 가진 카드와 그 갯수
            int holdCard = int.Parse(Console.ReadLine());
            string cardsNote = Console.ReadLine();
            // BOJ가 물어보는 질문 수
            string cardsAsk = Console.ReadLine();
            // 그에 따른 카드가 몇개 있는지 찾는 것
            int key = int.Parse(Console.ReadLine());

            // 문자열 분리
            string[] cardsName = cardsNote.Split(" ");
            string[] askCardsList = cardsAsk.Split(" ");

            List<string> holdCards = new();
            holdCards.AddRange(cardsName);
            List<string> askCards = new();
            askCards.AddRange(askCardsList);
            // 정수 만큼의 물음 속 카드가 몇개 있는지 찾아라
            GuessCard(holdCards, key);
            */
            #endregion

            /*
             수 찾기


            N개의 정수 A[1], A[2], …, A[N]이 주어져 있을 때, 
            이 안에 X라는 정수가 존재하는지 알아내는 프로그램을 작성하시오.

            입력
            첫째 줄에 자연수 N(1 ≤ N ≤ 100,000)이 주어진다. // 해당 조건은 입력자를 제한하는 것으로 이미 성립한 조건임
            다음 줄에는 N개의 정수 A[1], A[2], …, A[N]이 주어진다. 
            다음 줄에는 M(1 ≤ M ≤ 100,000)이 주어진다. 
            다음 줄에는 M개의 수들이 주어지는데, 이 수들이 A안에 존재하는지 알아내면 된다. 
            참조) 데이터 다루기 - 타입
            //모든 정수의 범위는 - 2^31 보다 크거나 같고 2^31보다 작다. > 4바이트 > 32비트 > int

            출력
            M개의 줄에 답을 출력한다. 존재하면 1을, 존재하지 않으면 0을 출력한다.
             
            예제 입력 1 
            5
            4 1 5 2 3
            5
            1 3 7 9 5
            예제 출력 1 
            1
            1
            0
            0
            1
             */

            //입력 - N 정수 M 정수가 listA에 안에 있는지
            // 자연수 N 입력 받기 > int - 참조) 문자열 - 콘솔에서 입출력
            int N = int.Parse(Console.ReadLine()); // 숫자형 변수에 담아 숫자로 변환(문자열을)
            
            // ㄴ 로직이 안 떠오르면 차근차근
            // 콘솔로 입력 > Console.ReadLine();

            //List<string> A = new List<string>();
            // 4 1 5 2 3 > 문자열로 저장 > 
            
            // 배열 A의 입력 받기
            // ㄴ 그 문자열을 쪼개는 과정
            //string[] input = ;
            // int배열로 전환 한다
            // ㄴ int배열을 만든다 > 그걸 저장할 공간
            int[] A = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            #region 기존 방식 : 저장할 배열 변수에 반복하여 담기
            //int[] A = new int[N]; // [0 , N-1] >[0 , N)
            //// ㄴ 각 원소를 parse를 해준다 > 숫자로 변환
            ///* 첫번째 원소 A[0] = int.Parse(input[0])
            //   두번째 원소 A[1] = int.Parse(input[1])
            //   세번째 원소 A[2] = int.Parse(input[2])
            //       .
            //       .
            //       .
            //   패턴이 보인다 > 같은 거 반복 , 숫자만 달라짐 > for문으로 바꾸자
            //   참고) 숫자 > 리터럴 > 데이터이다.
            // */
            //for (int i = 0; i < N; ++i) // [0 , N)
            //{
            //    A[i] = int.Parse(input[i]);
            //}
            #endregion 
            // C#에서 배열의 타입을 바꿀 수 있는 메소드
            // Array.ConvertAll(바꾸고 싶은 배열)
            // 자연수 M 입력 받기
            int M = int.Parse(Console.ReadLine());
            // 배열 B의 입력 받기
            //  참조타입 > 인스턴스가 달라지니까
            int[] B = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);//  함수를 인수로 넘겨준다 > 함수형 프로그래밍
                                                                              //int[] B = new int[M]; 
                                                                              //for(int j = 0; j < M; ++j)
                                                                              //{
                                                                              //    B[j] = int.Parse(input[j]);
                                                                              //}

            // 처리
            // B의 각 원소가 A안에 존재하는지 판단한다.
            // 원소 하나에 대하여 생각해보자
            // ㄴ B[0]이 A에 존재하는지 판단한다.
            // ㄴ 하나하나 비교

            //if (B[0] == A[0]){}

            //if (B[0] == A[1]){}

            //if (B[0] == A[2]){}

            //B[0]가 A에 존재하나?
            // O(NM) > O(N^2)과 유사
            
            for (int i = 0; i < M; ++i)
            {
                bool isFound = false;
                for (int j = 0; j < N; ++j)
                {
                    if (B[i] == A[j])
                    {
                        isFound = true;
                        break;
                    }
                }
                Console.WriteLine(isFound ? 1 : 0);
            }// 최악의 상황 : 백억번 시행 > 시간 초과!!
             // 선형 검색 > 이진검색으로 바꾸자
             // 근데 이거 정렬이 안 되어 있는데요??
             // 정렬 알고리즘 > 냉성 정렬
             // 16개 요소 이하 > insertion Sort(O(N^2))
             // HeapSort (O(NlogN))
             // Quicksort (O(NlogN))
             // Big-O는 부정확 > 실제로 시간정확도 함수로 구해보니 이런 결과가
             // A를 정렬
             // 정렬 후 이진 검색 >> BinarySearch로 진행 > index로 반환
            Array.Sort(A);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < M; ++i)
            {
                int result = Array.BinarySearch(A, B[i]); // 없으면 음수 반환

                bool isFound = result >= 0;

                if (isFound)
                {
                    sb.AppendLine("1");
                }
                else
                {
                    sb.AppendLine("0");
                }
            }
            Console.WriteLine(sb.ToString());
            // Console.WriteLine을 하면 왜 느린가? > Flush현상이 일어나서 그렇다
            // 버퍼를 계속 비우는 것 > 계속 연산이 반복됨
            // 그래서 stringBuilder 클래스를 사용한다.

            //길이가 제각각인 K개의 랜선으로 N개의 같은 길이의 랜선을 만들려 한다
            // 이미 자른 길이는 그냥 버린다 > 몫
            // 센티미터 단위로 정수길이만큼
            // N개 보다 더 많이 만들어도 N개 만큼 만든 것 
            // 최대 랜선의 길이 > 제일 짧은 것이 제일 긴 거니까
            // 랜선의 길이는 2^31-1 > int 의 최대 길이
            /*
             4(K) 11(N)   1     100                    401     457
             802     =>          8                      5       1
             743     =>          7                      3       1
             457     =>          4                      1       1
             539     =>          5                      1       1
                               -----                  -----   -----
                                 24                     9       4
                        (최저)                                 (최장)
            
            선형검색과 이진검색은 해를 구하는 데도 사용한다 > 범위를 변경
            // 매개변수 탐색  파라미터 서치
            [1,802]
            int m = 401;

            [1,457] > 하나하나 줄여가는 것 > 선형탐색


             */


            /*
             정수를 저장하는 스택을 구현한 다음, 입력으로 주어지는 명령을 처리하는 프로그램을 작성하시오.

             명령은 총 다섯 가지이다.

            push X: 정수 X를 스택에 넣는 연산이다.
            pop: 스택에서 가장 위에 있는 정수를 빼고, 그 수를 출력한다. 만약 스택에 들어있는 정수가 없는 경우에는 -1을 출력한다.
            size: 스택에 들어있는 정수의 개수를 출력한다.
            empty: 스택이 비어있으면 1, 아니면 0을 출력한다.
            top: 스택의 가장 위에 있는 정수를 출력한다. 만약 스택에 들어있는 정수가 없는 경우에는 -1을 출력한다.

            입력
            첫째 줄에 주어지는 명령의 수 N (1 ≤ N ≤ 10,000)이 주어진다. 
            둘째 줄부터 N개의 줄에는 명령이 하나씩 주어진다. 주어지는 정수는 1보다 크거나 같고, 
            100,000보다 작거나 같다. 문제에 나와있지 않은 명령이 주어지는 경우는 없다.

            출력
            출력해야하는 명령이 주어질 때마다, 한 줄에 하나씩 출력한다.
            
            예제 입력 1
            14
            push 1
            push 2
            top
            size
            empty
            pop
            pop
            pop
            size
            empty
            pop
            push 3
            empty
            top
            예제 출력 1 
            2
            2
            0
            2
            1
            -1
            0
            1
            -1
            0
            3
             */
            /*
             괄호 문자열(Parenthesis String, PS)은 두 개의 괄호 기호인 ‘(’ 와 ‘)’ 만으로 구성되어 있는 문자열이다. 
            그 중에서 괄호의 모양이 바르게 구성된 문자열을 올바른 괄호 문자열(Valid PS, VPS)이라고 부른다. 
            한 쌍의 괄호 기호로 된 “( )” 문자열은 기본 VPS 이라고 부른다. 
            만일 x 가 VPS 라면 이것을 하나의 괄호에 넣은 새로운 문자열 “(x)”도 VPS 가 된다. 
            그리고 두 VPS x 와 y를 접합(concatenation)시킨 새로운 문자열 xy도 VPS 가 된다. 
            예를 들어 “(())()”와 “((()))” 는 VPS 이지만 
            “(()(”, “(())()))” , 그리고 “(()” 는 모두 VPS 가 아닌 문자열이다. 

            여러분은 입력으로 주어진 괄호 문자열이 VPS 인지 아닌지를 판단해서 그 결과를 YES 와 NO 로 나타내어야 한다. 

            입력
            입력 데이터는 표준 입력을 사용한다. 입력은 T개의 테스트 데이터로 주어진다. 
            입력의 첫 번째 줄에는 입력 데이터의 수를 나타내는 정수 T가 주어진다. 
            각 테스트 데이터의 첫째 줄에는 괄호 문자열이 한 줄에 주어진다. 
            하나의 괄호 문자열의 길이는 2 이상 50 이하이다. 

            출력
            출력은 표준 출력을 사용한다. 
            만일 입력 괄호 문자열이 올바른 괄호 문자열(VPS)이면 “YES”, 아니면 “NO”를 한 줄에 하나씩 차례대로 출력해야 한다. 

            예제 입력 1 
            6
            (())())
            (((()())()
            (()())((()))
            ((()()(()))(((())))()
            ()()()()(()()())()
            (()((())()(
            예제 출력 1 
            NO
            NO
            YES
            NO
            YES
            NO
             
            >> 이것이 Stack문제 
            열린 괄호 > push
            닫힌 괄호 > pop
            >> 스택이 비어있는 지 여부
             */

           /*
            정수를 저장하는 큐를 구현한 다음, 입력으로 주어지는 명령을 처리하는 프로그램을 작성하시오.

            명령은 총 여섯 가지이다.

            push X: 정수 X를 큐에 넣는 연산이다.
            pop: 큐에서 가장 앞에 있는 정수를 빼고, 그 수를 출력한다. 만약 큐에 들어있는 정수가 없는 경우에는 -1을 출력한다.
            size: 큐에 들어있는 정수의 개수를 출력한다.
            empty: 큐가 비어있으면 1, 아니면 0을 출력한다.
            front: 큐의 가장 앞에 있는 정수를 출력한다. 만약 큐에 들어있는 정수가 없는 경우에는 -1을 출력한다.
            back: 큐의 가장 뒤에 있는 정수를 출력한다. 만약 큐에 들어있는 정수가 없는 경우에는 -1을 출력한다.
            
            입력
            첫째 줄에 주어지는 명령의 수 N (1 ≤ N ≤ 10,000)이 주어진다. 둘째 줄부터 N개의 줄에는 명령이 하나씩 주어진다. 주어지는 정수는 1보다 크거나 같고, 100,000보다 작거나 같다. 문제에 나와있지 않은 명령이 주어지는 경우는 없다.

            출력
            출력해야하는 명령이 주어질 때마다, 한 줄에 하나씩 출력한다.

            예제 입력 1 
            15
            push 1
            push 2
            front
            back
            size
            empty
            pop
            pop
            pop
            size
            empty
            pop
            push 3
            empty
            front
            예제 출력 1 
            1
            2
            2
            0
            1
            2
            -1
            0
            1
            -1
            0
            3
             
             
             */

        }

        public static int GuessCard(List<string> cards, int key)
        {
            int holdCardstartIndex = 0;
            int holdCardendIndex = cards.Count;
            int holdCardmidIndex = holdCardstartIndex + (holdCardendIndex - holdCardstartIndex) / 2;

            string keyValue = string.Concat(key);

            while (holdCardstartIndex < holdCardendIndex)
            {
                if(key < holdCardmidIndex)
                {
                    holdCardstartIndex = holdCardmidIndex + 1;
                }
                if(key > holdCardmidIndex)
                {
                    holdCardendIndex = holdCardmidIndex;
                }
            }

            foreach (string card in cards)
            {
                if (keyValue == cards[cards.IndexOf(keyValue)])
                {
                    return cards.IndexOf(keyValue);
                }
            }

            return -1;

        }


    }
}
