namespace Universe.Days.H
{
    class Person : Thing
    {
        public void Eat(Apple apple) =>
            Act($"Ate {apple}");

        public void Eat(Cookie cookie) => 
            Act($"Ate {cookie}");

        public void Eat(Donut donut) =>
            Act($"Ate {donut}");

        public void Eat(Pancake pancake) =>
            Act($"Ate {pancake}");

        public void Eat(Sandwich sandwich) =>
            Act($"Ate {sandwich}");

        public void Eat(Steak steak) =>
            Act($"Ate {steak}");
    }
}
