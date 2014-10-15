﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace eRestaurant.Entities
{
    public class SpecialEvent
    {
        [Key]
        [Required(ErrorMessage="An Event Code is required (one character only)")]
        [StringLength(1, ErrorMessage = "Event Code can only use a single-character code")]
        public string EventCode { get; set; }
        [Required(ErrorMessage = "A Description is required(5-30 characters)")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Description must be 5-30 characters in length")]
        public string Description { get; set; }
        public bool Active { get; set; }

        #region Navigation Properties
        public virtual ICollection<Reservation> Reservations { get; set; }
        #endregion
    }
}
