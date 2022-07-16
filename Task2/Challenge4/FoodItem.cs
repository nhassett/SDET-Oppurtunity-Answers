using System;

/*
*   Custom class for the food items that restaraunts will sell
*   author: Nathan Hassett   
*/

namespace Challenge4
{
    public class FoodItem
    {   
        //name of the food item that appears on the menu
        public string foodName { get; set; }
        //price of the food item
        public double Price { get; set; }

        //constructer for a food item
        public FoodItem(string name, double price)
        {
            foodName = name;
            Price = price;
        }
    }
}