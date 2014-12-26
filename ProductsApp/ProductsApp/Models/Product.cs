﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProductsApp.Models
{
    public class Product
    {   
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}