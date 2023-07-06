using SampleWebApiAspNetCore.Entities;
using SampleWebApiAspNetCore.Repositories;

namespace SampleWebApiAspNetCore.Services
{
    public class SeedDataService : ISeedDataService
    {
        public void Initialize(FoodDbContext context)
        {
            context.FoodItems.Add(new FoodEntity() { IsPoisonous = true, Type = "Starter", Name = "Lasagne", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { IsPoisonous = false, Calories = 99, Type = "Main", Name = "Hamburger", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { Calories = 72, Type = "Dessert", Name = "Spaghetti", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { IsPoisonous = false, Calories = 12, Type = "Starter", Name = "Pizza", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { IsPoisonous = true, Calories = 25, Type = "Test1", Name = "Test1", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { IsPoisonous = true, Calories = 100, Type = "Test2", Name = "Test2", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { Calories = 0, Type = "Test3", Name = "Test3", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { IsPoisonous = true, Calories = 0, Type = "Test4", Name = "Test4", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { IsPoisonous = true, Calories = 0, Type = "Test5", Name = "Test5", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { IsPoisonous = true, Calories = 0, Type = "Test6", Name = "Test6", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { IsPoisonous = false, Calories = 0, Type = "Test7", Name = "Test7", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { IsPoisonous = true, Calories = 0, Type = "Test8", Name = "Test8", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { IsPoisonous = true, Calories = 2, Type = "Test9", Name = "Test9", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { IsPoisonous = true, Calories = 95, Type = "Test10", Name = "Test10", Created = DateTime.Now });

            context.SaveChanges();
        }
    }
}
