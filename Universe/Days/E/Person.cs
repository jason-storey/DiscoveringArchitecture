namespace Universe.Examples.E
{
    class Person : Thing
    {
        public void Eat(string type)
        {
            var cookie = new Cookie();
            cookie.Type = type;
            Act($"Ate {cookie}");
        }
    }
}
