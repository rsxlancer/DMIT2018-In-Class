using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eRestaurant.DAL;
using eRestaurant.Entities;
using System.ComponentModel;


namespace eRestaurant.BLL
{
    [DataObject]
    public class ReservationController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Reservation> getReservation(string EventCode)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                var data = from dog in context.Reservations
                           where dog.EventCode == EventCode
                           select dog;


                return data.ToList();
                
            }
        
        }
    }
}
