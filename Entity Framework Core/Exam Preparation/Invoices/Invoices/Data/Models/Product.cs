﻿using Invoices.Data.Models.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.Data.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }
        [Required]
        public CategoryType CategoryType { get; set; }

        public virtual ICollection<ProductClient> ProductsClients { get; set; } = new HashSet<ProductClient>();
    }
}
