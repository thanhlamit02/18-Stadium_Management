﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Unit { get; set; }

        public bool isDeleted { get; set; }

        public virtual HashSet<ServiceOrder> ServiceOrders { get; set; }

        public byte[] Image { get; set; }
    }
}
