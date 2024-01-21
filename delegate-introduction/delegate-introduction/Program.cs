namespace delegate_introduction
{
    internal class Program
    {
        delegate int Operation(int x, int y);

        public static class Math
        {
            public static int Sum(int x, int y)
            {
                return x + y;
            }
        }

        static void Main(string[] args)
        {
            Operation operation = new Operation(Math.Sum);
            Console.WriteLine(operation(1,2));

        }
    }
}