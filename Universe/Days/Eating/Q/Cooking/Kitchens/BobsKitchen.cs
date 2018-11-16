namespace Universe.Days.Eating.Q
{
    class BobsKitchen : Kitchen
    {
        public override Meal MakeBreakfast() => 
            new BobsBreakfast().Create();

        public override Meal MakeLunch() => 
            new BobsLunch().Create();
    }
}