using System;

/*
*   Custom class for the Restaurant object
*   author: Nathan Hassett   
*/

namespace Challenge4
{
    public class Restaurant
    {   
        //name of the restaurant
        public string Name { get; set; }
        //menu of the restaurant (a list of food items they sell)
        public List<FoodItem> FoodMenu { get; set; }

        //constructer for a restaurant
        public Restaurant(string name, List<FoodItem> menu)
        {
            Name = name;
            FoodMenu = menu;
        }

        //Method for printing the receipt for the food order from the restaurant
        //index of the item on the menu list is passed to print out the details for that food item.
        public string printReceipt(int index)
        {
            return Name + "," + FoodMenu[index].foodName + ",$" + FoodMenu[index].Price.ToString("0.00");  
        }
    }
}