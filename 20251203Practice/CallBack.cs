namespace _20251203Practice
{
    class Program
{    
    
     // 재귀함수
     // 누적합 알고리즘 재귀함수로도 만들 수 있다.
     // 1~6부터 
    static int Sum(int start, int end)
    {
            if(start > end)
            {
                return 0;
            }
            return start + Sum(start + 1, end);

    }
        /*

            Sum(1,6)

            static int Sum(int 1, int 6)
            {
                    if(1 > 6) > No
                    {
                        return 0;
                    }
                    return 1 + Sum(1 + 1, 6);
                        static int Sum(int 2, int 6)
                        {
                            if(2 > 6) > No
                            {
                                return 0;
                            }
                            return 2 + Sum(2 + 1, 6);
                                       static int Sum(int 3, int 6)
                                       {
                                            if(3 > 6) > No
                                            {
                                                return 0;
                                            }
                                            return 3 + Sum(3 + 1, 6);
                                                    static int Sum(int 4, int 6)
                                                        {
                                                                if(4 > 6) > No
                                                                {
                                                                    return 0;
                                                                }
                                                                return 4 + Sum(4 + 1, 6);
                                                                            static int Sum(int 5, int 6)
                                                                            {
                                                                                if(5 > 6) > No
                                                                                {
                                                                                    return 0;
                                                                                }
                                                                                return 5 + Sum(5 + 1, 6);
                                                                                           static int Sum(int 6, int 6)
                                                                                            {
                                                                                                if(6 > 6) > No
                                                                                                {
                                                                                                    return 0;
                                                                                                }
                                                                                                return 6 + Sum(6 + 1, 6);
                                                                                                        static int Sum(int 7, int 6)
                                                                                                        {
                                                                                                                if(7 > 6) > Yes
                                                                                                                {
                                                                                                                    return 0;
                                                                                                                }
  

                                                                                                        }

                                                                                            }

                                                                            }

                                                        }




                                       }
                        }

            }
        
    
        => 1 + 2 + 3 + 4 + 5 + 6 + 0

        // 절차(함수)지향(POP)과 객체지향(OOP)
        // 함수끼리 묶자 > 함수끼리 상호작용
        //함수는 순서가 중요하므로 오류가 다발> 어떤 객체로 묶어서 순서 없이 실행하도록 하자 >Class를 위한 프로그래밍 방식


         */
        // 기존 반복문 방식의 경우는 이러하다
        static int Sum2(int start, int end)
    {
            int sum = 0;
            for(int i = start; i < end; ++i)
            {
                sum += i;
            }
            
         return sum;
    }
        static void Main() // 아 여기서부터 시작되는구나...
     {

            int result = Sum(1, 6);
            Console.WriteLine(result);







    }

}
}
