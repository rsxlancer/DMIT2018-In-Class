﻿using System;
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
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<MenuCategory> MenuCatagories { get; set; }
        public DbSet<Waiter> Waiters { get; set; }
        public DbSet<BillItem> BillItems { get; set; }

        #endregion

        #region Over-ride OnModelCreating
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Reservation>().HasMany(r => r.Tables)
                .WithMany(t => t.Reservations)
                .Map(mapping =>
                {
                    mapping.ToTable("ReservationTables");
                    mapping.MapLeftKey("ReservationID");
                    mapping.MapRightKey("TableID");
                });
            base.OnModelCreating(modelBuilder);
        }
        #endregion
    }
}
