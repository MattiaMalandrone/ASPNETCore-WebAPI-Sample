using SampleWebApiAspNetCore.Entities;
using SampleWebApiAspNetCore.Repositories;

namespace SampleWebApiAspNetCore.Services
{
    public class SeedDataService : ISeedDataService
    {
        public void Initialize(FoodDbContext context)
        {
            context.FoodItems.Add(new FoodEntity() { IsPoisonous = true, Calories = 1000, Type = "Starter", Name = "Lasagne", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { IsPoisonous = false, Calories = 1100, Type = "Main", Name = "Hamburger", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { Calories = 1200, Type = "Dessert", Name = "Spaghetti", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { IsPoisonous = false, Calories = 1300, Type = "Starter", Name = "Pizza", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { IsPoisonous = true, Calories = 1300, Type = "Test1", Name = "Test1", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { IsPoisonous = true, Calories = 1300, Type = "Test2", Name = "Test2", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { Calories = 1300, Type = "Test3", Name = "Test3", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { IsPoisonous = true, Calories = 1300, Type = "Test4", Name = "Test4", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { IsPoisonous = true, Calories = 1300, Type = "Test5", Name = "Test5", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { IsPoisonous = true, Calories = 1300, Type = "Test6", Name = "Test6", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { IsPoisonous = false, Calories = 1300, Type = "Test7", Name = "Test7", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { IsPoisonous = true, Calories = 1300, Type = "Test8", Name = "Test8", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { IsPoisonous = true, Calories = 1300, Type = "Test9", Name = "Test9", Created = DateTime.Now });
            context.FoodItems.Add(new FoodEntity() { IsPoisonous = true, Calories = 1300, Type = "Test10", Name = "Test10", Created = DateTime.Now });

            context.SaveChanges();
        }
    }
}
