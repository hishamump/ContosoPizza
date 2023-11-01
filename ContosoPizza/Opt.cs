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
    }
}
