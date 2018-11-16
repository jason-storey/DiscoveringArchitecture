namespace Universe.Days.Eating.U
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
            meal.Eat(this);
        }
    }
}
