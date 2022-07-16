using System;

/*
*   C# Program for the presecribed challenge 4:
*       Basic Food ordering system
*   author: Nathan Hassett   
*/

namespace Challenge4
{
    class Program
    {
        //Create the restaurant list
                //making the list here for simplicity but this list could be taken from a database of restaurants or something
                //but for the purpose of this challenge i will just make fake data here
        static List<Restaurant> createRestaurantList()
        {
            //creat the restaurant list to return
            List<Restaurant> restaurantList = new List<Restaurant>();

            //create the burger place menu
            List<FoodItem> burgerPalaceMenu = new List<FoodItem>();
            burgerPalaceMenu.Add(new FoodItem("beef burger", 3.72));
            burgerPalaceMenu.Add(new FoodItem("chicken burger", 4.72));
            burgerPalaceMenu.Add(new FoodItem("vegie burger", 4.00));

            //create the ice cream place menu
            List<FoodItem> iceCreamMenu = new List<FoodItem>();
            iceCreamMenu.Add(new FoodItem("vanilla", 4.00));
            iceCreamMenu.Add(new FoodItem("chocolate", 4.00));
            iceCreamMenu.Add(new FoodItem("Rum n Raisin", 4.50));

            //create the pizza n pies place menu
            List<FoodItem> pizzaAndPiesMenu = new List<FoodItem>();
            pizzaAndPiesMenu.Add(new FoodItem("pepperoni pizza", 15.00));
            pizzaAndPiesMenu.Add(new FoodItem("Margherita pizza", 10.00));
            pizzaAndPiesMenu.Add(new FoodItem("meat pie", 8.50));
            pizzaAndPiesMenu.Add(new FoodItem("chicken pie", 9.50));
            
            //add the three restaurants to the restaurant list
            restaurantList.Add(new Restaurant("burger palace", burgerPalaceMenu));
            restaurantList.Add(new Restaurant("Ice Cream palour", iceCreamMenu));
            restaurantList.Add(new Restaurant("Pizza n Pies", pizzaAndPiesMenu));

            //return the list
            return restaurantList;
        }

        static void Main(string[] args)
        {
            //Create the restaurant list
                //using the made up data from the method above, but could even grab the data from a database
            List<Restaurant> restaurantList = createRestaurantList();

            //prompt the user to enter the food they want to order
            Console.WriteLine("Greetings! What would you like to eat?");

            //store the user input in a string
            string? input = Console.ReadLine();
            //create and index to find the menu item in the menus
            int index;

            //if the input is not null and the length is greater than 0 we can determing the most occuring char
            if(input != null && input.Length > 0)
            {
                //flag to set true if an item was found, if item wasnt found need to report it back to user
                bool foundItem = false;

                //cycle through the restaurants looking for the item searched
                foreach(Restaurant restaurant in restaurantList)
                {
                    //reset the index when looking through a new restaurant in the list
                    index = 0;

                    //cycle through the menu for the restaurant checking for the item needed
                    foreach(FoodItem item in restaurant.FoodMenu)
                    {
                        //if the item was found send the order to the restaurant
                        if(input == item.foodName)
                        {
                            //set the foundItem flag to true
                            foundItem = true;
                            //print the receipt from the restaraunt
                            Console.WriteLine(restaurant.printReceipt(index));
                            //break from the loop because an item was found
                            break;
                        }
                        //increment index after each item
                        index++;
                    }
                }
                //if an item wasn't found need to report back to the user
                if(!foundItem)
                {
                    Console.WriteLine("No item found");
                }
            }
            else //else report to the user no input was detected
            {
                Console.WriteLine("no input detected");
            }   
        }
    }
}