namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id=1,Name="Said",LastName="Yalçın",City="Ankara"};

            Customer customer2 = new Customer ( 1,"Said","Yalçın","Ankara");

            Customer customer3 = new Customer();
            customer.Id = 1;
        }
    }

    class Customer
    {
        //default constructor
        public Customer()
        {
            Console.WriteLine("Yapıcı blok çalıştı");
        }
        public Customer(int id,string name,string lastname,string city)
        {
            Id = id;
            Name = name;
            LastName = lastname;
            City = city;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
