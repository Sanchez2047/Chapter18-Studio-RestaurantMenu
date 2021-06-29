using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18_Studio
{
    class MenuItem
    {
        public int Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime DateAdded { get; set; }
        public string newItem { get; set; }
        public string ItemIsNew { get; set; }
        public string IsNew()
        {
            if (DateAdded > DateTime.Today.AddDays(-7))
            {
                newItem = "\nMenu Item is new.";
            }
            return newItem;
        }
        public void AddItem(string description, int price, string category, DateTime dateadded)
        {
            Description = description;
            Price = price;
            Category = category;
            DateAdded = dateadded;
        }




    }
}
