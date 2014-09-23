﻿using eRestaurant.DAL;
using eRestaurant.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.BLL
{
    [DataObject]
    public class RestaurantAdminController
    {
        #region Manage Waiters
        #region Command
        [DataObjectMethod(DataObjectMethodType.Insert,false)]
        public int AddWaiter(Waiter item)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                //TODO: Validation of waiter data...
                var added = context.Waiters.Add(item);
                context.SaveChanges();
                return added.WaiterID;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Update,false)]
        public void UpdateWaiter(Waiter item)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                //todo: Validation
                var attached = context.Waiters.Attach(item);
                var matchingWithExistingValues = context.Entry<Waiter>(attached);
                matchingWithExistingValues.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        
        [DataObjectMethod(DataObjectMethodType.Delete,false)]
        public void DeleteWaiter(Waiter item)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                var existing = context.Waiters.Find(item.WaiterID);
                context.Waiters.Remove(existing);
                context.SaveChanges();
            }
        }
        #endregion
        #region Query
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<Waiter> ListAllWaiters()
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                return context.Waiters.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public Waiter GetWaiter(int waiterID)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                return context.Waiters.Find(waiterID);
            }
        }
        #endregion
        #endregion
        

        #region Manage Tables 
        #region Command
        [DataObjectMethod(DataObjectMethodType.Insert,false)]
        public int AddTable(Table item)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                var added = context.Tables.Add(item);
                context.SaveChanges();
                return added.TableID;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void UpdateTable(Table item)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                var attached = context.Tables.Attach(item);
                var matchingWithExistedValues = context.Entry<Table>(attached);
                matchingWithExistedValues.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void DeleteTable(Table item)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                var existing = context.Tables.Find(item.TableID);
                context.Tables.Remove(existing);
                context.SaveChanges();
            }
        }
        #endregion
        #region Query
        #endregion
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Table> ListAllTables()
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                return context.Tables.ToList();
            }

        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Table GetTable(int tableID)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                return context.Tables.Find(tableID);
            }
        }
        #endregion
       

        #region Manage Items
        #region Command
        [DataObjectMethod(DataObjectMethodType.Insert,false)]
        public int AddItem(Item item)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                var added = context.Items.Add(item);
                context.SaveChanges();
                return added.ItemID;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void UpdateItem(Item item)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                var attached = context.Items.Attach(item);
                var matchingWithExistedValues = context.Entry<Item>(attached);
                matchingWithExistedValues.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete,false)]
        public void DeleteItem(Item item)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                var existing = context.Items.Find(item.ItemID);
                context.Items.Remove(existing);
                context.SaveChanges();
            }
        }
        #endregion
        #region Query
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<Item> ListAllItems()
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                return context.Items.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public Item GetItem(int ItemID)
        {
            using(RestaurantContext context = new RestaurantContext())
            {
                return context.Items.Find(ItemID);
            }
        }
        #endregion
        #endregion
        

        #region Manage Special Events
        #region Command
        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public string AddEvent(SpecialEvent item)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                //TODO: Validation of waiter data...
                var added = context.SpecialEvents.Add(item);
                context.SaveChanges();
                return added.EventCode;
            }
        }

        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void UpdateEvent(SpecialEvent item)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                //todo: Validation
                var attached = context.SpecialEvents.Attach(item);
                var matchingWithExistingValues = context.Entry<SpecialEvent>(attached);
                matchingWithExistingValues.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void DeleteEvent(SpecialEvent item)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                var existing = context.SpecialEvents.Find(item.EventCode);
                context.SpecialEvents.Remove(existing);
                context.SaveChanges();
            }
        }
        #endregion
        #region Query
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<SpecialEvent> ListAllEvents()
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                return context.SpecialEvents.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public SpecialEvent GetEvent(string EventCode)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                return context.SpecialEvents.Find(EventCode);
            }
        }
        #endregion
        #endregion


    }
}
