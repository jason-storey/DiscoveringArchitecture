namespace Universe.Examples.C
{
    class Person : Thing
    {
        public void Eat()
        {
            var cookie = new Cookie();
            Act($"Ate {cookie}");
        }
    }
}
