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

            MenuItem pizza = new MenuItem();
            MenuItem steak = new MenuItem();
            MenuItem burger = new MenuItem();

            pizza.AddItem("Pizza", 11, "Main Course", DateTime.Now);
            pizza.ItemIsNew = pizza.IsNew();
            Menu.menuItems.Add(pizza);

            steak.AddItem("Steak", 35, "Main Course", DateTime.Now);
            Menu.menuItems.Add(steak);
            steak.ItemIsNew = pizza.IsNew();

            steak.AddItem("Burger", 35, "Main Course", DateTime.Now);
            Menu.menuItems.Add(steak);
            steak.ItemIsNew = pizza.IsNew();

            
            
            foreach (var menuItem in Menu.menuItems)
            {
                Console.WriteLine($"${menuItem.Description}: {menuItem.Price}: {menuItem.ItemIsNew}");
            }



            //Console.WriteLine(pizza.DateAdded.Month.);

            //foreach (var Date in Menu.MenuItems)
            //{
            //    Menu.Dates.Add(Date.DateAdded.Month);
            //}
            //Menu.Dates.Sort();
            //Console.WriteLine($"Menu last updated{Menu.Dates[0]}.");

            Console.ReadLine();
        }
    }
}
