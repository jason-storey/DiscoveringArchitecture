namespace Universe.Days.Eating.R
{
    class TunaLunch : Recipe
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