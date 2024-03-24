namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());



            Console.ReadLine();
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, FirstName = "said", LastName = "yalçın", Address = "ankara" });
            //Bunu customer olarak atadığım için olmuyor
            //manager.Add(new Student { Id = 1, FirstName = "said", LastName = "yalçın", Departmant = "ankara" });

            manager.Add2(new Customer { Id = 1, FirstName = "said", LastName = "yalçın", Address = "ankara" });
            manager.Add2(new Student { Id = 1, FirstName = "said", LastName = "yalçın", Departmant = "ankara" });
        }
    }

    interface IPerson
    {
         int Id { get; set; }
         string FirstName { get; set; }
         string LastName { get; set; }
    }
    class Customer : IPerson
    {
       public int Id { get; set; }
       public string FirstName { get; set; }
       public string LastName { get; set; }

        public string Address { get; set; }

    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Address);
        }
        public void Add2(IPerson person)
        {
            Console.WriteLine(person.LastName);
        }
    }
}
