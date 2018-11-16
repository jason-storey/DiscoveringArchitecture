namespace Universe.Days.G
{
    class Person : Thing
    {
        public void Eat(Cookie cookie) => 
            Act($"Ate {cookie}");

        public void Eat(Pancake pancake) =>
            Act($"Ate {pancake}");
    }
}
