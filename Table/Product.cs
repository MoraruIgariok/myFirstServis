using Microsoft.EntityFrameworkCore;
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

        [MaxLength(100)]
        public string? Name { get; set; }
        public bool IsActive { get; set; }

        [MaxLength(200)]
        public string? Descripion { get; set; }

        [Precision(13,2)]
        public decimal Quantity { get; set; }

        [Precision(13,3)]
        public decimal Price { get; set; }

        //public BasketProduct BasketProduct { get; set; }    
        public List<BasketProduct> CurrentBasketProduct { get; set; }
        public List<DepositProduct> depositPorductList { get; set; }   

      
    }
} 

