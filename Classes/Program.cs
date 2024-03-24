namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            
            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Said";
            customer.LastName = "Yalçın";
            customer.City = "İstanbul";

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "Ankara",
                FirstName = "Semih",
                LastName = "Yalçın"
            };

            Console.WriteLine(customer2.FirstName);
        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added!");
        }

        public void Update()
        {
            Console.WriteLine("Customer Update!");
        }
    }


}
