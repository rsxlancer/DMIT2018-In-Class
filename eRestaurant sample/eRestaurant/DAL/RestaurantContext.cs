using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eRestaurant.Entities;

namespace eRestaurant.DAL
{
    public class RestaurantContext : DbContext
    {
        //Constructor that calls a base constructor to specify
        //the connection string we need to use
        public RestaurantContext() : base("name=EatIn") { }

        #region table to entity mappings
        public DbSet<Table> Tables { get; set; }
        public DbSet<SpecialEvent> SpecialEvents { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        #endregion

    }
}
