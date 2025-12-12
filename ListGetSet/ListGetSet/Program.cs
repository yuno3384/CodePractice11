namespace ListGetSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List list = new List();
            //list.Set(3,5);
            list.Add(3);
            #region 오류 해결
            /*
             Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.
             at ListGetSet.Program.List.Set(Int32 index, Int32 num) in C:\CodePractice\ListGetSet\ListGetSet\Program.cs:line 28
             at ListGetSet.Program.Main(String[] args) in C:\CodePractice\ListGetSet\ListGetSet\Program.cs:line 8   
             */
            /*
             Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.
             at ListGetSet.Program.List.Set(Int32 index, Int32 num) in C:\CodePractice\ListGetSet\ListGetSet\Program.cs:line 40
             at ListGetSet.Program.Main(String[] args) in C:\CodePractice\ListGetSet\ListGetSet\Program.cs:line 8
             */
            #endregion 
            Console.WriteLine(list.Get(0));
            //list.Set(1, 3);
            //Console.WriteLine(list.Get(1));
            //Console.WriteLine(list.Get(2));
            //Console.WriteLine(list.Get(3));
        }


        public class List
        {
            int[] listArr = new int[0]; // 초기 선언   
            int index = 0; // 위치
            int value = 0; // 인덱스에 해당하는 값
            int length = 0; // 마지막 인덱스값


            public int[] Set(int index, int num) // 값넣기
            {
                
                Console.WriteLine($"current Index{index} number{num} Length{listArr.Length}");

                length = listArr.Length;
                ++length;
                listArr = new int[++length];
                Console.WriteLine($"new Array");
              
                
                //listArr[index] = num;


                if (index < listArr.Length)
                {
                    
                    for (int i = 0; i < index; ++i)
                    {
                        listArr[length - i] = 0;
                        if (length == index)
                        {
                            listArr[index] = num;
                        }
                    }
                }
                else
                {
                    listArr[index] = num;
                }


                return listArr;
            }
            public int Get(int index) // 값 보여주기
            {
                value = listArr[index];
                
                return value; 
            }


            public int[] Add(int num)
            {
                //listArr = new int[count + 1];
                
                if(index == 0 || index >= 0)
                {
                    ++index;
                    Set(index, num);
                }
                
                return listArr;

            }

            public int[] Remove(int num)
            {
                
                // 그 값을 찾는다.
               for(int i = 0; i < listArr.Length; ++i)
                {
                    if (listArr[i] == num)
                    {
                        
                        int currentIndex = i;
                        // 값을 초기화한다
                        listArr[currentIndex] = 0;
                        // 인덱스를 조정한다
                        listArr[currentIndex + 1] = listArr[index];
                    }
                }
                // 그 변환된 배열을 내보낸다
                return listArr;
            }


        }

    }

}
