using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter_18_Studio
{
    class Program
    {
        static void Main(string[] args)
        {

            MenuItem pizza = new MenuItem("Pizza", 11.99, "Dinner", new DateTime(2021,01,05));
            MenuItem steak = new MenuItem("Steak", 34.99, "Dinner", new DateTime(2021, 04, 10));
            MenuItem burger = new MenuItem("Burger", 8.99, "Dinner", new DateTime(2019, 05, 19));
            MenuItem milkShake = new MenuItem("Milk Shake", 7.99, "Dessert");


            Menu.AddItem(pizza);
            Menu.AddItem(steak);
            Menu.AddItem(burger);
            Menu.AddItem(milkShake);

            Menu.PrintAll();
            Menu.LastUpdated();

            Console.WriteLine("\n***After RemoveItem***\n");
            Menu.RemoveItem(milkShake);
            Menu.PrintAll();
            Menu.LastUpdated();

            Console.WriteLine("\nPrint One Item\n");
            Menu.PrintOne(steak);

            Console.ReadLine();
        }
    }
}
