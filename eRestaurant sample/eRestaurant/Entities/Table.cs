using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities
{
    public class Table
    {
        //by convention, if we use a property with the same name as the class, but
        //with a suffix of ID, then Entity Framework will recognize that proerty
        //as mapping to the databasetable's Primary Key column.
        public int TableID { get; set; }
        public byte tableNumber { get; set;}
        public bool Smoking { get; set; }
        public int Capacity { get; set; }
        public bool Available { get; set; }

        #region Navigate Properties
        public virtual ICollection<Reservation> Reservations { get; set; }
        #endregion
    }
}
