using ContosoPizza.Data;
using ContosoPizza.Models;

namespace ContosoPizza
{
    public static class Opt
    {
        public static void AddProducts()
        {
            using ContosoPizzaContext context = new();

            Product veggieSpecial = new()
            {
                Name = "Veggie Special Pizza",
                Price = 9.22m
            };

            Product deluxeMeat = new()
            {
                Name = "Deluxe Meat Pizza",
                Price = 12.7m
            };

            context.Products.Add(veggieSpecial);
            context.Add(deluxeMeat);
            context.SaveChanges();
        }

        public static void QueryDataFluentAPI() {
            using ContosoPizzaContext context = new();
            var products = context.Products
                            .Where(p => p.Price > 10)
                            .OrderBy(p => p.Name);

            foreach ( var product in products )
            {
                Console.WriteLine($"Id: {product.Id}");
                Console.WriteLine($"Name: {product.Name}");
                Console.WriteLine($"Price: {product.Price}");
                Console.WriteLine(new string('-', 20));
            }
        }

        public static void QueryDataLinqSyntax()
        {
            using ContosoPizzaContext context = new();
            var products = from product in context.Products
                           where product.Price > 10
                           orderby product.Name
                           select product;

            foreach (var product in products)
            {
                Console.WriteLine($"Id: {product.Id}");
                Console.WriteLine($"Name: {product.Name}");
                Console.WriteLine($"Price: {product.Price}");
                Console.WriteLine(new string('-', 20));
            }
        }

        public static void RemoveProducts() { }
        public static void RemoveAllProducts() { }

    }
}
