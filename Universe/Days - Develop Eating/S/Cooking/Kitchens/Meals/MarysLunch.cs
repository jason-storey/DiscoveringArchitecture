﻿namespace Universe.Days.S
{
    class MarysLunch : Recipe
    {
        public Meal Create()
        {
            var meal = new Meal();
            meal.Name = "Lunch";
            var sandwich = new Sandwich();
            sandwich.Type = "Tuna Melt";
            meal.Add(sandwich);
            meal.Add(new Water());
            return meal;
        }
    }
}