namespace LinqProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Bilgisayar"},
                new Category{CategoryId=2,CategoryName="Telefon"},
            };

            List<Product> products = new List<Product>
            {
                new Product{ ProductId = 1, CategoryId = 1, ProductName = "Laptop", QuantityPerUnit = "32 GB Ram", UnitPrice = 2500, UnitsInStock = 10 },
                new Product{ ProductId = 2, CategoryId = 1, ProductName = "Masaüstü Bilgisayar", QuantityPerUnit = "16 GB Ram", UnitPrice = 3500, UnitsInStock = 5 },
                new Product{ ProductId = 3, CategoryId = 2, ProductName = "Akıllı Telefon", QuantityPerUnit = "4 GB Ram", UnitPrice = 1500, UnitsInStock = 20 },
                new Product{ ProductId = 4, CategoryId = 2, ProductName = "Tablet", QuantityPerUnit = "8 GB Ram", UnitPrice = 800, UnitsInStock = 15 }
            };

            Console.WriteLine("Algoritmik--------------------");

            foreach (var product in products)
            {
                if (product.UnitPrice > 2000 && product.UnitsInStock > 3)
                {
                    Console.WriteLine(product.ProductName);
                }
            }

            Console.WriteLine("Linq--------------------");

            var result = products.Where(product => product.UnitPrice > 2000 && product.UnitsInStock > 3);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

           List<Product> urunler= GetProducts(products);
           List<Product> urunler2= GetProductsLinq(products);
        }

        static List<Product> GetProducts(List<Product> products)
        {
            List<Product> filteredProducts = new List<Product>(); 
            foreach (var product in products)
            {
                if (product.UnitPrice>5000 && product.UnitsInStock>3)
                {
                    filteredProducts.Add(product);
                }
            }
            return filteredProducts;
        }
        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(product => product.UnitPrice > 2000 && product.UnitsInStock > 3).ToList();
        }
    }
    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}