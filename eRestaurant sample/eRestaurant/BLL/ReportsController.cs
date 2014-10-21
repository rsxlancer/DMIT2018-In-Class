﻿using eRestaurant.DAL;
using eRestaurant.Entities.POCO_s;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.BLL
{
    [DataObject]
    public class ReportsController
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<CategoryMenuItem> GetReportCategoryMenuItems()
        {
            using (var context = new RestaurantContext())
            {
                var results = from cat in context.Items
                              orderby cat.MenuCategory.Description, cat.Description
                              select new CategoryMenuItem()
                              {
                                  CategoryDescription = cat.MenuCategory.Description,
                                  ItemDescription = cat.Description,
                                  Price = cat.CurrentPrice,
                                  Calories = cat.Calories,
                                  Comment = cat.Comment
                              };
                return results.ToList();
            }
        }
    }
}
