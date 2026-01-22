namespace ConsoleApp251229
{
    struct Test
    {
        private int a;
        private char b;
        private int c;
        private byte d;
        private char e;

        public Test()
        {
            a = 1;
            b = 'b';
            c = 3;
            d = 5;
            e = 'c';
        }
    }

    

    class Program
    {
        static void Main()
        {
            //List<int> a = new();
            //List<double> d = new();
            //List<Program> b = new();
            //List<Test> c = new();
            Test[] t = new Test[1];
            t[0] = new Test();


        }
    }
}
