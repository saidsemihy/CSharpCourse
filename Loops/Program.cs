namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DoWhileLoop();
            //ForeachLoop();

            Console.ReadLine();
        }

        private static void ForeachLoop()
        {
            string[] students = { "Engin", "Derin", "Salih" };
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 11);
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}", number);
        }

        private static void ForLoop()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 100; i >= 0; i = i - 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
