namespace Universe.Days.Eating.U
{
    class RushBreakfast : Recipe
    {
        public Meal Create()
        {
            var meal = new Meal();
            meal.Name = "Breakfast";
            var toast = new Toast();
            toast.Type = "Dry";
            meal.Add(toast);

            var coffee = new Coffee();
            coffee.Type = "Quick";
            meal.Add(coffee);
            
            return meal;
        }
    }
}