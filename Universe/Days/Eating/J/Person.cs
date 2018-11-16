namespace Universe.Days.Eating.J
{
    class Person : Thing
    {
        public void Eat(Food food) =>
            Act($"Ate {food}");
    }
}
