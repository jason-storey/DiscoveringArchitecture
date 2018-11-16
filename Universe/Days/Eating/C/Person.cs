namespace Universe.Days.Eating.C
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
