class Program
{
    static void Main(string[] args)
    {
        
        var products = new List<Product>
        {
            new Product { Name = "Product A", Category = "Electronics", Price = 100 },
            new Product { Name = "Product B", Category = "Clothing", Price = 50 },
            new Product { Name = "Product C", Category = "Electronics", Price = 200 },
            new Product { Name = "Product D", Category = "Food", Price = 5 },
            new Product { Name = "Product E", Category = "Clothing", Price = 20 },
        };

        
        var filteredProducts = from p in products
                               where p.Category == "Electronics" && p.Price > 100
                               select p;

        
        foreach (var product in filteredProducts)
        {
            if (product.Price > 150)
            {
                Console.WriteLine($"{product.Name} is an expensive electronics product.");
            }
            else
            {
                Console.WriteLine($"{product.Name} is an affordable electronics product.");
            }
        }
    }
}

class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
}