namespace Universe.Days.I
{
    class Person : Thing
    {
        public void Eat(Food food) =>
            Act($"Ate {food}");
    }
}
