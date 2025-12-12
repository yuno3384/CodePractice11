namespace Test10020202
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[81];
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = i;
            //}
            //int[] result = GetSquaredOddNumberArray(arr);


            //foreach (int i in result) 
            //{
            //    Console.Write(i+" ");

            //}


            /*-재귀
                - 분할 정복법
                    - 문제는 작으면 작을수록 해결하기 편하다 > 작게 나누어 생각한다
                        >> 작은 단위의 문제들을 하나씩 해결해가며 전체 문제를 해결
                - Recursion(재귀) : 함수가 자기 자신을 호출
                    -기저조건 : 재귀가 중단되는 조건
                    - 재귀조건 : 기저조건이 수렴되는 조건

                예) 폴더 내의 모든 파일과 폴더를 삭제
                1.하위폴더가 없을 때 까지 깊이 들어간다
                2.모든 파일을 지운다
                3.이전 경로로 돌아온다
                4.윗 과정으로 처음부터 다시 반복한다

                최상위 폴더에서 다 삭제한다
                폴더 내 모든 파일을 삭제한다

                재귀 > 함수를 호출 > 스택프레임이 계속 생성 > 오버헤드가 계속 남음 > 스택에 쌓임 > 넘어서서 오류(스택 오버플로우)

                반복문과 변환 */
            //int i = 1;
            //Console.WriteLine(i);
            ////i = 2;
            //i++;
            //Console.WriteLine(i); 
            ////i = 3;
            //Console.WriteLine(3); 
            ////i = 4;
            //Console.WriteLine(4); 
            //i = 5;
            //Console.WriteLine(5); 
            //i = 6;
            //Console.WriteLine(6); 
            //i = 7;
            //Console.WriteLine(7); 
            //i = 8;
            //Console.WriteLine(8);
            // 반복되는 부분 : 출력 / 변하는 부분 : 숫자 > 이걸 어느 변수에 담으면 달라지겠네 >> for문
            // i의 값이 점점 늘어나야 하는데 > 하나씩 > 증감연산자
            //for (int i = 1; i <=10; ++i)
            //{
            //    Console.Write(i+" ");
            //}

            // 재기조건 : i는 1커져야 한다
            /*Foo(1);
                1출력
                Foo(2);
                  2출력
                  Foo(3);
                    3출력
                    Foo(4);
                      4출력
                      Foo(5);
                        5출력
                          Foo(6);
                            6출력
                            Foo(7);
                              7출력
                              Foo(8);
             
             */

            Boo(10);
            Console.WriteLine("");
            ToBinary(12);
            Console.WriteLine("");
            ToBinary(72);
            Console.WriteLine("");
            Console.WriteLine(1 % 2);
            ToOctal(12);
            Console.WriteLine("");
            int t = Factorial(5);
            Console.WriteLine(t);

            int num = 1;

            for (int i = 5; i <= 0; --i)
            {
                num = num * i;
            }

            Console.WriteLine(num);





        }


        static public int[] GetSquaredOddNumberArray(int[] numbers)
        {
            int[] result = new int[numbers.Length];
            int resultIdx = 0;
            for (int i = 0; i < numbers.Length; ++i)
            {
                if (numbers[i] % 2 != 0)
                {
                    result[resultIdx++] = numbers[i] * numbers[i];
                }
            }
            return result;
        }


        void Foo(int num)
        {
            // 반복되는 부분 : 출력 / 변하는 부분 : 숫자 > 이걸 어느 변수에 담으면 달라지겠네
            //i의 반복 횟수 > 이것이 매개 변수
            // i의 값이 점점 늘어나야 하는데 > 하나씩 > 증감연산자
            // 반환해줄 타입이 있나 > 없음 > void

            // 기저조건 : 반복을 멈추는 조건 > 만일 1이라면 재귀가 될때 > i < 10일때 함수를 끝낸다 > return;
            // 재귀함수에서는 증감연산자를 가급적 안쓴다 > 계산 오류가 날 수 있기 때문 > 그냥 연산식으로 한다
            
        }
        /// <summary>
        /// 1부터 10까지 출력
        /// </summary>
        /// <param name="i"></param>
        static void Boo(int i)
        {
            
            //기저조건: i는 10까지만 출력해야한다 > i가 10보다 크면 멈추게 한다
            if (i <= 0)// n회 > 
            {
                return;
            }
            // 재기조건 : 출력이 반복되어야 한다
            
            Boo(i - 1); // >> 출력이 증가로 나옴
            Console.Write(i + " ");
            // 덧셈방식은 매직넘버를 계속 보내줘야 하기 때문에 > 오버헤드가 많아짐 > 횟수가 반복되면...
            // 서버쪽, 서비스쪽은 1비트만 달라져도 가격이 달라진다
            // 예) 영상 데이터 > 압축을 했는데, 공백문자 하나를 안 지움 > 8비트인데
            // 유튜브는 4682만명이 매달 사용 > 4682만byte > 어우... 금액이.. > 사소하게 낭비하면 안된다. 
            // 근데 출력을 먼저 하면 값이 그대로 나오는데 > 어떡하지... 반대로 해
            /*Foo(10);
                Foo(9);
                  Foo(8);
                    Foo(7);
                      Foo(5);
                          Foo(4);
                            Foo(7);
                              7출력
                              Foo(8);
             
             */

            

        }

        // 재귀가 불가능한 반복문도 있다
        // 십진수를 이진수로 구현하라
        // 이진수 만드는 법 > 한번 나눈다 그 몫으로 나눈다 그리고 또 나눈다 > 몫이 1이되면 출력한다 그리고 나머지들을 다 역순으로 배열한다

         static void ToBinary(int Decimal)
        {

            if (Decimal / 2 == 0)
            {
                Console.Write(Decimal);
                return;
            }

            ToBinary(Decimal / 2);

            Console.Write(Decimal % 2);

        }

        static void ToOctal(int Decimal)
        {

            if (Decimal / 8 == 0)
            {
                Console.Write(Decimal);
                return;
            }

            ToBinary(Decimal / 8);

            Console.Write(Decimal % 8);

        }

        static int Factorial(int value)
        {
            int answer = 1;

            if(value <= 0)
            {
                return 1;
            }
            
            

            answer = value * Factorial(value - 1);

            return answer;
        }

    }
}
