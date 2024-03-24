namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number5 = 10.6;
            char character = 'A';
            bool condition = false;
            byte number4 = 255;
            short number3 = -32768;
            int number1 = 2147483647;//32 bit
            long number2 = -92222222222222222;//64 bit
            var number7 = 10;
            number7 = 'A';

            Console.WriteLine("Number1 is {0}", number1);
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Character is : {0}", (int)character);
            Console.WriteLine(Days.Monday);
            Console.WriteLine((int)Days.Monday);
            Console.ReadLine();


        }
    }
    enum Days
    {
        Monday=10, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
