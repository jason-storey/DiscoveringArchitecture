namespace Universe.Days.C
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
