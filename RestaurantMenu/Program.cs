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

            MenuItem pizza = new MenuItem("Pizza", 11, "Dinner", new DateTime(2021,01,05));
            MenuItem steak = new MenuItem("Steak", 35, "Dinner", new DateTime(2021, 04, 10));
            MenuItem burger = new MenuItem("Burger", 35, "Dinner", new DateTime(2019, 05, 19));
            MenuItem milkShake = new MenuItem("Milk Shake", 8, "Dessert", DateTime.Now);


            Menu.AddItem(pizza);
            Menu.AddItem(steak);
            Menu.AddItem(burger);
            Menu.AddItem(milkShake);

            Menu.PrintAll();
            Menu.LastUpdated();

            Console.WriteLine("\n\n***After RemoveItem***\n\n");
            Menu.RemoveItem(milkShake);
            Menu.PrintAll();
            Menu.LastUpdated();

            Console.WriteLine("\n\nPrint One Item\n\n");
            Menu.PrintOne(milkShake);

            Console.ReadLine();
        }
    }
}
