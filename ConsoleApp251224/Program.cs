
namespace ConsoleApp251224
{
    class Monster
    {

    }
    
    
    
    
    
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            a.Add(1);
            a.Add(2);
            a.Remove(1);


            // 내부적으로 해쉬테이블을 사용한다.
            Dictionary<int,int> b = new Dictionary<int,int>();
            b.Add(1,2);
            b.Add(2, 3);


            b.Remove(2); //삭제 기준 : key를 가지고 삭제
            //hashTable의 원리를 이해해야함
            // 큰덩어리를 작은 버킷으로 쪼갠다
            // key값을 숫자로 전환 > hash algorithm으로
            // 주의) 숫자가 서로 동일한 다른 문자열이 나올 수 있음 > 일단 다음 칸에 넣고 그리고 그 전 칸에 next를 걸어놓는다.
            // 실제로는 비트연산을 하여서 나머지연산과 동일한 상태로 진행

            Dictionary<Monster, int> c = new Dictionary<Monster, int>();

            Monster mon = new Monster();

            Type t = mon.GetType(); //mon에 있는 타입 메타정보를 Type타입의 t변수에 담아줘
            c.Add(mon, 2); // key값으로 다 넣을 수 있다.
            c.Add(new Monster(), 3);// 그래서 같은 key를 넣을 수 없다
                                    // new는 글자로가 아니라 인스턴스 생성으로 보므로 전혀 다른 숫자다
        }
    }
}
