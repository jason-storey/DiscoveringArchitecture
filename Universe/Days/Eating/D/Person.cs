namespace Universe.Days.Eating.D
{
    class Person : Thing
    {
        public void Eat()
        {
            var cookie = new Cookie();
            cookie.Type = "Chocolate Chip";
            Act($"Ate {cookie}");
        }
    }
}
