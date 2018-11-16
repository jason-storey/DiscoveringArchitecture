namespace Universe.Days.Eating.I
{
    class Person : Thing
    {
        public void Eat(Food food) =>
            Act($"Ate {food}");
    }
}
