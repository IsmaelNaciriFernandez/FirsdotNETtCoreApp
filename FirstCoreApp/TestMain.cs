// See https://aka.ms/new-console-template for more information


namespace HelloWorld
{
    class TestMain
    {
        static void Main(string[] args)
        {
            WriteSomething();
        }

        public static void WriteSomething()
        { 
            Console.WriteLine("I am called from a method");
            Console.Read();
        }
    }
}