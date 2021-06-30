using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18_Studio
{
    class Menu
    {
        public static List<MenuItem> menuItems { get; set; } = new List<MenuItem>();
        public static List<DateTime> Dates { get; set; } = new List<DateTime>();
        public static string ShortDate { get; set; }

        public static void PrintOne(MenuItem item)
        {        
            Console.WriteLine($"{item.Category}: {item.Description} == ${item.Price}");
            Console.WriteLine(item.IsNew());
        }
        public static void PrintAll()
        { 
            foreach (var menuItem in menuItems)
            {
                Console.Write(menuItem.IsNew());
                Console.WriteLine($" {menuItem.Category}: {menuItem.Description} == ${menuItem.Price}");
                Console.WriteLine();
            }
        }
        public static void AddItem(MenuItem item)
        {
            menuItems.Add(item);
            Dates.Add(item.DateAdded);
        }
        public static void RemoveItem(MenuItem item)
        {
            menuItems.Remove(item);
            Dates.Remove(item.DateAdded);
        }
        public static void LastUpdated()
        {
            Dates.Sort();
            Dates.Reverse();
            Console.WriteLine($"Menu Last Updated {Dates[0].Month}/{Dates[0].Day}/{Dates[0].Year}");

        }
    }
}
