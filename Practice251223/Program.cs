namespace Practice251223
{
    
    class Node
    {
        // 연결 리스트 > Node를 기준으로 이동 
        // [ 10 ] <-> [ 7 ] <-> [ 14 ] ...  => LinkedList
        public int Data;
        public Node Next;
        public Node Prev;

        //public Node(int data)
        //{
        //    this.Data = data;
        //}
    }
    
    class MyLinkedList
    {
        // 첫번째 값, 마지막 값, 길이
        public int count = 0; // 길이
        // 배열이 필요없다 > 값 두개만 있으면 탐색하면 되니까 
        public Node Head;
        public Node Tail;
        //즉, 연결리스트는 배열이 없는 구조이다.

        public Node AddLast(int data)
        {
            Node newNode = new Node(); // 어차피 처음 만들때는 만들어야 하니까 맨 위로


            //  핵심적으로 생각해야할 부분 == 처음과 끝에 대해서 항상 유효하도록 신경을 써야함
            // 처음에는 head가 tail이 같아야하고, 안에는 값이 없는 상태로 시작된다
            if (Head == null)// 지금 이것이 linkedList의 첫번째 인지부터
            {    
                newNode.Data = data;
                //Head = new Node(data);
                Head = newNode;
            }// 첫번째 것에 대한 갱신은 끝남
             // 그러면 마지막도 있어야함 > 마지막 집도 갱신
            /* [ 1 ] <-> [ 1 ] <-> [ 1 ] <-> [ 1 ] -> [ new ]
            // Head                           Tail           
            [ 1 ] <-> [ 1 ] <-> [ 1 ] <-> [ 1 ] -> [ new ]
            Head                                    Tail       

            */
            if (Tail != null)// 지금 이것이 linkedList의 마지막은 Head가 생기면 자동
            {
                Tail.Next = newNode; // 다음 것을 만들어서 새로운 노드를 담는 변수에 있던 것을 넣고
                newNode.Prev = Tail; // 그 새로운 노드의 전 노드에 기존 테일을 담는 변수의 값을 넣고
            }

            Tail = newNode; // 새로운 테일에 새로운 노드를 담는 변수를 담아서 새로운 테일로 만든다

            count++; //길이가 늘어나고 count += 1;
            return newNode; // 노드가 추가

        }
        // AddFirst

        public void Remove(Node node)
        {
            // 특정 노드를 날린다
            // 그 노드의 연결을 끊는다
            // 그 다음 노드를 그 노드의 이전 노드와 연결시켜야한다
            // [0] <-> [1] <-> 삭제 <-> [3]-> [new ]
            // Head                           Tail
            //  [1] <-> [1] <-> 삭제 <-> [3] -> [new]
            // Head                             Tail    
            if (Head == node)// 삭제하려는 것이 head다 > 어차피 처음 선언할때는 다 비어있던 거라 지워도 괜찮다
            {
                //Head = null;
                Head = Head.Next; // 다음 것으로 넘기겠다 > 없으면 null
            }
             if(Tail == node)
            {
                Tail = Tail.Prev;// 이전 것으로 넘기겠다 > 없으면 null
            }

            // 중간 부분을 지운다
            // [0] <-> [1] <-> 삭제 <-> [3]-> [new]
            // Head                           Tail
            // [0] <-> [1] <-> [3]-> [new]
            // Head                   Tail
            // '지우려는 node의 앞 전 node'의 다음 node를 '지우려는 node의 다음 node'로 변경
            if (node.Prev != null) 
            {
                (node.Prev).Next = node.Next;// 1의 다음 node에 3을 넣겠다 
            }
            // '지우려는 node의 다음 node'의 이전 node를 '지우려는 node의 이전 node'로 변경
            if (node.Next != null)
            {
                (node.Next).Prev = node.Prev;// 3의 이전 node에 1을 넣겠다.
            }
            // 각각 반대로 움직여야 하기 때문에 각각 처리해야함 
            // 어차피 연결을 끊어주지 않아도 자동으로 GC가 처리함

            count--;
        }

    }
    
    
    
    class Program
    {
        static void Maon(string[] args)
        {
            //LinkedList<int> list = new LinkedList<int>();
            //LinkedListNode<int> a = list.First;
            //int b = a.Value;
            MyLinkedList m = new MyLinkedList();

            m.AddLast(1);
            m.AddLast(1);
            m.AddLast(1);
            m.AddLast(1);
            m.AddLast(1);
            m.AddLast(1);
            int a = m.count;
            m.Remove(m.Head);
            m.Remove(m.Head.Next.Next.Next);
            a = m.count; // 1+1+1+1+1+1+1+1개 = 7개
            
            //레드블랙트리
            // 힙트리 > DSF , BSF >  다익스트라 알고리즘 > 에이스타 알고리즘

        }
    }
}
