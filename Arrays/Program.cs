namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Engin";
            students[0] = "Derin";
            students[0] = "Salih";

            string[] students2 = { "Engin", "Derin", "Salih" };

            foreach (string student in students)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[5, 3]
                {
                {"İstanbul","İzmit","Balıkesir" },
                {"ankara","konya","kırıkkale" },
                {"antalya","adana","mersin" },
                {"rize","trabzon","samsun" },
                {"izmir","muğla","manisa" }
                };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("********");
            }
            Console.ReadLine();
        }
    }
}
