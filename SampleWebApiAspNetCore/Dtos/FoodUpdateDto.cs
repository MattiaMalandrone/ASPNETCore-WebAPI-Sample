﻿
namespace SampleWebApiAspNetCore.Dtos
{
    public class FoodUpdateDto
    {
        public string? Name { get; set; }
        public bool? IsPoisonous { get; set; }
        public int Calories { get; set; }
        public string? Type { get; set; }
        public decimal Price { get; set; }
        public DateTime Created { get; set; }
    }
}
