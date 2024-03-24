namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();
            int number1 = 20;
            int number11;
            int number2 = 100;
            var result = Add3(ref number1 , number2);
            var result2 = Add4(out number11 , number2);
            //int sonuc=Add2(20, 30);
            Console.WriteLine(result);
            Console.WriteLine(number1);

            int carpim = Multiply(2, 4);
            Console.WriteLine(Multiply(2,4));
            Console.WriteLine(Multiply(2,4,6));
            Console.WriteLine(carpim);
            Console.WriteLine(Add5(1,2,3,4));


            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2)
        {
            var result = number1 + number2;
            return result;
        }

        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            var result = number1 + number2;
            return result;
        }
        static int Add4(out int number11, int number2)
        {
            number11 = 30;
            var result = number11 + number2;
            return result;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add5(int number,params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
