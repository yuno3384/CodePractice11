namespace CountingStr
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //string str = Console.ReadLine(); // 문자열을 입력받는 부분
           //Console.WriteLine(str); // 문자열 출력

           //foreach(char c in str) // 문자열에서 문자를 한글자씩 가져오기
           // {
           //     Console.Write(c+" "); // 한글자를 출력하기
           // }
            // char는 숫자다 원래
            char test = (char)97; // 97이라는 숫자를 문자로 만들어서 > test에 담아라
            int test2 = (int)'a'; 
            Console.WriteLine(test);
            Console.WriteLine(test2);
            // 문자는 숫자와 동일하다 > 다만 약속한 숫자(아스키코드)
            
            test2 = (int)'a' - 'a';
            Console.WriteLine(test2);//97-97 = 0 

            test2 = (int)'z';
            Console.WriteLine(test2);// 122
            // 문자열을 분리할수 있다
            // 문자열을 숫자로 바꿀 수 있다

            //int[] count = new int[26];// 알파벳 갯수
            /*
            알파벳 소문자로만 이루어진 단어 S가 주어진다. 
            각 알파벳이 단어에 몇 개가 포함되어 있는지 구하는 프로그램을 작성하시오.

            입력
            첫째 줄에 단어 S가 주어진다. 단어의 길이는 100을 넘지 않으며, 알파벳 소문자로만 이루어져 있다.

            출력
            단어에 포함되어 있는 a의 개수, b의 개수, …, z의 개수를 공백으로 구분해서 출력한다.

            예제 입력 1 
            baekjoon
            예제 출력 1 
            1 1 0 0 1 0 0 0 0 1 1 0 0 1 2 0 0 0 0 0 0 0 0 0 0 0
             */
            int[] sumAlphabet = new int[26];
            int[] counts = new int[26];
            int[] counts2 = new int[26];
            for (int i = 0; i < 26; i++)
            {
                counts2[i] = (char)(97 + i);
            }
            Console.WriteLine(counts.Length);
            string s = Console.ReadLine();

            foreach(char c in s)
                counts[c - 'a']++;

            foreach(int a in counts)
                Console.Write($"{a} ");
                
             foreach (char c in s)
            {   
                //Console.Write(c+" ");
                for (int count = 0; count < counts2.Length; count++)
                {
                    if ((int)c == counts2[count])
                    {
                        sumAlphabet[count]++;
                        //Console.Write($"{(char)counts[count]} 발견");
                    }
                }
                
                /*
                    Unhandled exception. System.IndexOutOfRangeException: 
                    Index was outside the bounds of the array.
                    at CountingStr.Program.Main(String[] args) 
                    in C:\CodePractice\CountingStr\Program.cs:line 59
                 */
            }
            Console.WriteLine(" ");
            foreach (int i in sumAlphabet)
            {
                Console.Write(i + " ");
            }


        }
    }
}
