namespace Universe.Days.Eating.K
{
    class Person : Thing
    {
        public void Eat(Food food) =>
            Act($"Ate {food}");

        public void Eat(Meal meal)
        {
            Act($"Began {meal}");
            foreach (var item in meal.Items)
                Eat(item);
        }

    }
}
