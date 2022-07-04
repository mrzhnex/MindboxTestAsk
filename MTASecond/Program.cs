using System;
using MTASecond.Database;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MTASecond
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (ApplicationContext db = new())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                Product apple = new() { Name = "Apple" };
                Product milk = new() { Name = "Milk" };
                db.Products.AddRange(apple, milk);

                Category food = new() { Name = "Food" };
                Category fruit = new() { Name = "Fruit" };
                db.Categories.Add(food);

                apple.Categories.Add(food);
                apple.Categories.Add(fruit);
                milk.Categories.Add(food);

                Product other = new() { Name = "Unknown stuff" };
                db.Products.Add(other);

                db.SaveChanges();
            }

            using (ApplicationContext db = new())
            {
                var products = db.Products.FromSqlRaw("SELECT * From Products").Include(x => x.Categories).ToList();
                foreach (var product in products)
                {
                    if (product.Categories.Count == 0)
                        Console.WriteLine($"{product.Name} - out of category"); //если нет категории, но имя все равно должно выводиться,
                                                                                //было принято решение писать "out of category"
                    foreach (Category category in product.Categories)
                    {
                        Console.WriteLine($"{product.Name} - {category.Name}");
                    }
                }
            }
        }
    }
}