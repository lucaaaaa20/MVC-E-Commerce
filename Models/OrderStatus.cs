﻿using System.ComponentModel.DataAnnotations;

namespace MVCECommerce.Models
{
    public class OrderStatus
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Status { get; set; }
        public ICollection<Order> Order { get; set; }
    }
}
