using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities
{
    public class Item
    {
        public int ItemID { get; set; }
        public string Description { get; set; }
        public decimal CurrrentPrice { get; set; }
        public decimal CurrentCost { get; set; }
        public bool Active { get; set; }
        public int Calories { get; set; }
        public string Comment { get; set; }
        public virtual MenuCategory MenuCatagoryID { get; set; }
    }
}
