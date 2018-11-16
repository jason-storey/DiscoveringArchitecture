namespace Universe.Days.F
{
    class Person : Thing
    {
        public void Eat(Cookie cookie) => 
            Act($"Ate {cookie}");
    }
}
