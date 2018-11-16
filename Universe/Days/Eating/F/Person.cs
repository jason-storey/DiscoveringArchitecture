namespace Universe.Days.Eating.F
{
    class Person : Thing
    {
        public void Eat(Cookie cookie) => 
            Act($"Ate {cookie}");
    }
}
