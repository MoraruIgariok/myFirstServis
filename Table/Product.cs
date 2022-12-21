using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstShop.Table
{
    public class Product
    {
        public Guid ProductId { get; set; }
        public string? Name { get; set; }
        public bool IsActive { get; set; }
        public string? Descripion { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }


        public List<BasketProduct> CurrentBasketProduct { get; set; }

      
    }
} 

