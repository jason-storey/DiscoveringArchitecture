﻿namespace Universe.Days.Eating.Q
{
    class MarysKitchen : Kitchen
    {
        public override Meal MakeBreakfast() => 
            new MarysBreakfast().Create();

        public override Meal MakeLunch() => 
            new MarysLunch().Create();
    }
}