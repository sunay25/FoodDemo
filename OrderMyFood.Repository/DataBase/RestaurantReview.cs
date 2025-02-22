﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderMyFood.Repository.DataBase
{
    public class RestaurantReview
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; } // Foreign key to Restaurant
        public int CustomerId { get; set; } // Foreign key to Customer
        public string Comment { get; set; }
        public decimal Rating { get; set; }
        public bool IsModerated { get; set; } // Indicates if the review has been approved
        public DateTime ReviewDate { get; set; }

        // Navigation properties
        public virtual Restaurant Restaurant { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
