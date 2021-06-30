using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Chapter_18_Studio
{
    class MenuItem
    {
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
        public string newItem { get; set; }

        public string IsNew()
        {
            if (DateAdded > DateTime.Today.AddDays(-7))
            {
                newItem = "**NEW** ";
            }
            return newItem;
        }
        public MenuItem(string description, double price, string category, DateTime dateadded)
        {
            Description = description;
            Price = price;
            Category = category;
            DateAdded = dateadded;
        }
        public MenuItem(string description, double price, string category)
        {
            Description = description;
            Price = price;
            Category = category;
            DateAdded = DateTime.Now;
        }

    }
}
