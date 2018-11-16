namespace Universe.Days.Eating.L
{
    class Person : Thing
    {
        public void Eat(Food food) =>
            Act($"Ate {food}");

        public void Drink(Drink drink) =>
            Act($"Drank {drink}");

        public void Eat(Meal meal)
        {
            Act($"Began {meal}");
            foreach (var item in meal.Food)
                Eat(item);

            foreach (var item in meal.Drinks)
                Drink(item);

        }

    }
}
