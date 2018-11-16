namespace Universe.Days.Eating.O
{
    class Kitchen
    {
        public Meal MakeBreakfast()
        {
            var meal = new Meal();
            meal.Name = "Breakfast";
            meal.Add(new Toast());
            meal.Add(new OrangeJuice());
            return meal;
        }

        public Meal MakeLunch()
        {
            var meal = new Meal();
            meal.Name = "Lunch";
            meal.Add(new Sandwich());
            meal.Add(new Water());
            return meal;
        }
    }
}
