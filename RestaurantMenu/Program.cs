using System;

namespace Chapter_18_Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem pizza = new MenuItem();

            pizza.Price = 11;
            pizza.Description = "Pizza";
            pizza.Category = "Main Course";
            pizza.DateAdded = new DateTime(2021, 06, 22);
            pizza.ItemIsNew = pizza.IsNew();

            Menu.MenuItems.Add(pizza);

            MenuItem steak = new MenuItem();

            steak.Price = 35;
            steak.Description = "Steak: Medium rare deliciousness";
            steak.Category = "Main Course";
            steak.DateAdded = new DateTime(2021, 06, 22);
            steak.ItemIsNew = pizza.IsNew();



            Menu.MenuItems.Add(steak);


            foreach (var menuItem in Menu.MenuItems)
            {
                Console.WriteLine($"${menuItem.Price}: {menuItem.Description}: {menuItem.ItemIsNew}");

            }


            Console.ReadLine();
        }
    }
}
