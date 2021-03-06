﻿using System.Collections.Generic;

namespace Sys.Eating
{
    public class Meal
    {
       List<Food> Food = new List<Food>();
       List<Drink> Drinks = new List<Drink>();

        public void Eat(Eater eater)
        {
            foreach (var item in Food)
                eater.Eat(item);

            foreach (var item in Drinks)
                eater.Drink(item);
        }

        public void Add(Food food) => 
            Food.Add(food);

        public void Add(Drink drink) => 
            Drinks.Add(drink);

    }
}
