﻿namespace Universe.Days.S
{
    class MarysHealthyBreakfast : Recipe
    {
        public Meal Create()
        {
            var meal = new Meal();
            meal.Name = "Breakfast";
            var cereal = new BranFlakes();
            meal.Add(cereal);
            meal.Add(new OrangeJuice());
            return meal;
        }
    }
}
